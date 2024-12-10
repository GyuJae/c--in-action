namespace CSharpActions.Decorator;

public class CommentDecorator(ICommentService commentService) : ICommentService
{
    private readonly ICommentService _commentService = commentService;
    
    public virtual string AddComment(string comment)
    {
        return _commentService.AddComment(comment);
    }
}