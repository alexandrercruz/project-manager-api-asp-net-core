using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Template : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid CreatorId { get; set; }

        public Account Creator { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Board> Boards { get; set; }

        public ICollection<TemplateListy> Listys { get; set; }

        public ICollection<TemplateLabel> Labels { get; set; }
    }
}