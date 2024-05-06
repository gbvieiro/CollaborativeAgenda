using Collaborative.Agenda.Domain.Models.Commons;
using Collaborative.Agenda.Domain.Models.Gamification;

namespace Collaborative.Agenda.Domain.Models.Accounts
{
    public class Account(
        Guid id,
        StoredImage photo,
        string email,
        bool isAdminstrator,
        Password password,
        AccountGamificationInformation gamificationInformation,
        Person person,
        Level level
    ) : Entity(id)
    {
        public StoredImage Photo { get; set; } = photo;
        public string Email { get; set; } = email;
        public bool IsAdminstrator { get; set; } = isAdminstrator;
        public Password Password { get; set; } = password;
        public AccountGamificationInformation GamificationInformation { get; set; } = gamificationInformation;
        public Person Person { get; set; } = person;
        public Level Level { get; set; } = level;
    }
}