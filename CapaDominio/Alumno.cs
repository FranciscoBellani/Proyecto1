using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Alumno
    {

        private int IdAlumno;

        public int idalumno
        {
            get { return IdAlumno; }
            set { IdAlumno = value; }
        }
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private int Edad;

        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        private DateTime fechainscripcion;

        public DateTime Fechadeinscripcion
        {
            get { return fechainscripcion; }
            set { fechainscripcion = value; }
        }
        private string Curso;

        public string curso
        {
            get { return Curso; }
            set { Curso = value; }
        }
    }
}
