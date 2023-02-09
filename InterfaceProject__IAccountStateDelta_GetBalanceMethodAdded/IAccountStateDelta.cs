namespace InterfaceProject;
public interface IAccountStateDelta
{
    string GetState(string key);

    long GetBalance(string key) { throw new NotImplementedException(); }
}
