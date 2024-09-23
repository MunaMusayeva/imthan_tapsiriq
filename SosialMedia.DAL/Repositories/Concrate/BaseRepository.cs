
using Microsoft.EntityFrameworkCore;
using Models.Abstract;
using SosialMedia.Context;
using SosialMedia.DAL.Repositories.Abstract;

namespace SosialMedia.DAL.Repositories.Concrate;

public class BaseRepository<T> : IRepository<T> where T : Base, new()
{
    private readonly SosialMediaDb _context;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(SosialMediaDb dbCONTEXT)
    {
        _context = dbCONTEXT;
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        entity.CreatedDate = DateTime.Now;
    }

    public void Delete(int Id)
    {
        var entity = _dbSet.FirstOrDefault(e => e.Id == Id);
        if (entity != null)
        {
            entity.IsDeleted = true;
            entity.DeletedDate = DateTime.Now;
        }
        else
            throw new NullReferenceException();
    }

    public ICollection<T> GetAll()
    {
        return _dbSet.Where(t => t.IsDeleted == false).ToList();
    }

    public T GetById(int Id)
    {
        return _dbSet.FirstOrDefault(t => t.Id == Id && t.IsDeleted == false);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Update(int Id)
    {
        throw new Exception();
    }
}
