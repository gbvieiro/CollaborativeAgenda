using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Accounts
{
    public class Friendship(
        Guid id,
        bool accepted,
        DateTime date,
        Account requestAccount,
        Account friedAccount
    ) : Entity(id)
    {
        public bool Accepted { get; private set; } = accepted;
        public DateTime Date { get; private set; } = date;
        public Account RequestAccount { get; private set; } = requestAccount;
        public Account FriedAccount { get; private set; } = friedAccount;
    }
}