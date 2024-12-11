namespace CSharpActions.Template;

public class AddProcessor(string path) : FileProcessor(path)
{
    protected override int GetResult(int result, int number)
    {
        return result + number;
    }
}