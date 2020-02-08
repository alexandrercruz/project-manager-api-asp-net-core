using System;

namespace ProjectManager.Domain.Entities.Core
{
    public class Customer : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Image { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}