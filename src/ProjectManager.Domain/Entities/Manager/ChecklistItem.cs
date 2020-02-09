using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Manager
{
    public class ChecklistItem : Entity
    {
        public string Title { get; set; }

        public bool Done { get; set; }

        public int Index { get; set; }

        public Guid ChecklistId { get; set; }

        public Checklist Checklist { get; set; }

        public Guid? DoneById { get; set; }

        public Account DoneBy { get; set; }
    }
}