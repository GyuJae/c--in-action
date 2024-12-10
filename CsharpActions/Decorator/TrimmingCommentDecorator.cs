namespace CSharpActions.Decorator;

public class TrimmingCommentDecorator(ICommentService commentService) : CommentDecorator(commentService)
{
    public override string AddComment(string comment)
    {
        return base.AddComment(Trim(comment));
    }

    private static string Trim(string comment)
    {
        return comment.Trim();
    }
}