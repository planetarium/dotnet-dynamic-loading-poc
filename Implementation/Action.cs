using InterfaceProject;
namespace Implementation;
public class Action : IAction
{
    IAccountStateDelta IAction.Execute(IActionContext context) {
        Console.WriteLine("Logging block index : " + context.BlockIndex);
        return new AccountStateDelta();
    }
}
