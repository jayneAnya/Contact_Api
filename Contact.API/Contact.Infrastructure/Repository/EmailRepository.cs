using Contact.Core.Interface;
using Contact.Domain.Model;
using Contact.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Core.Repository
{
    public class EmailRepository : IEmail
    {
        private readonly ContactDbContext _contactDbContext;

        public EmailRepository(ContactDbContext contactDbContext)
        {
            _contactDbContext= contactDbContext;
        }
        public IEnumerable<Email> GetAllEmails => _contactDbContext.Emails.Include(s =>s.EmailAddress).OrderBy(x => x.EmailId);


        public Email GetEmailById(int id) => _contactDbContext.Emails.FirstOrDefault(p => p.EmailId == id) ?? new Email();

        //public Email AddEmailAndUpdateUserContact(Email email)
        //{
        //    _contactDbContext.UserContacts.Include(x => x.Email).FirstOrDefault(x => x.Email == email);
        //    _contactDbContext.Add(email);
        //    _contactDbContext.Update(email).Context.SaveChanges();

        //    return  email;

        //}


    }
}
