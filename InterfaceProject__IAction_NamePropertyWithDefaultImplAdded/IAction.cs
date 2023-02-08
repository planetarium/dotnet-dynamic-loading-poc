namespace InterfaceProject;
public interface IAction
{
    IAccountStateDelta Execute(IActionContext context);

    string Name => "Name's default return value";
}
