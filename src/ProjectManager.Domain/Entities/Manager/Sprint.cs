using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Sprint : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Guid ReleaseId { get; set; }

        public Release Release { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}