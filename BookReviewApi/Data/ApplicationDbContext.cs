using BookReviewApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviewApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasIndex(x => x.Name);
        modelBuilder.Entity<Book>().HasIndex(x => x.ISBN);
        modelBuilder.Entity<Book>().HasIndex(x => x.Author);
        
        modelBuilder.Entity<User>().HasIndex(x => x.Email);
    }
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }
}