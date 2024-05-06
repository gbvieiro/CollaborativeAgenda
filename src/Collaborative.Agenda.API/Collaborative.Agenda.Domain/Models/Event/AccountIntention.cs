using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Event
{
    public class AccountIntention(
        Guid id,
        bool confirmed,
        Guid eventId,
        Guid account
    ) : Entity(id)
    {
        public bool HasConfirmed { get; private set; } = confirmed;
        public Guid EventId { get; private set; } = eventId;
        public Guid Account { get; private set; } = account;
    }
}
