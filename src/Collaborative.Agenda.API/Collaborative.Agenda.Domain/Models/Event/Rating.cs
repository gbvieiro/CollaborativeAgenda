using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Event
{
    public class Rating(Guid id, string commentary, int grade, Guid eventId, Guid accountId) : Entity(id)
    {
        public string Commentary { get; private set; } = commentary;
        public int grade { get; private set; } = grade;
        public Guid EventId { get; private set; } = eventId;
        public Guid AccountId { get; private set; } = accountId;
    }
}
