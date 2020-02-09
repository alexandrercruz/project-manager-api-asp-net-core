using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Shared;

namespace ProjectManager.Infrastructure.Mappings.Shared
{
    public class TemplateListyMap : IEntityTypeConfiguration<TemplateListy>
    {
        public void Configure(EntityTypeBuilder<TemplateListy> builder)
        {
            builder.HasKey(tl => new { tl.Id, tl.TemplateId, tl.ListyId });

            builder.HasOne(tl => tl.Template)
                   .WithMany(t => t.Listys);

            builder.HasOne(tl => tl.Listy)
                   .WithMany(l => l.Templates)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}