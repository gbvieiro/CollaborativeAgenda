using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Accounts
{
    public class AccountGamificationInformation(
        long points,
        int level
    ) : ValueObject<AccountGamificationInformation>
    {
        public long Points { get; private set; } = points;
        public int Level { get; private set; } = level;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return new object[] { Points, Level };
        }
    }
}