using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Localizations
{
    public class City(Guid id, string name, State state) : Entity(id)
    {
        public string Name { get; set; } = name;
        public State State { get; set; } = state;
    }
}
