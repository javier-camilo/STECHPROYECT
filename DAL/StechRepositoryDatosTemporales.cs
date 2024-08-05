using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class StechRepositoryDatosTemporales
    {
        List<EstudioPrevio> Estudios;
        List<Acudiente> Acudientes;
        Estudiante estudiante;
        public StechRepositoryDatosTemporales()
        {
            Estudios = new List<EstudioPrevio>();
            Acudientes = new List<Acudiente>();
            estudiante = new Estudiante();
        }
        public void Estudiante(Estudiante estudiante)
        {
            this.estudiante = estudiante;
        }
        public Estudiante Estudiante()
        {
            return estudiante;
        }
        public void AgregarEstudio(EstudioPrevio estudio)
        {
            Estudios.Add(estudio);
        }
        public List<EstudioPrevio> EstudiosPrevios()
        {
            return Estudios;
        }
        public void QuitarEstudio(EstudioPrevio estudio)
        {
            Estudios.Remove(estudio);
        }
        public void AgregarAcudiente(Acudiente acudiente)
        {
            Acudientes.Add(acudiente);
        }
        public List<Acudiente> AcudientesAgregados()
        {
            return Acudientes;
        }
        public void QuitarAcudiente(Acudiente acudiente)
        {
            Acudientes.Remove(acudiente);
        }
    }
}
