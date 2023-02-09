# Command

```
dotnet run --project ./Runner__IAccountStateDelta_GetBalanceMethodAdded
```

# Description

이 프로젝트에서는 인터페이스 메소드의 반환 타입 인터페이스가 변경될 경우 어떻게 동작하는지를 보는 것이 목적이었습니다. 때문에 `IAccountStateDelta`에 `long IAccountStateDelta.GetBalance(string)` 메소드를 추가해보았습니다. 그리고 `IAccountStateDelta IAction.Execute(IActionContext)`를 실행할 때 에러가 발생합니다.

```
Test
Unhandled exception. System.TypeLoadException: Method 'GetBalance' in type 'Implementation.AccountStateDelta' from assembly 'Implementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' does not have an implementation.
   at Implementation.Action.InterfaceProject.IAction.Execute(IActionContext context)
   at Program.<Main>$(String[] args) in /path/to/dotnet-dynamic-loading-poc/Runner__IAccountStateDelta_GetBalanceMethodAdded/Program.cs:line 17
```

`GetBalance`로 확장할 때도 그렇고 `GetState`를 지워도 모두 실패합니다.

```
Test
Unhandled exception. System.MissingMethodException: Method not found: 'System.String InterfaceProject.IAccountStateDelta.GetState(System.String)'.
   at Implementation.Action.InterfaceProject.IAction.Execute(IActionContext context)
   at Program.<Main>$(String[] args) in /path/to/dotnet-dynamic-loading-poc/Runner__IAccountStateDelta_GetBalanceMethodAdded/Program.cs:line 17
```

만약 인터페이스 메소드 기본 구현을 주게 된다면 메소드를 추가해도 문제는 없지만 `IAccountStateDelta`를 반환 받아 처리하는 쪽에서 추가적으로 처리를 해줘야할 수 있습니다. (i.e., Libplanet 코드 가정 오염.)

추가한 코드:

```csharp
-     long GetBalance(string key);
+     long GetBalance(string key) { throw new NotImplementedException(); }
```

출력:

```
Test
Logging block index : 0
Unhandled exception. System.NotImplementedException: The method or operation is not implemented.
   at InterfaceProject.IAccountStateDelta.GetBalance(String key) in /Users/moreal/github/planetarium/dotnet-dynamic-loading-poc/InterfaceProject__IAccountStateDelta_GetBalanceMethodAdded/IAccountStateDelta.cs:line 6
   at Program.<Main>$(String[] args) in /path/to/dotnet-dynamic-loading-poc/Runner__IAccountStateDelta_GetBalanceMethodAdded/Program.cs:line 18
```