# Subject

When the `Name` property was introduced in `IAction` interface, how it works?

# Command

```
dotnet run --project ./Runner__IAction_NamePropertyAdded
```

# Result

It fails with the below logs.

```
Unhandled exception. System.TypeLoadException: Method 'get_Name' in type 'Implementation.Action' from assembly 'Implementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' does not have an implementation.
   at System.Reflection.RuntimeAssembly.GetType(QCallAssembly assembly, String name, Boolean throwOnError, Boolean ignoreCase, ObjectHandleOnStack type, ObjectHandleOnStack keepAlive, ObjectHandleOnStack assemblyLoadContext)
   at System.Reflection.RuntimeAssembly.GetType(String name, Boolean throwOnError, Boolean ignoreCase)
   at System.Reflection.Assembly.GetType(String name)
   at Program.<Main>$(String[] args) in /path/to/dotnet-dynamic-loading-poc/Runner__IAction_NamePropertyAdded/Program.cs:line 12
```

## Links

- CoreCLR source code [here](https://github.com/dotnet/runtime/blob/d913b94d041e192ab2f389ecae6b972da2094560/src/coreclr/vm/assemblynative.cpp#L338).
