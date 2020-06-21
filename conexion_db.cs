using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Conversor_A
{
	class conexion_db
	{
		SqlConnection miConexion = new SqlConnection();
		SqlCommand comandosSQL = new SqlCommand();
		SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

		DataSet ds = new DataSet();
		public conexion_db()
		{
			String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BaseEscuela.mdf;Integrated Security=True";
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
			comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Responsables";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Responsables");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Docentes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Docentes");
            comandosSQL.Connection = miConexion;

            return ds;
		}
        public void mantenimiento_datos_Alumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Alumnos (codigo,nombreAlumno,edad,direccion,telefono) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Alumnos SET " +
                    "codigo                    = '" + datos[1] + "'," +
                    "nombreAlumno              = '" + datos[2] + "'," +
                    "edad                      = '" + datos[3] + "'," +
                    "direccion                 = '" + datos[4] + "'," +
                    "telefono                  = '" + datos[5] + "'" +
                    "WHERE idAlumno            = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Alumnos FROM Alumnos WHERE idAlumno='" + datos[0] + "'";
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
                sql = "INSERT INTO Responsables (codigo,nombreResponsable,edad,direccion,dui,nit,telefono) VALUES(" +
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
                    "odigo                              = '" + datos[1] + "'," +
                    "nombreResponsable                  = '" + datos[2] + "'," +
                    "edad                               = '" + datos[3] + "'," +
                    "direccion                          = '" + datos[4] + "'," +
                    "dui                                = '" + datos[5] + "'," +
                    "nit                                = '" + datos[6] + "'," +
                    "telefono                           = '" + datos[7] + "'" +
                    "WHERE idResponsable                = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Responsables FROM Responsables WHERE idResponsable='" + datos[0] + "'";
            }
            prrocesasSQL(sql);
        }
        void prrocesasSQL(String sql)
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
                sql = "INSERT INTO Docentes (codigo,nombreDocente,dui,nit,especializacion,correoElectronico,telefono) VALUES(" +
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
                    "codigo                          = '" + datos[1] + "'," +
                    "docente                         = '" + datos[2] + "'," +
                    "dui                             = '" + datos[3] + "'," +
                    "nit                             = '" + datos[4] + "'," +
                    "especializacion                 = '" + datos[5] + "'," +
                    "correoElectronico               = '" + datos[6] + "'," +
                    "telefono                        = '" + datos[7] + "'" +
                    "WHERE idDocente                 = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Docentes FROM Docentes WHERE idDocente='" + datos[0] + "'";
            }
            pocesassSQL(sql);
        }
        void pocesassSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();

        }
    }
}
