using Collaborative.Agenda.Domain.Models.Commons;

namespace Collaborative.Agenda.Domain
{
    public class Address(
        string street,
        int number,
        string complement,
        string district,
        string city,
        string state,
        string zipCode,
        string country,
        string latitude,
        string longitude,
        string latitudeCenter,
        string longitudeCenter,
        int zoom
    ) : ValueObject<Address>
    {
        public string Street { get; set; } = street;

        public int Number { get; set; } = number;

        public string Complement { get; set; } = complement;

        public string District { get; set; } = district;

        public string City { get; set; } = city;

        public string State { get; set; } = state;

        public string ZipCode { get; set; } = zipCode;

        public string Country { get; set; } = country;

        public string Latitude { get; set; } = latitude;

        public string Longitude { get; set; } = longitude;

        public string LatitudeCenter { get; set; } = latitudeCenter;

        public string LongitudeCenter { get; set; } = longitudeCenter;

        public int Zoom { get; set; } = zoom;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return Number;
            yield return Complement;
            yield return District;
            yield return City;
            yield return State;
            yield return ZipCode;
            yield return Country;
        }
    }
}