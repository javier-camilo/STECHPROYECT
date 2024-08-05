using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Estudiante
    {
        public Estudiante()
        {
            Datos = new Persona();
            FechaNacimiento = new Fecha();
            Acudientes = new List<Acudiente>();
            EstudiosPrevios = new List<EstudioPrevio>();
        }
        public string Grado { get; set; }
        public bool Estado { get; set; }
        public Persona Datos { get; set; }
        public Fecha FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string DificultadAprendizaje { get; set; }
        public string DificultadExpresionOral { get; set; }
        public string Enfermedad { get; set; }
        public string ViveCon { get; set; }
        public List<Acudiente> Acudientes { get; set; }
        public List<EstudioPrevio> EstudiosPrevios { get; set; }
    }
}
