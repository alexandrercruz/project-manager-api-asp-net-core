using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Shared;

namespace ProjectManager.Infrastructure.Mappings.Shared
{
    public class TeamAccountMap : IEntityTypeConfiguration<TeamAccount>
    {
        public void Configure(EntityTypeBuilder<TeamAccount> builder)
        {
            builder.HasKey(ta => new { ta.Id, ta.TeamId, ta.AccountId });

            builder.HasOne(ta => ta.Team)
                   .WithMany(t => t.TeamUsers);

            builder.HasOne(ca => ca.Account)
                   .WithMany(a => a.TeamUsers)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}