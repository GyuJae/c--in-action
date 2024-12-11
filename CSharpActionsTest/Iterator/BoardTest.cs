using CSharpActions.Iterator;
using JetBrains.Annotations;

namespace CSharpActionsTest.Iterator;

[TestSubject(typeof(Board))]
public class BoardTest
{
    [Fact(DisplayName = "(Iterator) Board를 통해서 생성순으로 Posts를 조회할 수 있습니다.")]
    public void Board_Test()
    {
        var board = new Board();
        board.AddPost("두번째 생성된 글", DateTime.Now);
        board.AddPost("세번째 생성된 글", DateTime.Now.AddDays(1));
        board.AddPost("첫번쨰 생성된 글", DateTime.Now.AddDays(-1));

        var posts = board.GetRecentPostIterator();

        var titles = new List<string>();

        while (posts.MoveNext()) titles.Add(posts.Current.Title);

        Assert.Equal(3, titles.Count);
        Assert.Equal("첫번쨰 생성된 글", titles[2]);
        Assert.Equal("두번째 생성된 글", titles[1]);
        Assert.Equal("세번째 생성된 글", titles[0]);
    }
}