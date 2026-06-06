#:property TargetFramework=$(DefaultTargetFramework)

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
using var stream = assembly.GetManifestResourceStream("dotnet-skill.SKILL.md");

if (stream is null)
{
    await Console.Error.WriteLineAsync("Error: SKILL.md resource not found.");
    return 1;
}

using var reader = new StreamReader(stream);
Console.Write(await reader.ReadToEndAsync());

return 0;
