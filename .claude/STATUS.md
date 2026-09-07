# MimyMart - Current Status

> Quick checkpoint for session start / context handoff (~50 lines max)

## Current State

| Field | Value |
|-------|-------|
| **Branch** | `feat/raw-input-hardening` (3 commits, not merged, not pushed) |
| **Phase** | 🟡 Raw-input hardening ported from MimyShop — code + tests done, needs a real-till hardware pass |
| **Blocked?** | Not blocked. Awaiting decisions: merge/push branch; hardware pass; whether to track docs in git. |

## ⏯️ RESUME HERE (2026-09-07) — Raw-input hardening ported from MimyShop

Ported the barcode-scanner improvements from MimyShop `main` onto branch
**`feat/raw-input-hardening`** (3 commits). MimyMart was the pre-fork baseline and had none
of them. Full build green; **16 ported tests pass** (11 in a new `MimyMart.Infrastructure.Tests`,
5 in `Windows.Forms.Tests`). See `session-log.md` (2026-09-07) for the commit breakdown.

- The "ASCII values" fix Pond remembered was a **scanner factory-reset**, not code — the reverted
  ALT-code decoder was **not** ported (decision A). Details in `CLAUDE.md` → Domain and Data Constraints.
- **Next:** (1) hardware pass on a real till — nothing was scanned during the port;
  (2) decide whether to merge + push the branch (MimyMart `main` was previously kept pristine);
  (3) decide whether to commit `CLAUDE.md`/`.claude/` to git (still untracked here, unlike MimyShop).
- Found + fixed a latent bug: `Windows.Forms.Tests` (and still `Application.Tests`) lacked
  `xunit.runner.visualstudio`, so `dotnet test` discovered **zero** tests there.

## ⏯️ Earlier (2026-07-26) — MimyShop forked from this repo

MimyMart was cloned into **`C:\personal\MimyShop`** (standalone repo, full history,
permanent fork) and fully rebranded. **MimyMart itself is unchanged** — `main` is still
at `51ddf1e` and no tracked file was modified.

- Spec + plan live on branch **`spec/mimyshop-rebrand`** here (4 commits, never merged
  to `main`). Decide whether to merge or delete that branch.
- MimyShop's own tracking is at `C:\personal\MimyShop\.claude\STATUS.md`.
- MimyMart has **never been installed** on this machine — `C:\ProgramData\MimyMart\`
  does not exist. MimyShop uses `C:\ProgramData\MimyShop\`, so they cannot collide.

### Earlier — repo initialized for Claude Code (2026-07-24)

**What happened:** Analyzed the codebase and set up the same session-tracking workflow MimyMart's siblings (IndyPOS, Recorder) use:
- `CLAUDE.md` — architecture, commands, CQRS/dual-DB/Prism conventions.
- `.claude/STATUS.md` (this file), `.claude/session-log.md`, `.planning/` scaffold.

**Known baseline (from git history):** recent work added a cash-drawer service (serial/USB), cash-flow calculator + cash total in reports, and Thai-Windows backup path handling.

**NEXT (when work starts):** pick the first task/epic, capture it in `.planning/`, and start logging here + in `session-log.md`.

## Notes / Watch-outs

- Runtime needs `C:\ProgramData\MimyMart\db\Store.db` and `...\Config\StoreConfiguration.json` present.
- Reports use a **separate PostgreSQL** connection; the POS store is **SQLite**. Don't conflate them.
- Infrastructure + UI target `net8.0-windows` (peripherals) — tests for those run on Windows only.
