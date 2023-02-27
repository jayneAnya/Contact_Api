using Contact.Domain.DTO;
using Contact.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Core.Interface
{
    public interface IUserContact
    {
        IEnumerable<UserContact> GetAllUsersContact();
        UserContact AddContact(UserContactDTO userContact);
        UserContact GetContact(int id);

        void Delete(int id);
    }
}
