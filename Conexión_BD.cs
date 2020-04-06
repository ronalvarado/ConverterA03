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
                sql = "INSERT INTO Alumnos (Código,Datos del Alumno) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'" +
                    ")";

			} else if (accion == "modificar")
				{
					sql = "UPDATE Alumnos SET " +
						"codigo                   = '" + datos[1] + "'," +
						"Datos del Alumno         = '" + datos[2] + "'" +
						"WHERE IdAlumno           = '" + datos[0] + "'";
				}
				else if (accion == "eliminar")
				{
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
	}
}
