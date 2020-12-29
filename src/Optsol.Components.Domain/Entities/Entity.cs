using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Optsol.Components.Domain.Entities
{
    public class Entity<TKey> : Notifiable, IEntity<TKey>
    {
        public TKey Id { get; protected set; }

        public DateTime CreatedDate { get; protected set; }

        public virtual void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerThan(CreatedDate, DateTime.Now, "CreationDate", "A Data de criação não pode ser maior que a data atual"));
        }
    }
}
