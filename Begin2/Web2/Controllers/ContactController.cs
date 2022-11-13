using ContactManager.Models;
using ContactManager.Services;
using Microsoft.AspNetCore.Mvc;


namespace Web2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ContactController : ControllerBase
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}