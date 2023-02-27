using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Model
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string NetworkProvider { get; set; } = string.Empty;

        [Required]
        public string MobileNumber { get; set; } = string.Empty;

        public UserContact? UserContact { get; set; }
    }
}
