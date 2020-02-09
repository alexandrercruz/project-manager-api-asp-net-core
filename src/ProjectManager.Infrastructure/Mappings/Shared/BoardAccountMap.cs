using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Shared;

namespace ProjectManager.Infrastructure.Mappings.Shared
{
    public class BoardAccountMap : IEntityTypeConfiguration<BoardAccount>
    {
        public void Configure(EntityTypeBuilder<BoardAccount> builder)
        {
            builder.HasKey(ba => new { ba.Id, ba.BoardId, ba.AccountId });

            builder.HasOne(ba => ba.Board)
                   .WithMany(b => b.BoardUsers);

            builder.HasOne(ba => ba.Account)
                   .WithMany(a => a.BoardUsers)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}