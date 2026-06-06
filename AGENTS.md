# Agent Instructions

## Repository map

Read this file first, then use the docs it points to:

- `README.md`: human and agent entrypoint for running, building, publishing, and finding design docs.
- `docs/overview.md`: minimum system/architecture context for this repo.
- `docs/router-skill-design.md`: design rationale for why `dotnet skill` is a concise router inspired by `SKILL.md`, `marketplace.json`, and `plugin.json`.
- `src/dotnet-skill/SKILL.md`: embedded catalog printed by the tool; keep it small and router-like.

Do not put the full design rationale in AGENTS.md. Keep AGENTS.md as a resolver that points to the right source of truth.

## File-Based Apps

Do NOT use `dotnet-script`, `dotnet script`, `dotnet-fsi`, or `.csx` files. Always use file-based apps (new in .NET 10). Always prefer file-based apps over Python, unless a specific Python library is needed.

Run with `dotnet run /tmp/check.cs`. Write throwaway scripts to `/tmp/`.

Reference: <https://raw.githubusercontent.com/dotnet/docs/refs/heads/main/docs/core/sdk/file-based-apps.md>

## Building

Build the tool:

```bash
dotnet build src/dotnet-skill/dotnet-skill.cs -c Release
```

Run the tool from source:

```bash
dotnet run src/dotnet-skill/dotnet-skill.cs -c Release
```

This repo intentionally does not include a test project. The tool's contract is that running it prints the embedded catalog markdown to stdout.
