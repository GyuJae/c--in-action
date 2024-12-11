namespace CSharpActions.Strategy;

public class Faster : ISpeed
{
    public string BlueLight()
    {
        return "무궁화꽃이";
    }

    public string RedLight()
    {
        return "피었습니다.";
    }
}