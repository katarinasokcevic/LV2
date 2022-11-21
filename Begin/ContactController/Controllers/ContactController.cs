using ContactController.Models;
using ContactController.Services;
using System.Net.Http;
using System.Web.Http;

namespace ContactController.Controllers
{
    [Route("api/contact")]
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        [HttpGet]
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }

        [HttpPost]
        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}
