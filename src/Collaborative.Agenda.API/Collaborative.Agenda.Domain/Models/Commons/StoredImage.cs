namespace Collaborative.Agenda.Domain.Models.Commons
{
    public class StoredImage(Guid id, string url) : Entity(id)
    {
        public string Url { get; set; } = url ?? throw new ArgumentNullException(nameof(url));
    }
}