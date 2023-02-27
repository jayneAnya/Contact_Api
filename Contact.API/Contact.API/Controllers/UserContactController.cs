using AutoMapper;
using AutoMapper.Internal;
using Contact.Core.Interface;
using Contact.Domain.Configuration;
using Contact.Domain.DTO;
using Contact.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserContactController : ControllerBase
    {
        private readonly IUserContact _userContact;
        private readonly IEmail _email;
        private readonly IMapper _mapper;

        
        public UserContactController(IUserContact userContact, IEmail email, IMapper mapper) 
        {
            _userContact = userContact;
            _email = email;
            _mapper = mapper;
           
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _userContact.GetAllUsersContact();
            
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var data = _userContact.GetContact(id);
           
            return Ok(data);
        }

       
        

        [HttpPost]
        public IActionResult CreateContact(UserContactDTO userContact)
        {
            var data =_userContact.AddContact(userContact);

           
           var user = _mapper.Map<UserContactDTO>(data);

            
            CreatedAtAction(nameof(Get), new { id = user.UserContactId }, userContact);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _userContact.Delete(id);
            return NoContent();
        }
    }
}
