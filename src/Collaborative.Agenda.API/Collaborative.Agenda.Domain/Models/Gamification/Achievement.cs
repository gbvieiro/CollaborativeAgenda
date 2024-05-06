using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain.Models.Gamification
{
    public class Achievement(
        Guid id,
        string description,
        StoredImage imagem,
        long numberOfActions,
        ActionType tipo
    ) : Entity(id)
    {
        public string Description { get; set; } = description ?? throw new ArgumentNullException(nameof(description));
        public StoredImage Imagem { get; set; } = imagem ?? throw new ArgumentNullException(nameof(imagem));
        public long NumberOfActions { get; set; } = numberOfActions;
        public ActionType Tipo { get; set; } = tipo;
    }
}
