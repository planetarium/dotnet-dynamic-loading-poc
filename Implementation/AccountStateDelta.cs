using InterfaceProject;
namespace Implementation;
public class AccountStateDelta : IAccountStateDelta {
    Bencodex.IValue IAccountStateDelta.GetState(string key)
    {
        throw new NotImplementedException();
    }
}
