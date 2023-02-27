﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.DTO
{
    public class UserContactDTO
    {
        public int UserContactId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string? Email { get; set; }
        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
