using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Seeds
{
    public class GenreSeeds
    {
        public static void Genres(ModelBuilder builder)
        {
            builder.Entity<GenreEntity>().HasData(new GenreEntity[]
                {
                    new GenreEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = "Terror",
                        CreateAt = DateTime.UtcNow
                    },
                    new GenreEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = "Comédia",
                        CreateAt = DateTime.UtcNow
                    },
                    new GenreEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = "Romance",
                        CreateAt = DateTime.UtcNow
                    },
                    new GenreEntity
                    {
                        Id = Guid.NewGuid(),
                        Name = "Aventura",
                        CreateAt = DateTime.UtcNow
                    }
                }
            );
        }
    }
}
