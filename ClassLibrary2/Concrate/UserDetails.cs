
using Models.Abstract;

namespace ClassLibrary2.Concrate;

public class UserDetails:Base
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public Roles Role { get; set; }
    
}
