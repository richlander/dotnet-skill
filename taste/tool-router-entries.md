# Tool router entries

Use this pattern for each tool entry in `src/dotnet-skill/SKILL.md`:

```text
## tool-name

[paragraph that exactly matches what would or does show up as the YAML description in a SKILL.md file]

First run the `tool-name` skill: `invocation`
```

Rules:

- The description paragraph should be one paragraph and should match the tool skill's YAML `description` when that exists.
- The `First run ...` line should be separate from the description paragraph.
- The invocation line should not end with a trailing period.
- Keep `dotnet skill` as a router. Do not add workflow details, examples, or option guidance here; those belong in the tool-owned skill.

Good:

```text
## dotnet-inspect

Find evidence instead of guessing for .NET packages, platform libraries, local assemblies, APIs, dependencies, SourceLink/symbol provenance, and version-to-version API changes.

First run the `dotnet-inspect` skill: `dnx dotnet-inspect -y -- skill`
```

Bad:

```text
## dotnet-inspect

Use `dotnet-inspect` when you need evidence. First run the `dotnet-inspect` skill: `dnx dotnet-inspect -y -- skill`.

Then invoke `dotnet-inspect` through `dnx`:

    dnx dotnet-inspect -y -- <command>
```
