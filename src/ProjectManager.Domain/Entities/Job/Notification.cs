using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Job
{
    public class Notification : Entity
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public string Color { get; set; }

        public string Icon { get; set; }

        public bool Viewed { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}