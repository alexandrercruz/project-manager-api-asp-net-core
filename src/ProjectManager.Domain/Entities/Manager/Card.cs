using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Entities.Shared;
using System;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Card : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? DoneDate { get; set; }

        public bool Filed { get; set; }

        public Guid? NextId { get; set; }

        public Card Next { get; set; }

        public Guid? FeatureId { get; set; }

        public Card Feature { get; set; }

        public Guid? ListyId { get; set; }

        public Listy Listy { get; set; }

        public Guid? LabelId { get; set; }

        public Label Label { get; set; }

        public Guid? StatusId { get; set; }

        public Status Status { get; set; }

        public Guid? SprintId { get; set; }

        public Sprint Sprint { get; set; }

        public Guid? CreatorId { get; set; }

        public Account Creator { get; set; }

        public Guid? ResponsibleId { get; set; }

        public Account Responsible { get; set; }

        public ICollection<CardAccount> CardMembers { get; set; }

        public ICollection<Checklist> Checklists { get; set; }

        public ICollection<Attachment> Attachments { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Card> Features { get; set; }
    }
}