using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Acudiente
    {
        public Acudiente()
        {
            DatosContacto = new Contacto();
        }
        public string IDEstudiante { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public Contacto DatosContacto { get; set; }
        public string Parentesco { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
    }
}
