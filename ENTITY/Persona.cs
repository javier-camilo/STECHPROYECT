using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public Persona()
        {
            Nombre = new Nombre();
            FechaNacimiento = new Fecha();
        }
        public string Identificacion { get; set; }
        public Nombre Nombre { get; set; }
        public string Sexo { get; set; }
        public Fecha FechaNacimiento { get; set; }
    }
}
