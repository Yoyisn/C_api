using System;
using System.Web;
using System.Linq;
using Apiseria.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Apiseria.Data
{
    public class UsuarioData
    {
        public static bool saveUser(Usuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_save '" + oUsuario.IdU + "', '" + oUsuario.Nombres + "', '" + oUsuario.Telefono + "', '" + oUsuario.Correo + "', '" + oUsuario.Ciudad + "' ";
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

        public static bool updateUser(Usuario oUsuario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_update '" + oUsuario.IdU + "', '" + oUsuario.Nombres + "', '" + oUsuario.Telefono + "', '" + oUsuario.Correo + "', '" + oUsuario.Ciudad + "'";
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

        public static bool deleteUser(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminar '" + id + "'";
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

        public static List<Usuario> Listar()
        {
            List<Usuario> oListaUsuario = new List<Usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listar";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Usuario()
                    {
                        IdU = Convert.ToInt32(dr["IdU"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Ciudad = dr["Ciudad"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }

        public static List<Usuario> Obtener(string id)
        {
            List<Usuario> oListaUsuario = new List<Usuario>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtener '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaUsuario.Add(new Usuario()
                    {
                        IdU = Convert.ToInt32(dr["IdU"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Ciudad = dr["Ciudad"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())
                    });
                }
                return oListaUsuario;
            }
            else
            {
                return oListaUsuario;
            }
        }
    }
}