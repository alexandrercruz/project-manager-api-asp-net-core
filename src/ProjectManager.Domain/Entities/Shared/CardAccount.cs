using ProjectManager.Domain.Entities.Core;
using ProjectManager.Domain.Entities.Manager;
using System;

namespace ProjectManager.Domain.Entities.Shared
{
    public class CardAccount : Entity
    {
        public Guid CardId { get; set; }

        public Card Card { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}