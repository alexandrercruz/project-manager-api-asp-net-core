using ProjectManager.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Listy : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? NextId { get; set; }

        public Listy Next { get; set; }

        public ICollection<Card> Cards { get; set; }

        public ICollection<TemplateListy> Templates { get; set; }
    }
}