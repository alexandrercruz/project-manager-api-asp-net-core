using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Checklist : Entity
    {
        public string Title { get; set; }

        public DateTime? DoneDate { get; set; }

        public string Icon { get; set; }

        public Guid CardId { get; set; }

        public Card Card { get; set; }

        public ICollection<ChecklistItem> ChecklistItems { get; set; }
    }
}