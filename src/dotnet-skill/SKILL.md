# .NET agent tools

Use this as a router for .NET agent tools. Pick the matching tool, then run that tool's own skill command for current, task-specific guidance.

Keep this catalog small. It should help choose the next command, not teach every workflow.

## API, package, assembly, and dependency evidence

Use `dotnet-inspect` when you need evidence instead of guesses for .NET packages, platform libraries, local assemblies, APIs, dependencies, SourceLink/symbol provenance, or version-to-version API changes.

Get the authoritative `dotnet-inspect` workflow guide:

```bash
dnx dotnet-inspect -y -- skill
```

Treat `dotnet-inspect` output as authoritative for inspected artifacts. Do not download packages, query NuGet endpoints, scrape docs, or manually inspect `.nuspec` files unless `dotnet-inspect` cannot answer the question or you need to investigate a discrepancy.
