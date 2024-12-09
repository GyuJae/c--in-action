namespace CSharpActions;

public class Singleton5
{
    private Singleton5()
    {
    }

    public static Singleton5 Instance { get; } = new();
}