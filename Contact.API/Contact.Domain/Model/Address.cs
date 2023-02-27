using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Continent { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string StreetAddress { get; set; } = string.Empty;
        
    }
}
