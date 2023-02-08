namespace InterfaceProject;
public interface IAction
{
    IAccountStateDelta Execute(IActionContext context);
}
