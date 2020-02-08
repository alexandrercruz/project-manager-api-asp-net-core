using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Manager
{
    public class Status : Entity
    {
        public string Title { get; set; }

        public string CardColor { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}