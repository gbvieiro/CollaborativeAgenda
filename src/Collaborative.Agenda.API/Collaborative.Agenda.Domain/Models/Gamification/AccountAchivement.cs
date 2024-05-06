using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Gamification
{
    public class AccountAchivement(Guid id, Achievement achivement, Guid accountId) : Entity(id)
    {
        public Achievement Achivement { get; private set; } = achivement;
        public Guid AccountId { get; private set; } = accountId;
    }
}