using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Job
{
    public class ResetPassword : Entity
    {
        public string Token { get; set; }

        public bool IsValid { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}