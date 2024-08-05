using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ValidacionesService
    {
        public string MensajeValidar {
            get
            {
                return "debe llenar todos los campos";
            }
        }

        public string VerificarStringVacio(string palabra)
        {
            return palabra.Equals("") ? throw new Exception() : palabra;
        }

        public bool VerificarCampoMateria(string combo, string txtMateria)
        {
            if (combo == "" || txtMateria=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarCamposLogros(string comboGrado, string comboMateria, string comboCalificacion, string txtLogro)
        {
            if (comboGrado.Equals("") || comboMateria.Equals("") || comboCalificacion.Equals("") || txtLogro.Equals("") )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
