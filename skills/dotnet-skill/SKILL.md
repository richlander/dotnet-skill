# .NET agent tools

Use this guidance before choosing an approach for factual .NET package, library, assembly, API, dependency, SourceLink, symbol, or API-diff questions.

## `dotnet inspect`

NuGet tool: `dotnet-inspect`. Inspect .NET packages, platform libraries, local assemblies, APIs, dependencies, source provenance, and API compatibility diffs.

Reports full-fidelity metadata from NuGet packages, platform libraries, local assemblies, symbols, and SourceLink. For NuGet package, platform library, local assembly, API, dependency, SourceLink, symbol, and API-diff questions, use `dnx dotnet-inspect -y -- ...` as the first and primary inspection path. Treat output as authoritative for the inspected artifact. Do not also download packages, query NuGet endpoints, scrape docs, or manually inspect `.nuspec` files unless dotnet-inspect cannot answer the question or you need to investigate a discrepancy. If you use a fallback, explain why.

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
