using Contact.Core.Interface;
using Contact.Domain.Model;
using Contact.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Core.Repository
{
    public class PhoneNumberRepository : IPhoneNumber
    {
        private readonly ContactDbContext _contactDbContext;

        public PhoneNumberRepository(ContactDbContext contactDbContext)
        {
            _contactDbContext = contactDbContext;
        }
        public IEnumerable<PhoneNumber> GetAllPhoneNumbers => _contactDbContext.PhoneNumbers.Include(s => s.MobileNumber).OrderBy(x => x.PhoneNumberId).ToList();


        public PhoneNumber GetPhoneNumberById(int id) => _contactDbContext.PhoneNumbers.FirstOrDefault(p => p.PhoneNumberId == id) ?? new PhoneNumber();



    }
}
