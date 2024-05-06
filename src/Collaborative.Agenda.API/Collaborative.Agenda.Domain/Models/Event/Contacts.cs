using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Event
{
    public class Contacts(
        IEnumerable<string> phones,
        IEnumerable<string> email,
        IEnumerable<Link> links
    ) : ValueObject<Contacts>
    {
        public IEnumerable<string> Phones { get; private set; } = phones;
        public IEnumerable<string> Email { get; private set; } = email;
        public IEnumerable<Link> Links { get; private set; } = links;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Phones;
            yield return Email;
            yield return Links;
        }
    }
}