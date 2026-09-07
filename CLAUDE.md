# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Session Start

**Always read first:** `.claude/STATUS.md` (quick checkpoint, ~50 lines) — current state, next actions, blockers.

**Resuming work?** `.claude/session-log.md` (recent session history).

**Planning an epic?** `.planning/` (design docs, plans, diagrams).

Update `STATUS.md` and `session-log.md` proactively as work progresses — this repo is tracked the same way as IndyPOS and Recorder.

---

## Overview

MimyMart is a desktop Point-of-Sale application for a minimart (adapted from the same lineage as IndyPOS). Single-terminal Windows deployment.

**Tech stack:** .NET 8, Windows Forms (WinExe), Clean Architecture, CQRS via MediatR, Dapper, SQLite (POS data) + PostgreSQL (reports), Prism EventAggregator, Serilog.

## Common Commands

```bash
# Build the whole solution
dotnet build MimyMart.sln

# Run all tests
dotnet test

# Run tests for one project
dotnet test tests/MimyMart.Application.Tests

# Run a single test / class (xUnit filter)
dotnet test --filter "FullyQualifiedName~CreateInvoiceCommandHandlerTests"
dotnet test --filter "Name~Handle_WithValidCommand_ShouldReturnId"

# Run the desktop app (Windows only; requires the data files below to exist)
dotnet run --project src/MimyMart.Windows.Forms
```

## Runtime Prerequisites (Debug)

The app reads config and data from fixed `C:\ProgramData\MimyMart\` paths (see `appsettings.json`). Before running:

- **Database:** a pre-created `Store.db` (SQLite) at `C:\ProgramData\MimyMart\db\Store.db`.
- **Store config:** `C:\ProgramData\MimyMart\Config\StoreConfiguration.json`.
- Logs write to `C:\ProgramData\MimyMart\Logs\log.json` (daily rolling, compact JSON).
- DB + CSV backups target a Google Drive path (`G:\My Drive\MimyMart\...`) when `Database:BackupEnabled` is true.

## Architecture

Clean Architecture with a strict dependency flow: **Domain ← Application ← Infrastructure**, and **Windows.Forms** composing everything at the top.

### Layers (`src/`)

- **`MimyMart.Domain`** (`net8.0`) — entities (`Invoice`, `InvoiceProduct`, `InventoryProduct`, `Payment`, `UserAccount`, ...) and domain events. No dependencies except `Prism.Core`.
- **`MimyMart.Application`** (`net8.0`) — use cases as vertical feature slices. Depends only on Domain.
- **`MimyMart.Infrastructure`** (`net8.0-windows`) — persistence + hardware/OS services. Implements Application abstractions.
- **`MimyMart.Windows.Forms`** (`net8.0-windows`, WinExe) — thin UI + composition root.

### CQRS convention (the key pattern to understand)

Commands/queries do **not** use MediatR's `IRequest` directly. The Application layer defines thin wrapper interfaces in `Abstractions/Messaging/` — `ICommand`, `ICommand<T>`, `IQuery<T>` (extend `IRequest`) and `ICommandHandler<>`, `IQueryHandler<>` (extend `IRequestHandler`). Always implement handlers against these wrappers, not raw MediatR types.

Each feature folder under `Application/<Feature>/` is a self-contained slice:

```
Invoices/
  Commands/CreateInvoice/{CreateInvoiceCommand, ...Handler, ...Validator}.cs
  Queries/GetInvoiceById/{GetInvoiceByIdQuery, ...Handler}.cs
  InvoiceDto.cs
  InvoiceExtensions.cs      # ToEntity()/ToDto() mapping lives here — no AutoMapper
```

- **Validation** is a MediatR pipeline behavior: `ValidationBehavior<,>` runs all FluentValidation `IValidator<TRequest>` before the handler and throws the app's own `ValidationException` on failure. Add a `*Validator` next to a command to wire it in — registration is automatic.
- **Handler/validator registration is by assembly scan** (`AddMediatR` + `AddValidatorsFromAssembly` in `Application/ConfigureServices.cs`). New handlers/validators need no manual registration. (Note: this differs from IndyPOS, which registers each handler individually.)

### Dual database (non-obvious)

Two separate data stores, selected by which repository namespace is registered in `Infrastructure/ConfigureServices.cs`:

- **SQLite** (`Persistence/Repositories/SQLite/`) — the primary transactional POS store (`Store.db`): invoices, products, users, store constants. `IDbConnectionProvider` opens the SQLite connection.
- **PostgreSQL** (`Persistence/Repositories/PostgreSql/`) — reports only (`ReportRepository` / `IReportDbConnectionProvider`), via `Npgsql`.

Both use **Dapper** (no EF Core). Connection string for reports comes from `ConnectionStrings:MimyMartPosDb`.

### UI ↔ backend communication

- Entry point `Program.cs` builds a generic `Host` (`Host.CreateDefaultBuilder`), wires Serilog, loads `appsettings.json`, registers services via three extension methods (`AddApplicationServices`, `AddUIServices`, `AddInfrastructureServices`), then resolves `IMachine` and calls `Launch()`. It also enforces a single running instance (kills prior `MimyMart` processes).
- Forms and panels (`Windows.Forms/UI/`) are registered as **singletons** and injected. The UI sends commands/queries through MediatR (`IMediator`).
- **`Prism.Events.IEventAggregator`** is the pub/sub bus bridging backend services and the UI (e.g. notifying panels of sale/inventory changes) — look here rather than for direct form references when tracing cross-component notifications.

### Hardware & OS integration (`Infrastructure/Services/`)

Because of physical POS peripherals, Infrastructure and the UI target `net8.0-windows`:

- `CashDrawerService` — opens the drawer over a serial/USB port (`System.IO.Ports`).
- `ReceiptPrinterService` — thermal receipt printing.
- `BarcodeGeneratorService` — barcode images via `ZXing.Net`.
- `RawInputDeviceService` — captures barcode-scanner input as a raw HID device.
- `StoreConfigurationService`, `CryptographyService`, `CsvService`, `JsonService`, `DateTimeService`.

Repositories are registered as **singletons**; stateless helper services (`Cryptography`, `Json`, `Barcode`, `DateTime`, `Csv`) as transient.

## Tests (`tests/`)

- **xUnit** + **AutoFixture** (with `AutoMoq` and `Xunit2` attributes) + **FluentAssertions** + **Moq**.
- `MimyMart.Mock` — shared test fixtures/attributes (e.g. custom AutoData attributes) reused across the test projects.
- `MimyMart.Application.Tests` targets `net8.0`; `MimyMart.Infrastructure.Tests` and `MimyMart.Windows.Forms.Tests` target `net8.0-windows`.
- **`xunit.runner.visualstudio` must be referenced by every test project** or `dotnet test`
  silently reports "no test is available" and runs none of that project's tests. This was
  missing from `MimyMart.Windows.Forms.Tests` and `MimyMart.Application.Tests` originally —
  the former is now fixed; the latter still needs it if its tests are to run.

## Conventions

- **File-scoped namespaces**, PascalCase public members, `_camelCase` private fields. Source is **tab-indented** (see `MimyMart.sln.DotSettings`).
- DI extension methods deliberately live in the `Microsoft.Extensions.DependencyInjection` namespace (`// ReSharper disable CheckNamespace`) so they surface on `IServiceCollection` without extra usings.
- `Throw` (guard-clause library) is used for argument validation in the Application layer.

---

## Domain and Data Constraints

Non-obvious rules that look like bugs and are not. Ported from MimyShop, where each cost real
money or a crashed till.

### The barcode scan pipeline

Three separate defences, each covering a case the others cannot. Don't collapse them.

- **`BarcodeScanBuffer` must empty itself as it hands the barcode over.** Publishing is
  synchronous and a subscriber's modal dialog runs a nested message loop that keeps delivering
  `WM_INPUT`, so the next scan's keystrokes arrive *before* the publish returns. Clearing the
  buffer *after* publishing sent both barcodes out concatenated (`620584635384620584635384` in
  MimyShop's real log). **Never reintroduce a separate `Clear()` after a publish** —
  `TryTake` hands the barcode over and empties the buffer in one step.
- **`BarcodeScanGate`** (UI panels) stops a *reentrant* scan opening `ShowDialog` twice on a
  singleton form — which killed the process with nothing in the log.
- **`DuplicateScanFilter`** (500 ms) drops the repeat reads a hands-free presentation scanner
  produces. ⚠️ **Do not widen the window.** 500 ms is short on purpose: two identical items
  presented that fast is physically unreachable, but a wider window swallows genuine double
  purchases and under-charges.

**Three scanner settings the app depends on**, all factory defaults: **USB-KBW** interface
(Virtual COM / RS-232 make it invisible to raw input), **USA** keyboard layout
(`Win32.TranslateVirtualKeyToUnicode` hardcodes `US_KEYBOARD_ID`), and **Add terminal CR**
(`RawInputDeviceService` only publishes on ENTER, so without it scans silently never register).

**A scanner that types tripled / ASCII-looking digits is in the wrong output mode — factory-reset
it.** A new 2D scanner shipped in a non-default mode and produced digits as zero-padded decimal
ASCII codes on the numpad with ALT held (`'6'` → ALT+`054`), which the app reads as raw input and
cannot compose. This is a **scanner-config problem, not a code bug** — scanning the scanner's
`Factory default settings` restores `*Original data output`. An app-side ALT-code decoder was
built in MimyShop and then reverted as YAGNI once the log proved the real fix was the reset.

**Diagnosing any scanner problem starts with the built-in trace.** `RawInputDeviceService` logs
every key the *paired* scanner sends at Debug (`Scanner sent ...`), plus how long subscribers hold
the UI thread. Filter `log.json` for `Scanner sent` and group by `ENTER` before theorising.

### `RawInputDeviceService.Stop()` disposes the subclass

`Start()` subclasses the main form's HWND to intercept `WM_INPUT`. `Stop()` calls
`RawInput.Dispose()`, which removes the message filter and releases the handle on the UI thread —
if it only nulled the reference (as it did before hardening), cleanup fell to a finalizer calling
WinForms APIs off the UI thread, which is never safe. `RawInputDeviceServiceTests` pins that the
window procedure is restored.
