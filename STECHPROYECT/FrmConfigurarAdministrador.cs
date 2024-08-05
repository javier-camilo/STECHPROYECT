using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STECHPROYECT
{
    public partial class FrmConfigurarAdministrador : Form,IReceptor
    {
        public FrmConfigurarAdministrador()
        {
            InitializeComponent();
        }

        public void Recibir(bool respuesta)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            LoginService login = new LoginService();
            try
            {
                Administrador administrador = new Administrador();
                administrador.Usuario = txtUsuario.Text;
                administrador.Clave = txtClave.Text;
                administrador.Nombre = txtNombre.Text;
                administrador.Correo = txtCorreo.Text;
                string m=login.GuardarBD(administrador);
                new ShowMessajeCorrecto(this, m, false).Show();
            }
            catch (Exception)
            {

            }
        }
    }
}
