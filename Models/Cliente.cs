using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace ApiseriaCliente.Models
{
    public class Cliente
    {
        public int id_c { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}