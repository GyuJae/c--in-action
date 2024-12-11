namespace CSharpActions.Iterator;

public class Board
{
    private List<Post> Posts { get; } = [];

    public void AddPost(string title, DateTime createDateTime)
    {
        Posts.Add(new Post(title, createDateTime));
    }

    public List<Post> GetPosts()
    {
        return Posts;
    }

    public IEnumerator<Post> GetRecentPostIterator()
    {
        return new RecentPostIterator(Posts);
    }
}