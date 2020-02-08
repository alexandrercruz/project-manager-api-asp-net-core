using System;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Attachment : Entity
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public Guid CardId { get; set; }

        public Card Card { get; set; }
    }
}