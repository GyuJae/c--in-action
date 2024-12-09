using CSharpActions;

namespace CSharpActionsTest;

public class SingletonTests
{
    [Fact(DisplayName = "Non Thread Safe 싱글톤 테스트 입니다.")]
    public void Singleton1_Should_Return_Same_Instance()
    {
        var instance1 = Singleton1.GetInstance();
        var instance2 = Singleton1.GetInstance();
        
        Assert.Same(instance1, instance2);
    }


    [Fact(DisplayName = "Thread Safe 싱글톤 테스트 입니다.")]
    public void Singleton2_Should_Return_Same_Instance()
    {
        var instance1 = Singleton2.GetInstance();
        var instance2 = Singleton2.GetInstance();
        
        Assert.Same(instance1, instance2);
    }
    
    [Fact(DisplayName = "Lazy 싱글톤 테스트 입니다.")]
    public void Singleton3_Should_Return_Same_Instance()
    {
        var instance1 = Singleton3.GetInstance();
        var instance2 = Singleton3.GetInstance();
        
        Assert.Same(instance1, instance2);
    }
    
     [Fact(DisplayName = "가장 간단한(?) 싱글톤 테스트 입니다.")]
     public void Singleton5_Should_Return_Same_Instance()
     {
         var instance1 = Singleton5.Instance;
         var instance2 = Singleton5.Instance;
         
         Assert.Same(instance1, instance2);
     }   
}