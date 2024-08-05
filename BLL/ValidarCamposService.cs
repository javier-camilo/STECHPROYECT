using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace BLL
{
    public class ValidarCamposService
    {
        List<EstudioPrevio> EstudiosPrevios;
        public ValidarCamposService()
        {
            EstudiosPrevios = new List<EstudioPrevio>();
        }

        public int ConvertGradoToInt(string grado)
        {
            if (grado.Equals("PRE-JARDIN"))
            {
                return 1;
            }
            else
            {
                if (grado.Equals("JARDIN"))
                {
                    return 2;
                }
                else
                {
                    if (grado.Equals("TRANSICIÓN"))
                    {
                        return 3;
                    }
                    else
                    {
                        if (grado.Equals("PRIMERO"))
                        {
                            return 4;
                        }
                        else
                        {
                            if (grado.Equals("SEGUNDO"))
                            {
                                return 5;
                            }
                            else
                            {
                                if (grado.Equals("TERCERO"))
                                {
                                    return 6;
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                    }
                }
            }
            
        }

        public bool VerificarDatosTab2(Estudiante estudiante)
        {
            if (estudiante.Datos.Identificacion.Equals("")
            || estudiante.Datos.Nombre.PrimerNombre.Equals("")
            || estudiante.Datos.Nombre.SegundoNombre.Equals("")
            || estudiante.Datos.Nombre.PrimerApellido.Equals("")
            || estudiante.Datos.Nombre.SegundoApellido.Equals("")
            || estudiante.LugarNacimiento.Equals(""))
            {
                throw new Exception();
            }
            return true;
        } 

        public string ConvertSexoTo(string sexo)
        {
            if (sexo.Equals("MASCULINO"))
            {
                return "M";
            }
            else
            {
                if (sexo.Equals("FEMENINO"))
                {
                    return "F";
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public string ConvertComboToString(string palabra)
        {
            if (palabra.Equals("SI"))
            {
                return "";
            }
            else
            {
                if (palabra.Equals("NO"))
                {
                    return "";
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public bool VerificarVacio(string palabra)
        {
            return palabra.Equals("") ? throw new Exception() : true;
        }
        public void AgregarEstudiosPrevios(EstudioPrevio estudio)
        {
            EstudiosPrevios.Add(estudio);
        }
        public void QuitarEstudio(EstudioPrevio estudio)
        {
            EstudiosPrevios.Remove(estudio);
        }
        public List<EstudioPrevio> VerEstudiosPrevios()
        {
            return EstudiosPrevios;
        }
    }
}
