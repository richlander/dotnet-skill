# `dotnet skill` router design

`dotnet skill` is a small, built-in router for .NET agent tooling. Its job is to help an agent choose the right .NET tool and then delegate to that tool's own skill output.

## Relationship to skill packaging systems

`dotnet skill` occupies the same design space as `marketplace.json`, `plugin.json`, and `SKILL.md`-based skill systems: it gives an agent a small amount of task-routing context at the start of a session.

Those systems generally solve three problems:

1. **Voluntary and selective acquisition**: a user or agent chooses which skills/tools to install.
2. **Updating**: installed skills/tools can be updated independently.
3. **Small session footprint**: only summary guidance is loaded by default; detailed guidance is pulled on demand.

For the .NET SDK scenario, the first two problems are solved differently:

- The user has already selected the .NET SDK.
- The intended end state is for `dotnet skill` to be available from the official .NET CLI and forward to `dnx dotnet-skill`, which gives the catalog an update path through NuGet.

That leaves the third problem: **small session footprint**.

## Router contract

`dotnet skill` should print a concise catalog. It should identify which .NET tool to use for a task and point the agent at that tool's authoritative, versioned skill output.

It should not become a long multi-tool manual. If the catalog eventually covers many tools, every session should still pay only the token cost of a router summary.

Recommended shape:

```text
Use this tool for <task family>.
Run <tool> skill for authoritative workflow guidance.
Invoke with <stable command pattern>.
```

For example:

```bash
dnx dotnet-inspect -y -- skill
```

## Tool-specific skill contract

Each tool owns its detailed guidance. Tool-specific skill output can include workflows, syntax guardrails, examples, output-shape advice, and known pitfalls because the agent requested that tool intentionally.

This keeps `dotnet skill` aligned with the spirit of `SKILL.md`: summary tokens by default, detailed task-specific guidance only after routing.

## Non-goals

- Do not duplicate each tool's full `SKILL.md`.
- Do not list every command or option for every tool.
- Do not turn `dotnet skill` into a generalized documentation bundle.
- Do not require agents to read unrelated tool guidance before acting.
