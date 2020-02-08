using ProjectManager.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Board : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }

        public Guid ProjectId { get; set; }

        public Project Project { get; set; }

        public Guid TemplateId { get; set; }

        public Template Template { get; set; }

        public ICollection<Listy> Listys { get; set; }

        public ICollection<Label> Labels { get; set; }

        public ICollection<BoardAccount> BoardUsers { get; set; }
    }
}