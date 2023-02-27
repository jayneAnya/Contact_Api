using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Model
{
    public class UserContact
    {
        public int UserContactId { get; set; }

        
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public ICollection<Email>? Email { get; set; } 
        public ICollection<PhoneNumber>? PhoneNumbers { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }


    }
}
