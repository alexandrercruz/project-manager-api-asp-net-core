using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Shared
{
    public class TeamAccount : Entity
    {
        public Guid TeamId { get; set; }

        public Team Team { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}