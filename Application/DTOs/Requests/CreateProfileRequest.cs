using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Requests
{
    public class CreateProfileRequest
    {
        public Guid UserId { get; set; } // eller int hvis du bruger int ID
        public string ProfileName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Bio { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Gender { get; set; } // Enum som int (kan parses til enum i domain)
    }
}

