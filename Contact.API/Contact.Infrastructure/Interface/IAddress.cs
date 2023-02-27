using Contact.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Core.Interface
{
    public interface IAddress
    {
        Address GetAddressById(int id);
    }
}
