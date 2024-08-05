using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AsignarCalificacion
    {

        public double NotaMenor { get; set; }
        public double NotaMayor { get; set; }

        public void CalcularNota(string cadena)
        {
            if (cadena=="SUPERIOR")
            {
                NotaMayor = 5.0;
                NotaMenor = 4.6;

            }
            if (cadena == "ALTO")
            {
                NotaMayor = 4.5;
                NotaMenor = 4.0;
            }
            if (cadena == "BASICO")
            {

                NotaMayor = 3.9;
                NotaMenor = 3.0;
            }
            if (cadena == "BAJO")
            {

                NotaMayor = 2.9;
                NotaMenor = 0.0;
            }
        }
    }
}
