using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Accounts
{
    public class Person(
        Guid id,
        string name,
        string document,
        DateTime dateOfBirth
    ) : Entity(id)
    {
        public string Name { get; set; } = name;
        public string Document { get; set; } = document;
        public DateTime DateOfBirth { get; set; } = dateOfBirth;
    }
}