using ProjectManager.Domain.Entities.Shared;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Core
{
    public class Company : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }

        public string Image { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public ICollection<Account> Users { get; set; }

        public ICollection<CompanyAccount> CompanyViewers { get; set; }
    }
}