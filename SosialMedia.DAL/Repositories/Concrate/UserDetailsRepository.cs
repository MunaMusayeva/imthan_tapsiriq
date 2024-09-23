using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;

namespace SosialMedia.DAL.Repositories.Concrate;

public class UserDetailsRepository : BaseRepository<UserDetails>
{
    public UserDetailsRepository(SosialMediaDb dbCONTEXT) : base(dbCONTEXT)
    {
    }
}

