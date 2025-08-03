using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
namespace Domain.Entities
{
    public class Profile
    {
    
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public Gender Gender { get; set; }

        public DateOnly BirthDate { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string Bio { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string ProfileName { get; private set; }

        public void SetProfileName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 50)
                throw new ArgumentException("Profile name must be 1-50 characters");
            ProfileName = name;
        }



    }
}
