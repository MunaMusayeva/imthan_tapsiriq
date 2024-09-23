using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;

namespace SosialMedia.DAL.Repositories.Concrate;

public class PostRepository : BaseRepository<Post>
{
    public PostRepository(SosialMediaDb dbCONTEXT) : base(dbCONTEXT)
    {
    }
}
