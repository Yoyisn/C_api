using System;
using System.Web;
using System.Linq;
using System.Web.Http;
using ApiseriaCliente.Data;
using ApiseriaCliente.Models;
using System.Collections.Generic;

namespace ApiseriaCliente.Controllers
{
    public class ClienteController : ApiController
    {
        // GET api/<controller>
        public List<Cliente> Get()
        {
            return ClienteData.Listar();
        }
        // GET api/<controller>/5
        public List<Cliente> Get(string id)
        {
            return ClienteData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Cliente oCliente)
        {
            return ClienteData.saveClient(oCliente);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Cliente oCliente)
        {
            return ClienteData.updateClient(oCliente);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ClienteData.deleteClient(id);
        }
    }
}