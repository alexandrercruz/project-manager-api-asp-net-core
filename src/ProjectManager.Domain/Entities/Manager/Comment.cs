using ProjectManager.Domain.Entities.Core;
using System;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Comment : Entity
    {
        public string Content { get; set; }

        public Guid CardId { get; set; }

        public Card Card { get; set; }

        public Guid UserId { get; set; }

        public Account User { get; set; }
    }
}