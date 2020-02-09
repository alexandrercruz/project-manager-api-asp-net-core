using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Entities.Manager;

namespace ProjectManager.Infrastructure.Mappings.Manager
{
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.Property(x => x.Title)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.HasOne(c => c.Next)
                   .WithOne()
                   .HasForeignKey<Card>(n => n.NextId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Feature)
                   .WithMany(f => f.Features)
                   .HasForeignKey(c => c.FeatureId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Creator)
                   .WithMany(u => u.CardCreators)
                   .HasForeignKey(c => c.CreatorId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Responsible)
                   .WithMany(a => a.CardResponsible)
                   .HasForeignKey(c => c.ResponsibleId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Label)
                   .WithMany(l => l.Cards)
                   .HasForeignKey(c => c.LabelId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Listy)
                   .WithMany(l => l.Cards)
                   .HasForeignKey(c => c.ListyId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Status)
                   .WithMany(s => s.Cards)
                   .HasForeignKey(c => c.StatusId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Sprint)
                   .WithMany(s => s.Cards)
                   .HasForeignKey(c => c.SprintId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}