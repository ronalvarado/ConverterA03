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

			parametrizacion();
		}
		private void parametrizacion()
		{
			comandosSQL.Parameters.Add("@IdA", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdAs", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdD", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdMat", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdMatri", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdNot", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdPag", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdRes", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@IdAu", SqlDbType.Int).Value = 0;
			comandosSQL.Parameters.Add("@Cod", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Nom", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Dir", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Tel", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Dui", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Nit", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Eda", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Grad", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Dia", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@No", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Si", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Sec", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Esp", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Corr", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@FMat", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Exa", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Ac1", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Ac2", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Not", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@Sueld", SqlDbType.Char).Value = "";
			comandosSQL.Parameters.Add("@TotP", SqlDbType.Char).Value = "";

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

			comandosSQL.CommandText = "select Alumnos.Nombre_Alumno, Matriculas.IdMatricula, Matriculas.FechadeMatricula from Matriculas inner join Alumnos on(Alumnos.IdAlumno=Matriculas.IdAlumno)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Matriculas_Alumnos");

			comandosSQL.CommandText = "select Responsables.Nombre_Responsables, Matriculas.IdMatricula, Matriculas.FechadeMatricula from Matriculas inner join Responsables on(Responsables.IdResponsables=Matriculas.IdResponsables)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Matriculas_Responsables");

			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = "select Alumnos.Nombre_Alumno, Matriculas.IdMatricula, Matriculas.FechadeMatricula," + " Responsables.Nombre_Responsables " + " from Matriculas " + " inner join Alumnos on(Alumnos.IdAlumno = Matriculas.IdAlumno)" + " inner join Responsables on(Responsables.IdResponsables = Matriculas.IdResponsables)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Alumnos_Responsables_Matriculas");

			comandosSQL.CommandText = "select * from Matriculas";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Matriculas");

			//comandosSQL.CommandText = "select Docentes.Docente, TutordAula.IdAula, TutordAula.Codigo, TutordAula.Grado, TutordAula.Seccion from TutordAula inner join Docentes on(Docentes.IdDocente=TutordAula.IdDocente)";
			//miAdaptadorDatos.SelectCommand = comandosSQL;
			//miAdaptadorDatos.Fill(ds, "TutordAula_Docentes");

			//comandosSQL.Connection = miConexion;
			//comandosSQL.CommandText = "select Docentes.Docente, TutordAula.IdAula, TutordAula.Codigo, TutordAula.Grado, TutordAula.Seccion," + " inner join Docentes on(Docentes.IdDocente = TutordAula.IdDocente)";
			//miAdaptadorDatos.SelectCommand = comandosSQL;
			//miAdaptadorDatos.Fill(ds, "Docentes_TutordAula");

			comandosSQL.CommandText = "select Docentes.Docente, TutordAula.IdAula, TutordAula.codigo, TutordAula.Grado, TutordAula.Seccion from TutordAula inner join Docentes on(Docentes.IdDocente=TutordAula.IdDocente)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "TutordAula_Docentes");

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

			comandosSQL.CommandText = "select Alumnos.Nombre_Alumno, Notas.IdNotas, Notas.Examen, Notas.Actividad1, Notas.Actividad2, Notas.Nota from Notas inner join Alumnos on(Alumnos.IdAlumno=Notas.IdAlumno)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Notas_Alumnos");

			comandosSQL.CommandText = "select Materias.Nombre_Materia, Notas.IdNotas, Notas.Examen, Notas.Actividad1, Notas.Actividad2, Notas.Nota from Notas inner join Materias on(Materias.IdMateria=Notas.IdMateria)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Notas_Alumnos");

			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = "select Alumnos.Nombre_Alumno, Notas.IdNotas, Notas.Examen, Notas.Actividad1, Notas.Actividad2, Notas.Nota," + " Materias.Nombre_Materia " + " from Notas " + " inner join Alumnos on(Alumnos.IdAlumno = Notas.IdAlumno)" + " inner join Materias on(Materias.IdMateria = Notas.IdMateria)";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Alumnos_Materias_Notas");

			comandosSQL.CommandText = "select * from Notas";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "Notas");

			return ds;
		}
		public void mantenimiento_datos(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo") {
				sql = "INSERT INTO Alumnos (Codigo,Nombre_Alumno,Edad,Direccion,Telefono,Grado,Seccion) VALUES(@Cod,@Nom,@Eda,@Dir,@Tel,@Grad,@Sec)";
			} else if (accion == "modificar") {
				sql = "UPDATE Alumnos SET " +
					"Codigo                   = @Cod," +
					"Nombre_Alumno            = @Nom," +
					"Edad                     = @Eda," +
					"Direccion                = @Dir," +
					"Telefono                 = @Tel," +
					"Grado                    = @Grad,"+
					"Seccion                  = @Sec " +
					"WHERE IdAlumno           = @IdA";
			} 
			else if (accion == "eliminar")
			{
				sql = "DELETE Alumnos FROM Alumnos WHERE IdAlumno=@IdA";
			}
			comandosSQL.Parameters["@IdA"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@Cod"].Value = datos[1];
				comandosSQL.Parameters["@Nom"].Value = datos[2];
				comandosSQL.Parameters["@Eda"].Value = datos[3];
				comandosSQL.Parameters["@Dir"].Value = datos[4];
				comandosSQL.Parameters["@Tel"].Value = datos[5];
				comandosSQL.Parameters["@Grad"].Value = datos[6];
				comandosSQL.Parameters["@Sec"].Value = datos[7];
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
				sql = "INSERT INTO Responsables (Codigo,Nombre_Responsables,Edad,Direccion,Telefono,DUI,NIT) VALUES(@Cod,@Nom,@Eda,@Dir,@Tel,@Dui,@Nit)";
			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Responsables SET " +
					"Codigo                        = @Cod," +
					"Nombre_Responsables           = @Nom," +
					"Edad                          = @Eda," +
					"Direccion                     = @Dir," +
					"Telefono                      = @Tel," +
					"DUI                           = @Dui," +
					"NIT                           = @Nit " +
					"WHERE IdResponsables           =@IdRes";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Responsables FROM Responsables WHERE IdResponsables=@IdRes";
			}
			comandosSQL.Parameters["@IdRes"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@Cod"].Value = datos[1];
				comandosSQL.Parameters["@Nom"].Value = datos[2];
				comandosSQL.Parameters["@Eda"].Value = datos[3];
				comandosSQL.Parameters["@Dir"].Value = datos[4];
				comandosSQL.Parameters["@Tel"].Value = datos[5];
				comandosSQL.Parameters["@Dui"].Value = datos[6];
				comandosSQL.Parameters["@Nit"].Value = datos[7];
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
				sql = "INSERT INTO Docentes (Codigo,Docente,DUI,NIT,Especializacion,Correo_Electronico,Telefono) VALUES(@Cod,@Nom,@Dui,@Nit,@Esp,@Corr,@Tel)";
			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Docentes SET " +
					"Codigo                          = @Cod," +
					"Docente                         = @Nom," +
					"DUI                             = @Dui," +
					"NIT                             = @Nit," +
					"Especializacion                 = @Esp," +
					"Correo_Electronico              = @Corr," +
					"Telefono                        = @Tel " +
					"WHERE IdDocente                 = @IdD";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Docentes FROM Docentes WHERE IdDocente= @IdD";
			}
			comandosSQL.Parameters["@IdD"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@Cod"].Value = datos[1];
				comandosSQL.Parameters["@Nom"].Value = datos[2];
				comandosSQL.Parameters["@Dui"].Value = datos[3];
				comandosSQL.Parameters["@Nit"].Value = datos[4];
				comandosSQL.Parameters["@Esp"].Value = datos[5];
				comandosSQL.Parameters["@Corr"].Value = datos[6];
				comandosSQL.Parameters["@Tel"].Value = datos[7];
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
				sql = "INSERT INTO TutordAula (IdDocente,Codigo,Grado,Seccion) VALUES(@IdD,@Cod,@Grad,@Sec)";
			}
			else if (accion == "modificar")
			{
				sql = "UPDATE TutordAula SET " +
					"IdDocente           = @IdD," +
					"Codigo		         = @Cod," +
					"Grado			     = @Grad," +
					"Seccion		     = @Sec " +
					"WHERE IdAula = @IdAu";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE TutordAula FROM TutordAula WHERE IdAula=@IdAu";
			}
			comandosSQL.Parameters["@IdAu"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@IdD"].Value = datos[1];
				comandosSQL.Parameters["@Cod"].Value = datos[2];
				comandosSQL.Parameters["@Grad"].Value = datos[3];
				comandosSQL.Parameters["@Sec"].Value = datos[4];
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
				sql = "INSERT INTO Matriculas (IdAlumno,IdResponsable,FechadeMatricula) VALUES(@IdA,@IdRes,@FMat)";
			}
			else if (accion == "modificar")
			{
				sql = "UPDATE Matriculas SET " +
					"IdAlumno                     = @IdA," +
					"IdResponsables               = @IdRes," +
					"FechadeMatricula			  = @FMat " +
					"WHERE IdMatricula            = @IdMatri";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Matriculas FROM Matriculas WHERE IdMatricula= @IdMatri";
			}
			comandosSQL.Parameters["@IdAu"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@IdA"].Value = datos[1];
				comandosSQL.Parameters["@IdRes"].Value = datos[2];
				comandosSQL.Parameters["@FMatri"].Value = datos[3];
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
				sql = "INSERT INTO Asistencias (IdAlumno,IdMes,Dia,Si,No,) VALUES(@IdA,@IdMes,@Dia,@Si,@No)";

			}
			else if (accion == "modificar") {
				sql = "UPDATE Asistencias SET " +
					"IdAlumno                   = @IdA," +
					"IdMes                      = @IdMes," +
					"Dia                        = @Dia," +
					"Si                         = @Si," +
					"No                         = @No " +
					"WHERE IdAsistencia         = @IdAs";
			}
			else if (accion == "eliminar") {
				sql = "DELETE Asistencias FROM Asistencias WHERE IdAsistencia=@IdAs";
			}
			comandosSQL.Parameters["@IdAs"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@IdA"].Value = datos[1];
				comandosSQL.Parameters["@IdMes"].Value = datos[2];
				comandosSQL.Parameters["@Dia"].Value = datos[3];
				comandosSQL.Parameters["@Si"].Value = datos[4];
				comandosSQL.Parameters["@No"].Value = datos[5];
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
				sql = "UPDATE Meses SET " +
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
				sql = "INSERT INTO Notas (IdAlumno,IdMateria,Examen,Actividad1,Actividad2,Nota) VALUES(@IdA,@IdMat,@Exa,@Ac1,@Ac2,@Not)";
			}
			else if (accion == "modificar"){
				sql = "UPDATE Notas SET" +
					"IdAlumno				=@IdA," +
					"IdMateria				=@IdMat," +
					"Examen					=@Exa," +
					"Actividad1				=@Ac1," +
					"Actividad2				=@Ac2," +
					"Nota					=@Not "  +
					"WHERE IdNotas			=@IdNot" ;
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Notas FROM Notas WHERE IdNotas=@IdNot" ;
			}
			comandosSQL.Parameters["@IdNot"].Value = datos[0];
			if (accion != "eliminar")
			{
				comandosSQL.Parameters["@IdA"].Value = datos[1];
				comandosSQL.Parameters["@IdMat"].Value = datos[2];
				comandosSQL.Parameters["@Exa"].Value = datos[3];
				comandosSQL.Parameters["@Ac1"].Value = datos[4];
				comandosSQL.Parameters["@Ac2"].Value = datos[5];
				comandosSQL.Parameters["@Not"].Value = datos[6];
			}
			procesaSQL(sql);
		}
		void procesaSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();
		}
	}
}
