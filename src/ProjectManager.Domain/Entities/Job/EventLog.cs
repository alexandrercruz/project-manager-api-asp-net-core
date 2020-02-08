using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Enums;
using System;

namespace ProjectManager.Domain.Entities.Job
{
    public class EventLog : Entity
    {
        public string Origin { get; set; }

        public string JsonObject { get; set; }

        public EventTypeEnum EventType { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}