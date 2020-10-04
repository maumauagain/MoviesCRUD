using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class MovieMap : IEntityTypeConfiguration<MovieEntity>
    {
        public void Configure(EntityTypeBuilder<MovieEntity> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(movie => movie.Id);
            builder.Property(movie => movie.Title)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(movie => movie.Director)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(movie => movie.Year)
                .HasMaxLength(4);
            builder.Property(movie => movie.Removed)
                .HasDefaultValue(false);
        }
    }
}
