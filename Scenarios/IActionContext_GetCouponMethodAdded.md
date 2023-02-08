# Command

```
dotnet run --project ./Runner__IActionContext_GetCouponMethodAdded
```

# Description

*잘 적기 위해서 한국어로 적습니다.*

이 프로젝트의 목적은 `IAction.Execute(IActionContext)` 메소드의 인자로 들어가는 `IActionContext`에 변화가 생겼을 때 어떻게 동작하는지에 대한것 이었습니다.

이 프로젝트에서는 `IActionContext` 에 `Coupon IActionContext.GetCoupon()` 이라는 메소드를 추가해보기도 하고 `long IActionContext.BlockIndex { get; }` 을 `int IActionContext.BlockIndex { get; }` 로 바꿔 보기도 하였습니다.

액션 타입을 load하거나 형변환을 할 때는 정상적으로 동작하지만 `IAction.Execute(IActionContext)` 를 호출할때 에러가 발생합니다. 기존 액션의 경우 `IActionContext.GetCoupon()` 을 호출하지 않기 때문에 관련 에러는 발생하지 않지만 `int IActionContext.BlockIndex` 처럼 프로퍼티의 시그니처를 변경한 경우 `Execute`를 실행하는 중에 에러가 발생합니다.

```
Test
Unhandled exception. System.MissingMethodException: Method not found: 'Int64 InterfaceProject.IActionContext.get_BlockIndex()'.
   at Implementation.Action.InterfaceProject.IAction.Execute(IActionContext context)
   at Program.<Main>$(String[] args) in /path/to/dotnet-dynamic-loading-poc/Runner__IActionContext_GetCouponMethodAdded/Program.cs:line 17
```
