
namespace Collaborative.Agenda.Domain.Models.Commons
{
    public class Link(string url, URLType type) : ValueObject<Link>
    {
        public string URL { get; private set; } = url;
        public URLType Type { get; private set; } = type;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return URL;
            yield return Type;
        }
    }
}