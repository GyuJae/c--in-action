namespace CSharpActions.Decorator;

public class SpanFilteringCommentDecorator(ICommentService commentService) : CommentDecorator(commentService)
{
    private readonly ICommentService _commentService = commentService;

    public override string AddComment(string comment)
    {
        return IsSpan(comment) ? "스팸 댓글입니다." : _commentService.AddComment(comment);
    }

    private static bool IsSpan(string comment)
    {
        return comment.Contains("http");
    }
}