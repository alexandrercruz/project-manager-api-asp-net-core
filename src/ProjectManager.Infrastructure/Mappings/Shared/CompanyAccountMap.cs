using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Shared;

namespace ProjectManager.Infrastructure.Mappings.Shared
{
    public class CompanyAccountMap : IEntityTypeConfiguration<CompanyAccount>
    {
        public void Configure(EntityTypeBuilder<CompanyAccount> builder)
        {
            builder.HasKey(ca => new { ca.Id, ca.CompanyId, ca.AccountId });

            builder.HasOne(ca => ca.Company)
                   .WithMany(c => c.CompanyViewers);

            builder.HasOne(ca => ca.Account)
                   .WithMany(a => a.CompanyViewers)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}