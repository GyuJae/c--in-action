namespace CSharpActions;

public class Singleton2
{
    private static Singleton2 _instance = null!;
    private static readonly Lock Lock = new();
    
    private Singleton2() { }

    public static Singleton2 GetInstance()
    {
        lock (Lock)
        {
            _instance ??= new Singleton2();
        }
        
        return _instance;
    }
    
}