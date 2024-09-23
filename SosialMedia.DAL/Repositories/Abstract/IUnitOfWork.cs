using ClassLibrary2.Concrate;

namespace SosialMedia.DAL.Repositories.Abstract;

public interface IUnitOfWork : IDisposable
{
    IRepository<Post> Posts { get; }
    IRepository<Comment> Comments { get; }
    IRepository<User> Users { get; }
    IRepository<UserDetails> UserDetails { get; }
    int Complete();

}
