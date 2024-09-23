using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;

namespace SosialMedia.DAL.Repositories.Concrate;

public class CommentRepository : BaseRepository<Comment>
{
    public CommentRepository(SosialMediaDb dbCONTEXT) : base(dbCONTEXT)
    {
    }
}
