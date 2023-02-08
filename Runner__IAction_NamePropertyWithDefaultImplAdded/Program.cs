using Runner;

string basePath = System.Environment.CurrentDirectory;
string[] assemblyPaths = new[] {
    Path.GetFullPath(Path.Combine(basePath, "Implementation", "bin", "Debug", "net6.0", "Implementation.dll")),
};

var context = new PluginLoadContext(assemblyPaths[0]);
var assembly = context.LoadFromAssemblyName(new System.Reflection.AssemblyName(Path.GetFileNameWithoutExtension(assemblyPaths[0])));

var type = assembly.GetType("Implementation.Action");
var instance = Activator.CreateInstance(type);

if (instance is InterfaceProject.IAction action) {
    Console.WriteLine(action.Name);
}
