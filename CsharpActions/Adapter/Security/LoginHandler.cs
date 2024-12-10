namespace CSharpActions.Adapter.Security;

public class LoginHandler(IUserDetailsService userDetailsService)
{
    public String Login(string username, string password)
    {
        var userDetails = userDetailsService.LoadUser(username);
        if (userDetails.GetPassword().Equals(password))
        {
            return userDetails.GetUserName();
        }

        throw new ArgumentException("Invalid username or password");
    }
}