using CSharpActions.Decorator;
using JetBrains.Annotations;

namespace CSharpActionsTest.Decorator;

[TestSubject(typeof(CommentDecorator))]
public class CommentDecoratorTest
{

    [Fact(DisplayName = "(Decorator) 댓글 추가의 다양한 기능이 존재합니다." )]
    public void Comment_Decorator_Test()
    {
        ICommentService commentService = new DefaultCommentService();
        commentService = new SpanFilteringCommentDecorator(commentService);
        commentService = new TrimmingCommentDecorator(commentService);

        var comment1 = commentService.AddComment("안녕");
        var comment2 = commentService.AddComment("http:// 어저구 저쩌구");
        var comment3 = commentService.AddComment("   뭐야  ");
        
        Assert.Equal("안녕", comment1);
        Assert.Equal("스팸 댓글입니다.", comment2);
        Assert.Equal("뭐야", comment3);
    }
}