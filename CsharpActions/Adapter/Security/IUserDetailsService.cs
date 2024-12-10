namespace CSharpActions.Adapter.Security;

public interface IUserDetailsService
{
    IUserDetails LoadUser(String username);
}