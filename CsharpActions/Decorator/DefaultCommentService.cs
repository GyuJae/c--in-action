namespace CSharpActions.Decorator;

public class DefaultCommentService: ICommentService
{
    public string AddComment(string comment)
    {
        return comment;
    }
}