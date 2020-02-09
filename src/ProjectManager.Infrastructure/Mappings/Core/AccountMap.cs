using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManager.Domain.Entities.Core;

namespace ProjectManager.Infrastructure.Mappings.Core
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Phone)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(x => x.Password)
                .IsRequired();

            builder.Property(x => x.Image)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.HasOne(a => a.Company)
                   .WithMany(c => c.Users)
                   .HasForeignKey(a => a.CompanyId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}