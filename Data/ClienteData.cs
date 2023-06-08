using System;
using System.Web;
using System.Linq;
using Apiseria.Data;
using System.Data.SqlClient;
using ApiseriaCliente.Models;
using System.Collections.Generic;
using Apiseria.Models;

namespace ApiseriaCliente.Data
{
    public class ClienteData
    {
        public static bool saveClient(Cliente oCliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_saveC '" + oCliente.id_c + "', '" + oCliente.nombre + "', '" + oCliente.apellido + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool updateClient(Cliente oCliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_updateC '" + oCliente.id_c + "', '" + oCliente.nombre + "', '" + oCliente.apellido + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool deleteClient(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_deleteC '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static List<Cliente> Listar()
        {
            List<Cliente> oCliente = new List<Cliente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listarC";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oCliente.Add(new Cliente()
                    {
                        id_c = Convert.ToInt32(dr["id_c"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString()
                    });
                }
                return oCliente;
            }
            else
            {
                return oCliente;
            }
        }

        public static List<Cliente> Obtener(string id)
        {
            List<Cliente> oCliente = new List<Cliente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtenerC '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oCliente.Add(new Cliente()
                    {
                        id_c = Convert.ToInt32(dr["id_c"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString()
                    });
                }
                return oCliente;
            }
            else
            {
                return oCliente;
            }
        }


    }
}