using Runner;

Console.WriteLine("Hello, World!");
string basePath = System.Environment.CurrentDirectory;
string[] assemblyPaths = new[] {
    Path.GetFullPath(Path.Combine(basePath, "FirstImplementation", "bin", "Debug", "net6.0", "FirstImplementation.dll")),
};

Console.WriteLine(assemblyPaths[0]);
var context = new PluginLoadContext(assemblyPaths[0]);
var assembly = context.LoadFromAssemblyName(new System.Reflection.AssemblyName(Path.GetFileNameWithoutExtension(assemblyPaths[0])));

// Occur exception.
Console.WriteLine(string.Join(", ", assembly.GetTypes().Select(t => t.FullName)));

var type = assembly.GetType("FirstImplementation.Action");
Console.WriteLine(Activator.CreateInstance(type) is InterfaceProject.IAction);