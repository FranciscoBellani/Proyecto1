using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaRepositorio;

namespace CapaNegocio
{
    public class Metodos
    {
        AlumnoRepo Alumno = new AlumnoRepo();

        public void GuardarAlumno(Alumno objAlumno)
        {
           
            Alumno.GuardarAlumno (objAlumno);
        }
        public void ActualizarCliente(Alumno objAlumno)
        {
            Alumno.ActualizarAlumno(objAlumno);
        }

        public void CargarListBox()
        { }

       
       
    }
}
