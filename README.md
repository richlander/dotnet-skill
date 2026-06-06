# dotnet-skill

Tiny .NET tool that prints a .NET agent tool catalog to stdout.

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
dotnet run src/dotnet-skill/dotnet-skill.cs -c Release
dotnet pack src/dotnet-skill/dotnet-skill.cs -c Release
```

The app is file-based: `dotnet-skill.cs` embeds `SKILL.md` and prints it. The tool intentionally has no subcommands and no test infrastructure. It prints the current catalog and exits. If this grows to multiple skills later, that should be a separate plural command surface such as `dotnet skills ls` and `dotnet skills show`.

## Publishing

CI builds, packs, smoke-tests, and uploads the pointer, any, and RID-specific NuGet package artifacts. To publish, run the `Publish` workflow manually with the CI run ID and `confirm` set to `publish`; it pushes the RID packages first, then the pointer package, and creates a GitHub release.
