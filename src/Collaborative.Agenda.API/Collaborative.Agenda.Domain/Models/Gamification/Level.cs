using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Gamification
{
    public class Level(Guid id, int number, string name, long requiredPoints) : Entity(id)
    {
        public int Number { get; set; } = number;
        public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));
        public long RequiredPoints { get; set; } = requiredPoints;
    }
}
