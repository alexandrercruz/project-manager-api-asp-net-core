using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Shared
{
    public class CompanyAccount : Entity
    {
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}