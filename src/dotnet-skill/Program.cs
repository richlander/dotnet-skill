using System.Reflection;

const string SkillResourceName = "dotnet-skill.SKILL.md";

var assembly = Assembly.GetExecutingAssembly();
await using var stream = assembly.GetManifestResourceStream(SkillResourceName);

if (stream is null)
{
    await Console.Error.WriteLineAsync("Error: SKILL.md resource not found.");
    return 1;
}

using var reader = new StreamReader(stream);
Console.Write(await reader.ReadToEndAsync());

return 0;
