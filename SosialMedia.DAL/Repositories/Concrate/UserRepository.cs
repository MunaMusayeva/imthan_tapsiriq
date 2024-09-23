using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;

namespace SosialMedia.DAL.Repositories.Concrate;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(SosialMediaDb dbCONTEXT) : base(dbCONTEXT)
    {
    }
}

