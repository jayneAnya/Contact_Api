using AutoMapper;
using Contact.Core.Interface;
using Contact.Domain.Configuration;
using Contact.Domain.DTO;
using Contact.Domain.Model;
using Contact.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Contact.Core.Repository
{
    public class UserContactRepository : IUserContact
    {
        private readonly ContactDbContext _contactDbContext;
        private readonly IMapper _mapper;
        

        public UserContactRepository(ContactDbContext contactDbContext, IMapper mapper)
        {
            _contactDbContext = contactDbContext;
            _mapper = mapper;
           
        }
        
        public UserContact AddContact(UserContactDTO userContact)

        {
            var user = _mapper.Map<UserContact>(userContact); 
             var data = _contactDbContext.UserContacts.Add(user).Context.SaveChanges();


            return user;

        }

        public UserContact GetContact(int id)

        {
            //var user = _mapper.Map<UserContact>(id);
            return _contactDbContext.UserContacts.FirstOrDefault(x => x.UserContactId == id)!;
        }

        IEnumerable<UserContact> IUserContact.GetAllUsersContact()
        {

           return _contactDbContext.UserContacts.Include(s => s.Address).OrderBy(x => x.UserContactId);
        }

       public void Delete(int id)
        {
            var itemToDelete = _contactDbContext.UserContacts.Include(x => x.Email).Include(x => x.Address).Include(x => x.PhoneNumbers).FirstOrDefault(x => x.UserContactId == id);
            if(itemToDelete != null)
            {
                _contactDbContext.UserContacts.Remove(itemToDelete);
                _contactDbContext.SaveChanges();


            }

            


        }

    }
}
