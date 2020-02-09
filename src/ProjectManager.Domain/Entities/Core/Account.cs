using ProjectManager.Domain.Entities.Job;
using ProjectManager.Domain.Entities.Manager;
using ProjectManager.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Core
{
    public class Account : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public string Image { get; set; }

        public bool Blocked { get; set; }

        public bool Active { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<TeamAccount> TeamUsers { get; set; }

        public ICollection<BoardAccount> BoardUsers { get; set; }

        public ICollection<CardAccount> CardMembers { get; set; }

        public ICollection<CompanyAccount> CompanyViewers { get; set; }

        public ICollection<Notification> Notifications { get; set; }

        public ICollection<Template> Templates { get; set; }

        public ICollection<Card> CardCreators { get; set; }

        public ICollection<Card> CardResponsible { get; set; }

        public ICollection<VerifiedAccount> VerifiedAccounts { get; set; }

        public ICollection<EventLog> EventLogs { get; set; }

        public ICollection<ResetPassword> ResetPasswords { get; set; }
    }
}