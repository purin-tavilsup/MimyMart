# MimyMart - Session Log

> Recent session history. Archive to `session-log-archive.md` when this exceeds ~100 lines.

## 2026-07-24 — Claude Code onboarding

- Analyzed the codebase (Clean Architecture, .NET 8 WinForms POS).
- Created `CLAUDE.md`: commands, layer/dependency flow, CQRS wrapper convention, dual-DB (SQLite POS + PostgreSQL reports), Prism EventAggregator UI bridge, hardware services, test stack.
- Created `.claude/STATUS.md`, this session log, and the `.planning/` scaffold — matching the IndyPOS/Recorder tracking workflow.
- No code changes. Branch `main` clean @ `51ddf1e`.

## 2026-07-26 — Forked MimyMart into MimyShop

- Brainstormed → spec → plan → 8-task subagent-driven execution → merged.
- Spec and plan committed here on `spec/mimyshop-rebrand` (never merged to `main`).
- **No tracked file in MimyMart was modified.** `main` remains at `51ddf1e`.
- Result lives at `C:\personal\MimyShop` (branch `main`, no remote). See its
  `.claude/STATUS.md` for detail.

## 2026-09-07 — Ported the raw-input hardening back from MimyShop

Branch `feat/raw-input-hardening`, 3 commits, **not merged, not pushed**. Brought the
scanner improvements that shipped to MimyShop `main` back into MimyMart (the pre-fork
baseline had none of them).

- **`fix: harden the raw input barcode pipeline`** — upgraded the vendored `RawDeviceInput`
  lib to the hardened version (per-instance keyboard driver + packet buffer, `Dispose()`
  pattern, single-lock device lookup, buffers freed on throw, immutable `KeyPressEvent`,
  `KeyPressState` enum, culture/nullability warnings). Rewrote `RawInputDeviceService`:
  buffer empties on take (the `620584635384620584635384` concatenation bug),
  ENTER matched on `VK_RETURN`, `DuplicateScanFilter` (500 ms), `Stop()` disposes, keystroke
  trace at Debug. Added `BarcodeScanBuffer` + `DuplicateScanFilter`.
- **`fix: gate reentrant scans in the sale and inventory panels`** — `BarcodeScanGate` +
  `ILogger<T>` on both panels.
- **`test: pin the raw input hardening`** — new `MimyMart.Infrastructure.Tests` project
  (11 tests) + gate/service tests in `Windows.Forms.Tests` (5 tests). **Also added
  `xunit.runner.visualstudio`** to `Windows.Forms.Tests` — without it `dotnet test` found
  *zero* tests there, so its existing tests were never running. `Application.Tests` still has
  the same gap.

**Scope decision:** the "ASCII values" issue Pond remembered was a *scanner-config* problem
(factory-reset restores `*Original data output`), not code — MimyShop's app-side ALT-code
decoder (`cf86c46`, reflog only) was reverted as YAGNI and was **deliberately not ported**.
The knowledge is in `CLAUDE.md` → Domain and Data Constraints.

**Open:** hardware pass on a real till (no scanner was attached during this port); decide
whether to merge this branch, push it, and whether to start tracking `CLAUDE.md`/`.claude/`
in MimyMart's git (currently untracked, unlike MimyShop). Full solution build green;
16 ported tests pass.
