namespace CSharpActions.Adapter.Security;

public interface IUserDetails
{
    String GetUserName();

    String GetPassword();
}