
using Models.Abstract;

namespace ClassLibrary2.Concrate;

public class Comment:Base
{
    public string Text { get; set; }
    public int LikeCount { get; set; }
    public ICollection<Comment> comment_in_comments { get; set; }=new List<Comment>();
    public ICollection<Post> Posts { get; set; }
}
