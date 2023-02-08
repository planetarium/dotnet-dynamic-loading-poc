using InterfaceProject;
namespace FirstImplementation;
public class Action : IAction
{
    IAccountStateDelta IAction.Execute(IActionContext context) {
        return new AccountStateDelta();
    }
}
