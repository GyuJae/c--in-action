namespace CSharpActions.Flyweight;

public class Character(string value, string color, Font font)
{
    private string _value = value;
    private string _color = color;
    private readonly Font _font = font;
    
    public Font GetFont() => _font;
}