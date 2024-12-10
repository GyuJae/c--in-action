using CSharpActions.Adapter;
using CSharpActions.Adapter.Security;
using JetBrains.Annotations;

namespace CSharpActionsTest.Adapter;

[TestSubject(typeof(AccountUserDetailsService))]
public class AccountUserDetailsServiceTest
{

    [Fact(DisplayName = "(Adapter) AccountService를 LoginHandler에서 쓸 수 있다.")]
    public void Account_User_Details_Service_Login_Handler()
    {
        var accountService = new AccountService();
        var userDetailsService = new AccountUserDetailsService(accountService);
        var loginHandler = new LoginHandler(userDetailsService);

        var result = loginHandler.Login("gyujae", "gyujae");
        
        Assert.Equal("gyujae", result);
    }
    
}