using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Localizations
{
    public class Country(Guid id, string name, IList<State> states) : Entity(id)
    {
        public string Name { get; set; } = name;
        public IList<State> States { get; set; } = states;
    }
}