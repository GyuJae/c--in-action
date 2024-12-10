namespace CSharpActions.Prototype;

public class GithubIssue(GithubRepository repository) : ICloneable
{
    public int Id { get; set; }
    public string Title { get; set; }
    public GithubRepository Repository { get; set; } = repository;

    public string GetUrl()
    {
        return $"https://github.com/{Repository.User}/{Repository.Name}/issues/{Id}";
    }

    public object Clone()
    {
        return new GithubIssue(Repository)
        {
            Id = this.Id,
            Title = this.Title
        };
    }
}