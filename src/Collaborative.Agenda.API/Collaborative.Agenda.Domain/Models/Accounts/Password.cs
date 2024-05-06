namespace Collaborative.Agenda.Domain.Models.Accounts
{
    public class Password : IEquatable<Password>
    {
        private readonly string _value;

        // Private constructor to ensure immutability
        private Password(string value)
        {
            _value = value;
        }

        // Factory method to create an instance of Password
        public static Password Create(string value)
        {
            // Here you can add additional validations, such as checking password strength
            return new Password(value);
        }

        // Implicit conversion operator from string to Password
        public static implicit operator Password(string value)
        {
            return Create(value);
        }

        // Implicit conversion operator from Password to string
        public static implicit operator string(Password password)
        {
            return password._value;
        }

        // Implementation of Equals method for comparing Passwords
        public bool Equals(Password other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                return Equals(obj as Password);
            }
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}