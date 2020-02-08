using ProjectManager.Domain.Entities.Manager;
using System;

namespace ProjectManager.Domain.Entities.Shared
{
    public class TemplateLabel : Entity
    {
        public Guid TemplateId { get; set; }

        public Template Template { get; set; }

        public Guid LabelId { get; set; }

        public Label Label { get; set; }
    }
}