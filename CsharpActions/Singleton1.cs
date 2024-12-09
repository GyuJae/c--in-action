namespace CSharpActions;

public class Singleton1
{
    private static Singleton1 _instance = null!;
    
    private Singleton1()
    {
    }

    public static Singleton1 GetInstance()
    {
        return _instance ??= new Singleton1();
    }
}