using Collaborative.Agenda.Domain.Models.Commons;
using System.Drawing;

namespace Collaborative.Agenda.Domain.Models.Gamification
{
    public class AccountAction(
        Guid id,
        ActionType type,
        string description,
        long points,
        Guid accountId,
        DateTime date
    ) : Entity(id)
    {
        public ActionType Type { get; private set; } = type;
        public string Description { get; private set; } = description ?? throw new ArgumentNullException(nameof(description));
        public long Points { get; private set; } = points;
        public Guid AccountId { get; private set; } = accountId;
        public DateTime Date { get; private set; } = date;
    }
}
