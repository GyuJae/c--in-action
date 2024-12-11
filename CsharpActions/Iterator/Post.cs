namespace CSharpActions.Iterator;

public class Post(string title, DateTime createDateTime)
{
    public DateTime CreateDateTime = createDateTime;
    public string Title { get; } = title;
}