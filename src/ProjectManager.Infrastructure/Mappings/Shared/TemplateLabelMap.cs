using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Shared;

namespace ProjectManager.Infrastructure.Mappings.Shared
{
    public class TemplateLabelMap : IEntityTypeConfiguration<TemplateLabel>
    {
        public void Configure(EntityTypeBuilder<TemplateLabel> builder)
        {
            builder.HasKey(tl => new { tl.Id, tl.TemplateId, tl.LabelId });

            builder.HasOne(tl => tl.Template)
                   .WithMany(t => t.Labels);

            builder.HasOne(tl => tl.Label)
                   .WithMany(l => l.Templates)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}