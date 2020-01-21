using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEFCore.Configurations
{
    public class GenreConfiguration
    {
        public GenreConfiguration(EntityTypeBuilder<Genre> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(120);
        }
    }
}