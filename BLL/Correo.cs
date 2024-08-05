using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using INFRAESTRUCTURA;

namespace BLL
{
    public class Correo
    {
        private List<RutaArchivo> Rutas;
        public Correo()
        {
            Rutas = new List<RutaArchivo>();
        }
        public bool Enviar(Email email)
        {
            return new EnviarCorreo().Enviar(email);
        }

        public void AgregarRuta(RutaArchivo ruta)
        {
            Rutas.Add(ruta);
        }

        public void BorrarRuta(RutaArchivo ruta)
        {
            Rutas.Remove(ruta);
        }
        public List<RutaArchivo> LitaRutas()
        {
            return Rutas;
        }
    }
}
