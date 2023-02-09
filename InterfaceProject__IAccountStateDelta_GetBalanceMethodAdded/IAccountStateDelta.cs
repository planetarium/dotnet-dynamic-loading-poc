namespace InterfaceProject;
public interface IAccountStateDelta
{
    Bencodex.IValue GetState(string key);

    long GetBalance(string key) { throw new NotImplementedException(); }
}
