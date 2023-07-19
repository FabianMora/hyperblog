using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiSqlPlatzi.models;

namespace ApiSqlPlatzi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private ContactsContext contactsContext;
        public ContactController(ContactsContext context)
        {
            contactsContext = context;
        }

        // GET api/contact
        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> Get()
        {
            return contactsContext.ContactSet.ToList();
        }

        // GET api/contact/5
        [HttpGet("{id}")]
        public ActionResult<Contacts> Get(int id)
        {
            var selected = (from c in contactsContext.ContactSet
                            where c.Identificador == id
                            select c).FirstOrDefault();
            return selected;
        }

        // POST api/contact
        [HttpPost]
        public IActionResult Post([FromBody] Contacts value)
        {
            Contacts newcontact = value;
            contactsContext.ContactSet.Add(newcontact);
            contactsContext.SaveChanges();
            return Ok("Contacto agregado");
        }

        // PUT api/contact/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/contact/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        ~ContactController()
        {
            contactsContext.Dispose();
        }
    }
}