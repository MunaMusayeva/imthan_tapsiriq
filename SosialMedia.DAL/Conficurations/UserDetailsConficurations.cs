using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SosialMedia.DAL;

public class UserDetailsConficurations : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(15);
        builder.Property(x=> x.Surname).HasMaxLength(15);
        builder.HasOne<User>().WithOne(u=>u.UserDetails).HasForeignKey<User>(u=>u.UserDetailsId);
    }
    
        
}
