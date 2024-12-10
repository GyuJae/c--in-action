namespace CSharpActions.Flyweight;

public class FontFactory
{
    private readonly Dictionary<string, Font> _cache = new();

    public Font GetFont(string fontName)
    {
        if (_cache.TryGetValue(fontName, out var font))
        {
            return font;
        }
        else
        {
            var split = fontName.Split(":");
            var newFont = new Font(split[0], int.Parse(split[1]));
            _cache.Add(fontName, newFont);
            return newFont;
        }
        
    }
}