using CSharpActions.Prototype;
using JetBrains.Annotations;

namespace CSharpActionsTest.Prototype;

[TestSubject(typeof(GithubIssue))]
public class GithubIssueTest
{

    [Fact(DisplayName = "(Prototype) Github Issue 복제할 수 있습니다.")]
    public void GithubIssue_Clone_Test()
    {
        var repository = new GithubRepository
        {
            User = "Gyujae",
            Name = "live-studay"
        };

        var githubIssue = new GithubIssue(repository)
        {
            Id = 1,
            Title = "1주차 과제"
        };

        var cloneIssue = (GithubIssue)githubIssue.Clone();
        cloneIssue.Id = 2;
        cloneIssue.Title = "2주차 과제";
        
        Assert.IsType<GithubIssue>(cloneIssue);
        Assert.NotEqual(cloneIssue, githubIssue);
        Assert.Equal(2, cloneIssue.Id);
        Assert.Equal("2주차 과제", cloneIssue.Title);
    }
}