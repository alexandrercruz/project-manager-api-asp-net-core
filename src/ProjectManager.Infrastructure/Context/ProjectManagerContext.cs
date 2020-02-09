using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using ProjectManager.Domain.Entities;
using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Entities.Job;
using ProjectManager.Domain.Entities.Manager;
using ProjectManager.Domain.Entities.Shared;
using ProjectManager.Infrastructure.Mappings.Core;
using ProjectManager.Infrastructure.Mappings.Manager;
using ProjectManager.Infrastructure.Mappings.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectManager.Infrastructure.Context
{
    public class ProjectManagerContext : DbContext
    {
        private readonly IHostEnvironment _env;

        public ProjectManagerContext(IHostEnvironment env)
        {
            _env = env;
        }

        #region Core

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Team> Teams { get; set; }

        #endregion Core

        #region Job

        public DbSet<Activity> Activities { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ResetPassword> ResetPasswords { get; set; }
        public DbSet<VerifiedAccount> VerifiedAccounts { get; set; }

        #endregion Job

        #region Manager

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<ChecklistItem> ChecklistItems { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Listy> Listies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Template> Templates { get; set; }

        #endregion Manager

        #region Shared

        public DbSet<BoardAccount> BoardsAccounts { get; set; }
        public DbSet<CardAccount> CardsAccounts { get; set; }
        public DbSet<CompanyAccount> CompaniesAccounts { get; set; }
        public DbSet<TeamAccount> TeamsAccounts { get; set; }
        public DbSet<TemplateLabel> TemplatesLabels { get; set; }
        public DbSet<TemplateListy> TemplatesListies { get; set; }

        #endregion Shared

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Core

            modelBuilder.ApplyConfiguration(new AccountMap());

            #endregion Core

            #region Job

            //map

            #endregion Job

            #region Manager

            modelBuilder.ApplyConfiguration(new CardMap());
            modelBuilder.ApplyConfiguration(new TemplateMap());

            #endregion Manager

            #region Shared

            modelBuilder.ApplyConfiguration(new BoardAccountMap());
            modelBuilder.ApplyConfiguration(new CardAccountMap());
            modelBuilder.ApplyConfiguration(new CompanyAccountMap());
            modelBuilder.ApplyConfiguration(new TeamAccountMap());
            modelBuilder.ApplyConfiguration(new TemplateLabelMap());
            modelBuilder.ApplyConfiguration(new TemplateListyMap());

            #endregion Shared

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        public override int SaveChanges()
        {
            UpdateSoftDeleteStatuses();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            UpdateSoftDeleteStatuses();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void UpdateSoftDeleteStatuses()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        //TODO: Validar se a entidade é do tipo Entity
                        entry.CurrentValues[nameof(Entity.CreatedBy)] = "TODO";
                        entry.CurrentValues["CreatedAt"] = DateTime.Now;
                        entry.CurrentValues["UpdatedBy"] = null;
                        entry.CurrentValues["UpdatedAt"] = null;
                        entry.CurrentValues["DeletedBy"] = null;
                        entry.CurrentValues["DeletedAt"] = null;
                        break;

                    case EntityState.Modified:
                        //TODO: Validar se a entidade é do tipo Entity
                        entry.CurrentValues["UpdatedBy"] = "TODO";
                        entry.CurrentValues["UpdatedAt"] = DateTime.Now;
                        break;

                    case EntityState.Deleted:
                        //TODO: Validar se a entidade é do tipo Entity
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["DeletedBy"] = "TODO";
                        entry.CurrentValues["DeletedAt"] = DateTime.Now;
                        break;
                }
            }
        }
    }
}