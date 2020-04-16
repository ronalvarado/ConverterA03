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

			} else if (accion == "modificar"){
				sql = "UPDATE Alumnos SET " +
					"Codigo                   = '" + datos[1] + "'," +
					"Nombre_Alumno            = '" + datos[2] + "'," +
					"Edad                     = '" + datos[3] +"',"  +
					"Direccion                = '" + datos[4] + "'," +
					"Telefono                 = '" + datos[5] + "'," +
					"Grado                    = '" + datos[6] + "'," +
					"Seccion                  = '" + datos[7] + "'" +
				    "WHERE IdAlumno           = '" + datos[0] + "'";
			}else if (accion == "eliminar"){
				sql = "DELETE Alumnos FROM Alumnos WHERE IdAlumno='" + datos[0] + "'";
			}
			procesarSQL(sql);
		}
		void procesarSQL(String sql)
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
			procesSQL(sql);
		}
		void procesSQL(String sql)
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
					"Docente                 = '" + datos[2] + "'," +
					"DUI                             = '" + datos[3] + "'," +
					"NIT                             = '" + datos[4] + "'," +
					"Especializacion                 = '" + datos[5] + "'," +
					"Correo_Electronico              = '" + datos[6] + "'," +
					"Telefono                        = '" + datos[7] + "'" +
					"WHERE IdDocente            = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Docentes FROM Responsables WHERE IdDocente='" + datos[0] + "'";
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
