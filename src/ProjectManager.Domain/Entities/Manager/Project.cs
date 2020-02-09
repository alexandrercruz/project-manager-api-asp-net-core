using ProjectManager.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Project : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? ExpectedDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Image { get; set; }

        public Guid? TeamId { get; set; }

        public Team Team { get; set; }

        public Guid? CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Guid CreatorId { get; set; }

        public Account Creator { get; set; }

        public ICollection<Board> Boards { get; set; }

        public ICollection<Release> Releases { get; set; }
    }
}