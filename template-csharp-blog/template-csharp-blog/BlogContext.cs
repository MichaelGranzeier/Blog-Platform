using Microsoft.EntityFrameworkCore;
using template_csharp_blog.Models;

namespace template_csharp_blog
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Video Games"},
                new Category() { Id = 2, Name = "Consoles" },
                new Category() { Id = 3, Name = "Game Store" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post() { Id = 1, Title = "Breath of the Wild", Author = "Michael", CategoryId = 1, PublishDate = DateTime.Now, Body = "It's an amazing game"},
                new Post() { Id = 2, Title = "Xbox Series X", Author = "Michael", CategoryId = 2, PublishDate = DateTime.Now, Body = "it's the fastest console ever"},
                new Post() { Id = 3, Title = "GOG", Author = "Michael", CategoryId = 3, PublishDate = DateTime.Now, Body = "Great place for old games"}
                );
        }
    }
}
