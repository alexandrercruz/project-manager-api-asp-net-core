using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Release : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid ProjectId { get; set; }

        public Project Project { get; set; }

        public ICollection<Sprint> Sprints { get; set; }
    }
}