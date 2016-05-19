using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using System.Data.SqlClient;
using System.Data;

namespace CapaRepositorio
{
    public class AlumnoRepo
    {
        String datosConexion = "Data Source = SAMSUNGF; Initial Catalog= Recuperatorio; Integrated security=true";
        
        public void GuardarAlumno(Alumno objAlumno)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string consulta = "insert into Inscripcion values ('" + objAlumno.idalumno + "','" + objAlumno.nombre + "','" + objAlumno.edad + "','" + objAlumno.Fechadeinscripcion.ToString() + "')";//
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable MostrarAlumnos()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string consulta = "select * from Inscripcion";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);

            conexion.Close();
            return datos;
        }

        public void ActualizarAlumno(Alumno objAlumno)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string consulta = "Update Inscripcion set nombre ='" + objAlumno.nombre + "' , edad ='" + objAlumno.edad + "', curso=" + objAlumno.curso + " , fechaInscripcion='" + objAlumno.Fechadeinscripcion.ToString() + "' where idCliente=" + objAlumno.idalumno;
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable Cargarddl()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string consulta = "select nombreCursos from Cursos";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);

            conexion.Close();
            return datos;
        }
         

    }
}
