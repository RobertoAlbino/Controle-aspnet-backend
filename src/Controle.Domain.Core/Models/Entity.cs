﻿using System.ComponentModel.DataAnnotations;

namespace Controle.Domain.Core.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var compare = obj as Entity;
            if (ReferenceEquals(this, compare)) return true;
            if (ReferenceEquals(null, compare)) return false;

            return Id.Equals(compare.Id);
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
            return $"Entidade: {GetType().Name} - Id: {Id}";
        }
    }
}
