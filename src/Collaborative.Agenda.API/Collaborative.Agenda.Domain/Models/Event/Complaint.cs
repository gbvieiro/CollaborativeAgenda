using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Event
{
    public class Complaint(
        Guid id,
        string description,
        bool solved,
        Guid eventId,
        Guid accountId
    ) : Entity(id)
    {
        public string Description { get; set; } = description;
        public bool Solved { get; set; } = solved;
        public Guid EventId { get; set; } = eventId;
        public Guid AccountId { get; set; } = accountId;
    }
}
