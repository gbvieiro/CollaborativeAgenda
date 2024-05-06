using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Localizations
{
    public class State(Guid id, string name, string shortName, Country country, IList<City> cities) : Entity(id)
    {
        public string Name { get; set; } = name;
        public string ShortName { get; set; } = shortName;
        public Country Country { get; set; } = country;
        public IList<City> Cities { get; set; } = cities;
    }
}