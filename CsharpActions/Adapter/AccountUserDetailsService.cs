using CSharpActions.Adapter.Security;

namespace CSharpActions.Adapter;

public class AccountUserDetailsService(AccountService accountService) : IUserDetailsService
{
    private readonly AccountService _accountService = accountService;
    
    public IUserDetails LoadUser(string username)
    {
        return new AccountUserDetails(_accountService.FindAccountByUsername(username));
    }
}