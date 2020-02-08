using System;

namespace ProjectManager.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        public string CreatedBy { get; protected set; }

        public DateTime? CreatedAt { get; protected set; }

        public string UpdatedBy { get; protected set; }

        public DateTime? UpdatedAt { get; protected set; }

        public string DeletedBy { get; protected set; }

        public DateTime? DeletedAt { get; protected set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}