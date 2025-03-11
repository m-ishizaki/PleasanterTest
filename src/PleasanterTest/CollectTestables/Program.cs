using System.Reflection;

Count(typeof(Implem.MySql.MySqlObjectFactory));
Count(typeof(Implem.PostgreSql.PostgreSqlObjectFactory));
Count(typeof(Implem.SqlServer.SqlServerObjectFactory));
Count(typeof(Implem.CodeDefiner.Starter));
Count(typeof(Implem.DefinitionAccessor.CodeColumn2nd));
Count(typeof(Implem.DisplayAccessor.Display));
Count(typeof(Implem.Factory.RdsFactory));
Count(typeof(Implem.Libraries.Classes.Csv));
Count(typeof(Implem.ParameterAccessor.Parts.ActionTypes));
Count(typeof(Implem.Pleasanter.Controllers.AdminsController));
Count(typeof(Implem.Plugins.IPdfPlugin));
Count(typeof(Implem.TestAutomation.Parts.AutoTestLog));

static void Count(Type type)
{
    var asm = Assembly.GetAssembly(type)!;
    var types = asm.GetTypes().Where(x => x.IsClass && x.IsPublic).ToArray();
    Console.WriteLine($"{asm.FullName?.Split(',')[0],-25}, classes: {types.Length,3}, methods: {types.Select(x => x.GetMethods().Length).Sum(),5}, properties: {types.Select(x => x.GetProperties().Length).Sum(),6}");
}