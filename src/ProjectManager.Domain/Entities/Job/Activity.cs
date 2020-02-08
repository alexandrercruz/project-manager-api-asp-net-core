using ProjectManager.Domain.Entities.Manager;
using ProjectManager.Domain.Enums;
using System;

namespace ProjectManager.Domain.Entities.Job
{
    public class Activity : Entity
    {
        public string PropertyName { get; set; }

        public ActivityTypeEnum ActivityType { get; set; }

        public Guid ProjectId { get; set; }

        public Project Project { get; set; }

        public Guid BoardId { get; set; }

        public Board Board { get; set; }

        public Guid ListyId { get; set; }

        public Listy Listy { get; set; }

        public Guid CardId { get; set; }

        public Card Card { get; set; }
    }
}