using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaRepositorio;
using CapaDominio;
using CapaNegocio;

namespace ProgramacionWeb
{
    public partial class Inscripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            AlumnoRepo datosrepo = new AlumnoRepo();
            gvAlumnos.DataSource = datosrepo.MostrarAlumnos();
            gvAlumnos.DataBind();
        }
        private void GuardarAlumno()
        {
            Alumno Alumnonuevo = new Alumno();
            Alumnonuevo.nombre = txtnombre.Text;
            Alumnonuevo.edad = int.Parse(txtedad.Text);
            //cliente.Fechadenacimiento = Convert.ToDateTime(date.Text);
            Metodos traermetodos = new Metodos();
            traermetodos.GuardarAlumno(Alumnonuevo);
                    }

      
        

        protected void ddlCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

            AlumnoRepo Cursos= new AlumnoRepo();
            ddlCursos.DataSource = Cursos.Cargarddl();
            ddlCursos.DataTextField = "Curso";                       
            ddlCursos.DataValueField = "nombreCurso";
            ddlCursos.DataBind();
            
            
        }

        protected void btn2_Click1(object sender, EventArgs e)
        {
            GuardarAlumno();
        }   
    }
}