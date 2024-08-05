using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class VerificarGrado
    {
        public int ConvertirGrado(string grado)
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
                    if (grado.Equals("TRNSICIÓN"))
                    {
                        return 3;
                    }
                    else
                    {
                        if (grado.Equals("1° PRIMERO"))
                        {
                            return 4;
                        }
                        else
                        {
                            if (grado.Equals("2° PRIMERO"))
                            {
                                return 5;
                            }
                            else
                            {
                                if (grado.Equals("3° PRIMERO"))
                                {
                                    return 6;
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }

    }
}
