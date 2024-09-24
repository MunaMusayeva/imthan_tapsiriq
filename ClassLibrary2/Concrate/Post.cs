
using Models.Abstract;

namespace ClassLibrary2.Concrate;

public class Post:Base
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string? Comment { get; set; }
    public int LikeCount { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Comment> Comments { get; set; }


}
