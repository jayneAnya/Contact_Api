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
    public interface UserContactRepository : IUserContact
    {
        private readonly ContactDbContext _contactDbContext;

        public UserContactRepository(ContactDbContext contactDbContext)
        {
            _contactDbContext = contactDbContext;
        }
        public IEnumerable<UserContact> GetAllUsersContact => _contactDbContext.UserContacts.Include(s => s.Address).OrderBy(x => x.UserContactId);

    }
}
