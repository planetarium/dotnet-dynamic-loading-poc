namespace InterfaceProject;
public interface IAction
{
    IAccountStateDelta Execute(IActionContext context);

    string Name { get; }
}
