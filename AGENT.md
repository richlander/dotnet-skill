# Agent Instructions

## File-Based Apps

Do NOT use `dotnet-script`, `dotnet script`, `dotnet-fsi`, or `.csx` files. Always use file-based apps (new in .NET 10). Always prefer file-based apps over Python, unless a specific Python library is needed.

Run with `dotnet run /tmp/check.cs`. Write throwaway scripts to `/tmp/`.

Reference: <https://raw.githubusercontent.com/dotnet/docs/refs/heads/main/docs/core/sdk/file-based-apps.md>

## Building

Build the tool:

```bash
dotnet build src/dotnet-skill -c Release
```

Run the tool from source:

```bash
dotnet run --project src/dotnet-skill -c Release
```

This repo intentionally does not include a test project. The tool's contract is that running it prints the embedded skill markdown to stdout.
