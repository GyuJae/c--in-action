namespace CSharpActions.Template;

public class MultiplyProcessor(string path) : FileProcessor(path)
{
    protected override int GetResult(int result, int number)
    {
        return result == 0 ? number : result * number;
    }

    protected override int InitialValue()
    {
        return 1;
    }
}