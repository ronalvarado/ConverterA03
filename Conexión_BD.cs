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
				sql = "INSERT INTO Responsables (Codigo,Nombre_Responsable,Edad,Direccion,Telefono,DUI,NIT) VALUES(" +
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
					"Nombre_Responsable            = '" + datos[2] + "'," +
					"Edad                          = '" + datos[3] + "'," +
					"Direccion                     = '" + datos[4] + "'," +
					"Telefono                      = '" + datos[5] + "'," +
					"DUI                           = '" + datos[6] + "'," +
					"NIT                           = '" + datos[7] + "'" +
					"WHERE IdResponsable           = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE Responsables FROM Alumnos WHERE IdResponsable='" + datos[0] + "'";
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
