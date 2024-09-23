using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SosialMedia.Conficurations;
using SosialMedia.DAL;

namespace SosialMedia.Context;


public  class SosialMediaDb:DbContext
{
    public DbSet<UserDetails> UserDetails {  get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        object value = optionsBuilder.UseSqlServer("Server=DESKTOP-JI95IOS;Database=hellososial;Trusted_Connection=True;Initial Catalog=hellososial;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConficurations());
        modelBuilder.ApplyConfiguration(new PostConficurations());
        modelBuilder.ApplyConfiguration(new UserDetailsConficurations());
        modelBuilder.ApplyConfiguration(new CommentConficurations());
        base.OnModelCreating(modelBuilder);
    }
}
