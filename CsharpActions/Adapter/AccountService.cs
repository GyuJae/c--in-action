namespace CSharpActions.Adapter;

public class AccountService
{
    public Account FindAccountByUsername(string username)
    {
        return new Account
        {
            Name = username,
            Password = username,
            Email = $"{username}@example.com"
        };
    }

    public void CreateNewAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public void UpdateAccount(Account account)
    {
        throw new NotImplementedException();
    }
}