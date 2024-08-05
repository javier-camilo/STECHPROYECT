using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public class LoginService
    {
        LoginRepository database;
        SqlConnection conexion;

        public LoginService()
        {
            conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documentos\STECHPROYECT\DAL\DBSchoolTech.mdf;Integrated Security=True");
            database = new LoginRepository(conexion);
        }
        public string GuardarBD(Administrador administrador)
        {
            try
            {
                conexion.Open();
                database.GuardarAdministrador(administrador);
                conexion.Close();
                return "Guardado correctamente";
            }
            catch (Exception)
            {
                conexion.Close();
                return "error al guardar";
            }
        }
        public List<Administrador> DatosAdministrador()
        {
            List<Administrador> administrador = new List<Administrador>();
            try
            {
                conexion.Open();
                administrador = database.ConsultarAdministradorBD();
                conexion.Close();
                return administrador;
            }
            catch (Exception e)
            {
                conexion.Close();
                return null;
            }
        }
        public bool Iniciar(string usuario, string clave)
        {
            List<Administrador> administrador = DatosAdministrador();
            if (administrador!=null)
            {
                foreach (var item in administrador)
                {
                    if (item.Usuario.Equals(usuario) && item.Clave.Equals(clave))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
