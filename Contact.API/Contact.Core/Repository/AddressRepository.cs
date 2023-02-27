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
    public class AddressRepository : IAddress
    {
        private readonly ContactDbContext _contactDbContext;

        public AddressRepository(ContactDbContext contactDbContext)
        {
            _contactDbContext = contactDbContext;
        }
      

        public Address GetAddressByUserContactId(int id) => _contactDbContext.Addresses.Include(z => z.UserContact).FirstOrDefault(p => p.AddressId == id);

    }
}
