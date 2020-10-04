using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<MovieEntity> Movies { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GenreEntity>(new GenreMap().Configure);
            modelBuilder.Entity<MovieEntity>(new MovieMap().Configure);
        }
    }
}
