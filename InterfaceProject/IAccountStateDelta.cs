namespace InterfaceProject;
public interface IAccountStateDelta
{
    Bencodex.IValue GetState(string key);
}
