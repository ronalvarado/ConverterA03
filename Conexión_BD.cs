using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Conversor_A
{
	class Conexion_BD
	{
		SqlConnection miConexion = new SqlConnection();
		SqlCommand comandosSQL = new SqlCommand();
		SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

		DataSet ds = new DataSet();
		public Conexion_BD()
		{
			String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProyectoEscuela_.mdf;Integrated Security=True";
			miConexion.ConnectionString = cadena;
			miConexion.Open();
		}
		public DataSet obtener_datos()
		{
			ds.Clear();
			comandosSQL.Connection = miConexion;

			comandosSQL.CommandText = "select * from Alumnos";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Alumnos");

			comandosSQL.CommandText = "select * from Responsables";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Responsables");

			comandosSQL.CommandText = "select * from Docentes";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Docentes");

			comandosSQL.CommandText = "select * from Matriculas";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Matriculas");

			comandosSQL.CommandText = "select * from TutordAula";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "TutordAula");

			comandosSQL.CommandText = "select * from Asistencias";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Asistencias");

			comandosSQL.CommandText = "select * from Meses";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Meses");

			comandosSQL.CommandText = "select * from Materias";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Materias");

			comandosSQL.CommandText = "select * from Notas";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Notas");

			return ds;
		}
		public void mantenimiento_datos(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo") {
				sql = "INSERT INTO Alumnos (Codigo,Nombre_Alumno,Edad,Direccion,Telefono,Grado,Seccion) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'," +
					"'" + datos[5] + "'," +
					"'" + datos[6] + "'," +
					"'" + datos[7] + "'" +
					")";

			} else if (accion == "modificar") {
				sql = "UPDATE Alumnos SET " +
					"Codigo                   = '" + datos[1] + "'," +
					"Nombre_Alumno            = '" + datos[2] + "'," +
					"Edad                     = '" + datos[3] + "'," +
					"Direccion                = '" + datos[4] + "'," +
					"Telefono                 = '" + datos[5] + "'," +
					"Grado                    = '" + datos[6] + "'," +
					"Seccion                  = '" + datos[7] + "'" +
					"WHERE IdAlumno           = '" + datos[0] + "'";
			} //else if (accion == "eliminar") {
			  //sql = "DELETE Alumnos FROM Alumnos WHERE IdAlumno='" + datos[0] + "'";
			  //}
			else if (accion == "eliminar")
			{
				sql = "DELETE Alumnos FROM Alumnos WHERE IdAlumno='" + datos[0] + "'";
			}
			procesiaSQL(sql);
		}
		void procesiaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_datos_Responsables(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO Responsables (Codigo,Nombre_Responsables,Edad,Direccion,Telefono,DUI,NIT) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'," +
					"'" + datos[5] + "'," +
					"'" + datos[6] + "'," +
					"'" + datos[7] + "'" +
					")";

			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Responsables SET " +
					"Codigo                        = '" + datos[1] + "'," +
					"Nombre_Responsables           = '" + datos[2] + "'," +
					"Edad                          = '" + datos[3] + "'," +
					"Direccion                     = '" + datos[4] + "'," +
					"Telefono                      = '" + datos[5] + "'," +
					"DUI                           = '" + datos[6] + "'," +
					"NIT                           = '" + datos[7] + "'" +
					"WHERE IdResponsables           = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Responsables FROM Responsables WHERE IdResponsables='" + datos[0] + "'";
			}
			prrocesaSQL(sql);
		}
		void prrocesaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_datos_Docentes(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO Docentes (Codigo,Docente,DUI,NIT,Especializacion,Correo_Electronico,Telefono) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'," +
					"'" + datos[5] + "'," +
					"'" + datos[6] + "'," +
					"'" + datos[7] + "'" +
					")";

			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Docentes SET " +
					"Codigo                          = '" + datos[1] + "'," +
					"Docente                         = '" + datos[2] + "'," +
					"DUI                             = '" + datos[3] + "'," +
					"NIT                             = '" + datos[4] + "'," +
					"Especializacion                 = '" + datos[5] + "'," +
					"Correo_Electronico              = '" + datos[6] + "'," +
					"Telefono                        = '" + datos[7] + "'" +
					"WHERE IdDocente            = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Docentes FROM Docentes WHERE IdDocente='" + datos[0] + "'";
			}
			pocesaSQL(sql);
		}
		void pocesaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_datos_TutordAula(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO TutordAula (IdDocente,Codigo,Grado,Seccion) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'" +
					")";
			}
			else if (accion == "modificar")
			{
				sql = "UPDATE TutordAula SET " +
					"IdDocente           = '" + datos[1] + "'," +
					"codigo		         = '" + datos[2] + "'," +
					"Grado			     = '" + datos[3] + "'," +
					"Seccion		     = '" + datos[4] + "'" +
					"WHERE IdAula = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE TutordAula FROM TutordAula WHERE IdAula='" + datos[0] + "'";
			}
			proceaSQL(sql);
		}
		void proceaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_Matriculas(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO Matriculas (IdAlumno,IdResponsable,FechadeMatricula) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'" +
					")";

			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Matriculas SET " +
					"IdAlumno                     = '" + datos[1] + "'," +
					"IdResponsable                = '" + datos[2] + "'," +
					"FechadeMatricula			  = '" + datos[3] + "'" +
					"WHERE IdMatricula            = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Matriculas FROM Matriculas WHERE IdMatricula='" + datos[0] + "'";
			}
			procsaSQL(sql);
		}
		void procsaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_Asistencias(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo") {
				sql = "INSERT INTO Asistencias (IdAlumno,IdMes,Dia,Si,No,) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'," +
					"'" + datos[5] + "'" +
					")";
			}
			else if (accion == "modificar") {
				sql = "UPDATE Asistencias SET " +
					"IdAlumno                   = '" + datos[1] + "'," +
					"IdMes                      = '" + datos[2] + "'," +
					"Dia                        = '" + datos[3] + "'," +
					"Si                         = '" + datos[4] + "'," +
					"No                         = '" + datos[5] + "'" +
					"WHERE IdAsistencia         = '" + datos[0] + "'";
			}
			else if (accion == "eliminar") {
				sql = "DELETE Asistencias FROM Asistencias WHERE IdAsistencia='" + datos[0] + "'";
			}
			procesaisSQL(sql);
		}
		void procesaisSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_datos_Meses(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO Meses (Mes) VALUES(" +
					"'" + datos[1] + "'" +
					")";
			}
			else if (accion == "modificar")
			{
				sql = "UPDATE categorias SET " +
					"Mes            = '" + datos[1] + "'" +
					"WHERE IdMes    = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Meses FROM Meses WHERE IdMes='" + datos[0] + "'";
			}
			procesasSQL(sql);
		}
		void procesasSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_Materias(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO Materias (Codigo,Nombre_Materia) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'" +
					")";

			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Materias SET " +
					"Codigo                   = '" + datos[1] + "'," +
					"Nombre_Materia          = '" + datos[2] + "'" +
					"WHERE IdMateria           = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Materias FROM Materias WHERE IdMateria='" + datos[0] + "'";
			}
			procesaeSQL(sql);
		}
		void procesaeSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_datos_Notas(String[] datos, String accion)
		{
			string sql = "";
			if (accion == "nuevo") {
				sql = "INSERT INTO Notas (IdAlumno,IdMateria,Examen,Actividad1,Actividad2,Nota) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'," +
					"'" + datos[5] + "'," +
					"'" + datos[6] + "'" +
					")";
			}
			else if (accion == "modificar"){
				sql = "UPDATE Notas SET" +
					"IdAlumno				='" + datos[1] + "'," +
					"IdMateria				='" + datos[2] + "'," +
					"Examen					='" + datos[3] + "'," +
					"Actividad1				='" + datos[4] + "'," +
					"Actividad2				='" + datos[5] + "'," +
					"Nota					='" + datos[6] + "'"  +
					"WHERE IdNota			='" + datos[0] + "'" ;
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Notas FROM Notas WHERE IdNota='" + datos[0] + "'" ;
			}
		}
		void procesaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
	}
}
