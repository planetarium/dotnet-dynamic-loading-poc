using Runner;

Console.WriteLine("Hello, World!");
string basePath = System.Environment.CurrentDirectory;
string[] assemblyPaths = new[] {
    Path.GetFullPath(Path.Combine(basePath, "Implementation", "bin", "Debug", "net6.0", "Implementation.dll")),
};

Console.WriteLine(assemblyPaths[0]);
var context = new PluginLoadContext(assemblyPaths[0]);
var assembly = context.LoadFromAssemblyName(new System.Reflection.AssemblyName(Path.GetFileNameWithoutExtension(assemblyPaths[0])));

var type = assembly.GetType("Implementation.Action");
Console.WriteLine(Activator.CreateInstance(type) is InterfaceProject.IAction);