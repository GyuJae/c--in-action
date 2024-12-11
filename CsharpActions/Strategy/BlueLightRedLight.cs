namespace CSharpActions.Strategy;

public class BlueLightRedLight
{
    public string BlueLight(ISpeed speed)
    {
        return speed.BlueLight();
    }

    public string RedLight(ISpeed speed)
    {
        return speed.RedLight();
    }
}