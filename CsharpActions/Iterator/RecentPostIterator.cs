using System.Collections;

namespace CSharpActions.Iterator;

public class RecentPostIterator(List<Post> posts) : IEnumerator<Post>
{
    private readonly List<Post> _posts = posts.OrderByDescending(p => p.CreateDateTime).ToList();
    private int _current = -1;

    public Post Current => _posts[_current];

    public bool MoveNext()
    {
        _current++;
        return _current < _posts.Count;
    }

    public void Reset()
    {
        _current = -1;
    }

    Post IEnumerator<Post>.Current => _posts[_current];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}