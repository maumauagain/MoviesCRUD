using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class GenreMap : IEntityTypeConfiguration<GenreEntity>
    {
        public void Configure(EntityTypeBuilder<GenreEntity> builder)
        {
            builder.ToTable("Genre");
            builder.HasKey(genre => genre.Id);
            builder.HasIndex(genre => genre.Name)
                .IsUnique();
        }
    }
}
