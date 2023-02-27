using AutoMapper;
using Contact.Domain.DTO;
using Contact.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Configuration
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<UserContact, UserContactDTO>();
            //CreateMap<Email, EmailDTO>().ReverseMap();
            //CreateMap<Address, AddressDTO>().ReverseMap();
            //CreateMap<PhoneNumber, PhoneNumberDTO>().ReverseMap();


        }
    }
}
