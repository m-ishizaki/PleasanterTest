using System.Reflection;

const string path = @"..\..\..\..\..\..\Implem.Pleasanter\Implem.Pleasanter\bin\Release\";
if (!Directory.Exists(path)) return;
var directory = Directory.GetDirectories(path, "net*").OrderByDescending(x => decimal.TryParse(x.Substring(3), out var d) ? d : 0).FirstOrDefault();
if (string.IsNullOrWhiteSpace(directory)) return;
var files = Directory.GetFiles(directory, "Implem.*.dll");
foreach(var file in files)
{
    var asm = Assembly.LoadFrom(Path.GetFullPath(file));
    var types = asm.GetTypes();
    foreach (var type in types)
    {
        Console.WriteLine(type.FullName);
        foreach (var met in type.GetMethods())
        {
            Console.WriteLine(met);
        }
    }
}