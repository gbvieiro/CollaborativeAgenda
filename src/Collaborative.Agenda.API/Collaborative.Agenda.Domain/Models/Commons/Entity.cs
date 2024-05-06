namespace Collaborative.Agenda.Domain.Models.Commons
{
    public abstract class Entity(Guid id)
    {
        public Guid Id { get; set; } = id;

        public override bool Equals(object? obj)
        {
            return obj is Entity entity &&
                   Id.Equals(entity.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}