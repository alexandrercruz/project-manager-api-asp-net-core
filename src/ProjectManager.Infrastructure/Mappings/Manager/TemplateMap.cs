using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Manager;

namespace ProjectManager.Infrastructure.Mappings.Manager
{
    public class TemplateMap : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.HasOne(t => t.Creator)
                   .WithMany(a => a.Templates)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}