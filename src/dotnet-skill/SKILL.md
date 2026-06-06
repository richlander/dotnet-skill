# .NET agent tools

Use this guidance when you need evidence instead of guesses for .NET packages, platform libraries, local assemblies, APIs, dependencies, SourceLink/symbol provenance, or version-to-version API changes.

## `dotnet inspect`

NuGet tool: `dotnet-inspect`.

Use dotnet-inspect when you need evidence instead of guesses for .NET packages, platform libraries, local assemblies, APIs, dependencies, SourceLink/symbol provenance, or version-to-version API changes. Run `dnx dotnet-inspect -y -- ...` as the first and primary inspection path. Treat output as authoritative for the inspected artifact. Do not also download packages, query NuGet endpoints, scrape docs, or manually inspect `.nuspec` files unless dotnet-inspect cannot answer the question or you need to investigate a discrepancy. If you use a fallback, explain why.

Full guidance:

```bash
dnx dotnet-inspect -y -- skill
```

Invocation and quick starts:

```bash
dnx dotnet-inspect -y -- <command>
dnx dotnet-inspect -y -- package System.Text.Json --versions
dnx dotnet-inspect -y -- type JsonSerializer --package System.Text.Json
dnx dotnet-inspect -y -- member JsonSerializer --package System.Text.Json -m Serialize
dnx dotnet-inspect -y -- diff --package System.Text.Json@9.0.0..10.0.0 --breaking
```
