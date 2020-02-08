using ProjectManager.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Label : Entity
    {
        public string Title { get; set; }

        public string Color { get; set; }

        public string Icon { get; set; }

        public Guid BoardId { get; set; }

        public Board Board { get; set; }

        public ICollection<Card> Cards { get; set; }

        public ICollection<TemplateLabel> Templates { get; set; }
    }
}