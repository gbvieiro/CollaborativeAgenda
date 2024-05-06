using Collaborative.Agenda.Domain.Models.Accounts;
using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Event
{
    public class Event(
        Guid id,
        string name,
        DateTime initialDate,
        DateTime finalDate,
        string description,
        StoredImage image,
        Contacts contacts,
        Address address,
        Account owner,
        IEnumerable<string> tags
        ) : Entity(id)
    {
        public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));
        public DateTime InitialDate { get; set; } = initialDate;
        public DateTime FinalDate { get; set; } = finalDate;
        public string Description { get; set; } = description ?? throw new ArgumentNullException(nameof(description));
        public StoredImage Image { get; set; } = image ?? throw new ArgumentNullException(nameof(image));
        public Contacts Contacts { get; set; } = contacts ?? throw new ArgumentNullException(nameof(contacts));
        public Address Address { get; set; } = address ?? throw new ArgumentNullException(nameof(address));
        public Account Owner { get; set; } = owner ?? throw new ArgumentNullException(nameof(owner));
        public IEnumerable<string> Tags { get; set; } = tags ?? throw new ArgumentNullException(nameof(tags));
    }
}