using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Event
{
    public class Comentary(
        Guid id,
        string text,
        DateTime date,
        Guid eventId,
        Guid accountId
    ) : Entity(id)
    {
        public string Text { get; private set; } = text;
        public DateTime Date { get; private set; } = date;
        public Guid EventId { get; private set; } = eventId;
        public Guid AccountId { get; private set; } = accountId;
    }
}