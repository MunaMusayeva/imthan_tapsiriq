using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;
using SosialMedia.DAL.Repositories.Concrate;

namespace SosialMedia.DAL.Repositories.Abstract;

public class UnitOfWork : IUnitOfWork
{
    private readonly SosialMediaDb _context;
    public IRepository<User> Users { get; set; }
    public IRepository<Comment> Comments { get; set; }
    public IRepository<Post> Posts { get; set; }
    public IRepository<UserDetails> UserDetails { get; set; }

    public UnitOfWork(SosialMediaDb context)
    {
        _context = context;
        Posts = new BaseRepository<Post>(_context);
        Comments = new BaseRepository<Comment>(_context);
        Users = new BaseRepository<User>(_context);
        UserDetails = new BaseRepository<UserDetails>(_context);

    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

