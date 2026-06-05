#:property TargetFramework=net10.0
#:property Authors=Richard Lander
#:property AssemblyName=dotnet-skill
#:property PackageId=dotnet-skill
#:property VersionPrefix=0.1.0
#:property ToolCommandName=dotnet-skill
#:property Description=Prints the .NET agent tool catalog.
#:property PackageLicenseExpression=MIT
#:property PackageReadmeFile=README.md
#:property PackageOutputPath=../../artifacts/package/release
#:property PublishAot=true
#:property RollForward=LatestMajor
#:property UseSystemResourceKeys=true
#:property InvariantGlobalization=true
#:property OptimizationPreference=Size

var skillPath = Path.Combine(AppContext.BaseDirectory, "SKILL.md");

if (!File.Exists(skillPath))
{
    await Console.Error.WriteLineAsync("Error: SKILL.md file not found.");
    return 1;
}

Console.Write(await File.ReadAllTextAsync(skillPath));

return 0;
