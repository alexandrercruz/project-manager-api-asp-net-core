using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Entities.Manager;
using System;

namespace ProjectManager.Domain.Entities.Shared
{
    public class BoardAccount : Entity
    {
        public Guid BoardId { get; set; }

        public Board Board { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}