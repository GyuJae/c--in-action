using CSharpActions.Adapter.Security;

namespace CSharpActions.Adapter;

public class AccountUserDetails(Account account) : IUserDetails
{

    private readonly Account _account = account;

    public string GetUserName()
    {
        return _account.Name;
    }

    public string GetPassword()
    {
        return _account.Password;
    }
}