using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEFCore.Configurations
{
    public class MediaTypeConfiguration
    {
        public MediaTypeConfiguration(EntityTypeBuilder<MediaType> entity)
        {
            entity.Property(e => e.Name).HasMaxLength(120);
        }
    }
}