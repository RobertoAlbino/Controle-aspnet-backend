using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Results;

namespace Controle.Domain.Core.Models
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        [Key]
        public int Id { get; protected set; }
        public FluentValidation.Results.ValidationResult ValidationResult { get; protected set; }

        public Entity()
        {
            ValidationResult = new FluentValidation.Results.ValidationResult();
        }

        public override bool Equals(object obj)
        {
            var compare = obj as Entity<T>;
            if (ReferenceEquals(this, compare)) return true;
            if (ReferenceEquals(null, compare)) return false;

            return Id.Equals(compare.Id);
        }

        public static bool operator ==(Entity<T> a, Entity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity<T> a, Entity<T> b)
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

        public virtual bool ValidarEntidade()
        {
            return ValidationResult.IsValid;
        }
    }
}
