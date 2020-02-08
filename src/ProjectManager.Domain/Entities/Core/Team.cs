using ProjectManager.Domain.Entities.Shared;
using System.Collections.Generic;

namespace ProjectManager.Domain.Entities.Core
{
    public class Team : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public ICollection<TeamAccount> TeamUsers { get; set; }
    }
}