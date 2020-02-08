using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Job
{
    public class VerifiedAccount : Entity
    {
        public string Token { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsVerified { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}