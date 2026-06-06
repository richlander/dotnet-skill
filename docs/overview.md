# dotnet-skill overview

`dotnet-skill` is a tiny .NET tool that prints the embedded `src/dotnet-skill/SKILL.md` catalog to stdout.

Its purpose is not to document every .NET agent workflow. Its purpose is to give agents a small, always-available router that helps them choose a tool and then delegate to that tool's own skill output.

## Core idea

`dotnet skill` occupies the same space as `SKILL.md`, `marketplace.json`, and `plugin.json` in other agent ecosystems: it provides a small amount of session-start context that helps an agent decide what capability to load next.

The important constraint is **token discipline**. The catalog should stay short. It should describe what tool to use for a task family and where to get detailed, versioned guidance.

## Architecture

- `src/dotnet-skill/dotnet-skill.cs` is a file-based .NET app.
- `src/dotnet-skill/SKILL.md` is embedded as a resource.
- Running the tool reads that embedded resource and writes it to stdout.
- The tool intentionally has no subcommands and no test project.

## Agent contract

Agents working in this repo should preserve this shape:

1. Keep `SKILL.md` as a router catalog.
2. Do not duplicate full tool-specific guidance in `dotnet-skill`.
3. Point to tool-owned skill commands, such as `dnx dotnet-inspect -y -- skill`.
4. Keep detailed design rationale in docs, not in `AGENTS.md`.

## Design references

- [router-skill-design.md](router-skill-design.md) explains the relationship to `SKILL.md`, `marketplace.json`, and `plugin.json` systems.
- `AGENTS.md` is a resolver for agents; it points to this overview and the deeper design doc.
