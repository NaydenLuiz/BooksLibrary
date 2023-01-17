using BooksLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace BooksLibraryAPI.Persistences;

    public class DataContext : DbContext
    {


    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Books>().ToTable("books", schema: "dbo");
      
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Books> Books { get; set; }
   

    }