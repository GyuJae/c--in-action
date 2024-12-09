namespace CSharpActions;

public class Singleton3
{
    private Singleton3() {}

    private static readonly Lazy<Singleton3> Instance = new(() => new Singleton3());
    
    public static Singleton3 GetInstance() => Instance.Value;
}