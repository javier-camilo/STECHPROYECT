using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace DAL
{
    public class LoginRepository
    {
        SqlConnection conexion;
        SqlDataReader Reader;

        public LoginRepository(SqlConnection conexion)
        {
            this.conexion = conexion;
        }
        public void GuardarAdministrador(Administrador administrador)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "insert into Administrador values(@Usuario," +
                    "@Clave,@Nombre,@Correo)";

                comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = administrador.Usuario;
                comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = administrador.Clave;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = administrador.Nombre;
                comando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = administrador.Correo;
                
                comando.ExecuteNonQuery();
            }
        }
        public List<Administrador> ConsultarAdministradorBD()
        {
            List<Administrador> administrador = new List<Administrador>();
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "select * from Administrador";
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Administrador admin = MapAdministrador(Reader);
                    administrador.Add(admin);
                }
            }
            return administrador;
        }
        private Administrador MapAdministrador(SqlDataReader reader)
        {
            Administrador administrador = new Administrador();
            administrador.Usuario = (string)reader["Usuario"];
            administrador.Clave = (string)reader["Clave"];
            administrador.Nombre = (string)reader["Nombre"];
            administrador.Correo = (string)reader["Correo"];
            return administrador;
        }
    }
}
