using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Model
{
    public class Email
    {
        public int EmailId { get; set; }

        
        public string EmailAddress { get; set; } = string.Empty;

        public int UserContactId { get; set; }

        public UserContact? UserContact { get; set; }
    }
}
