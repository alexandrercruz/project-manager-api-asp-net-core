using ProjectManager.Domain.Entities.Manager;
using System;

namespace ProjectManager.Domain.Entities.Shared
{
    public class TemplateListy : Entity
    {
        public Guid TemplateId { get; set; }

        public Template Template { get; set; }

        public Guid ListyId { get; set; }

        public Listy Listy { get; set; }
    }
}