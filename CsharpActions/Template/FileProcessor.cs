namespace CSharpActions.Template;

public abstract class FileProcessor(string path)
{
    public int Process()
    {
        try
        {
            using var reader = new StreamReader(path);
            var result = InitialValue();

            while (reader.ReadLine() is { } line) result = GetResult(result, int.Parse(line));

            return result;
        }
        catch (IOException e)
        {
            throw new ArgumentException($"{path}에 해당하는 파일이 없습니다.", e);
        }
    }

    protected abstract int GetResult(int result, int number);

    protected virtual int InitialValue()
    {
        return 0;
    }
}