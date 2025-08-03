using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    using System;

    namespace DatingApp.Domain.ValueObjects
    {
        public sealed class ProfileName
        {
            public string Value { get; }

            private ProfileName(string value)
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 50)
                    throw new ArgumentException("Profile name must be between 1 and 50 characters.");

                if (ContainsProhibitedWords(value))
                    throw new ArgumentException("Profile name contains prohibited words.");

                Value = value;
            }

            public static ProfileName From(string value) => new ProfileName(value);

            private static bool ContainsProhibitedWords(string value)
            {
                var blacklist = new[] { "admin", "fuck", "nazi", "shit" }; // Tilpas senere
                return blacklist.Any(b => value.ToLower().Contains(b));
            }

            public override string ToString() => Value;

            public override bool Equals(object obj)
            {
                if (obj is ProfileName other)
                    return Value == other.Value;
                return false;
            }

            public override int GetHashCode() => Value.GetHashCode();
        }
    }

}
