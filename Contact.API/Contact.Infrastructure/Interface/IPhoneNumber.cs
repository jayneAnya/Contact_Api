using Contact.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Core.Interface
{
    public interface IPhoneNumber
    {
        IEnumerable<PhoneNumber> GetAllPhoneNumbers { get; }
        PhoneNumber GetPhoneNumberById(int id);
    }
}
