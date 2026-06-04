# dotnet-skill

Tiny .NET tool that prints the current .NET agent skill definition to stdout.

## Install or run

```bash
dotnet tool install -g dotnet-skill
dotnet skill
```

Run without installing:

```bash
dnx dotnet-skill -y
```

## Development

```bash
dotnet run --project src/dotnet-skill -c Release
dotnet pack src/dotnet-skill -c Release
```

The tool intentionally has no subcommands and no test infrastructure. If this grows to multiple skills later, that should be a separate plural command surface such as `dotnet skills ls` and `dotnet skills show`.

## Publishing

CI builds, packs, smoke-tests, and uploads the NuGet package artifact. To publish, run the `Publish` workflow manually with the CI run ID and `confirm` set to `publish`; it pushes the package to NuGet and creates a GitHub release.
