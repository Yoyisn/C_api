using System;
using System.Web;
using System.Linq;
using Apiseria.Data;
using Apiseria.Models;
using System.Web.Http;
using System.Collections.Generic;

namespace Apiseria.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }
        // GET api/<controller>/5
        public List<Usuario> Get(string id)
        {
            return UsuarioData.Obtener(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.saveUser(oUsuario);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.updateUser(oUsuario);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return UsuarioData.deleteUser(id);
        }
    }
}