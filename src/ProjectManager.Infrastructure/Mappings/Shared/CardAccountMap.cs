using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Shared;

namespace ProjectManager.Infrastructure.Mappings.Shared
{
    public class CardAccountMap : IEntityTypeConfiguration<CardAccount>
    {
        public void Configure(EntityTypeBuilder<CardAccount> builder)
        {
            builder.HasKey(ca => new { ca.Id, ca.CardId, ca.AccountId });

            builder.HasOne(ca => ca.Card)
                   .WithMany(c => c.CardMembers);

            builder.HasOne(ca => ca.Account)
                   .WithMany(a => a.CardMembers)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}