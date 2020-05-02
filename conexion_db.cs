﻿using System;
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

		public DataSet obtener_datos()
		{
			ds.Clear();
			comandosSQL.Connection = miConexion;

			comandosSQL.CommandText = "select * from clientes";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "clientes");

			comandosSQL.CommandText = "select * from peliculas";
			miAdaptadorDatos.SelectCommand = comandosSQL;
			miAdaptadorDatos.Fill(ds, "peliculas");

			return ds;

		}
		public Conexion_db()
		{
			String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_Sistema_Peliculas.mdf;Integrated Security=True";
			miConexion.ConnectionString = cadena;
			miConexion.Open();
		}
		public void mantenimiento_datos_Clientes(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO clientes (nombre,direccion,telefono,dui) VALUES(" +
					"'" + datos[1] + "'," +
					"'" + datos[2] + "'," +
					"'" + datos[3] + "'," +
					"'" + datos[4] + "'" +
					")";

			}
			else if (accion == "modificar")
			{
				sql = "UPDATE clientes SET " +
					"nombre						 = '" + datos[1] + "'," +
					"direccion				     = '" + datos[2] + "'," +
					"telefono                    = '" + datos[3] + "'," +
					"dui						 = '" + datos[4] + "'" +
					"WHERE IdCliente		     = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE clientes FROM clientes WHERE IdCliente='" + datos[0] + "'";
			}
			procesarSQL(sql);
		}
		void procesarSQL(String sql)
		{
			comandosSQL.Connection = miConexion;
			comandosSQL.CommandText = sql;
			comandosSQL.ExecuteNonQuery();

		}
		public void mantenimiento_datos_Peliculas(String[] datos, String accion)
		{
			String sql = "";
			if (accion == "nuevo")
			{
				sql = "INSERT INTO peliculas (nombre,descripcion,sipnosis,genero,duracion) VALUES(" +
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
					"nombre						 = '" + datos[1] + "'," +
					"descripcion				 = '" + datos[2] + "'," +
					"sipnosis                    = '" + datos[3] + "'," +
					"genero						 = '" + datos[4] + "'," +
					"duracion                    = '" + datos[5] + "'" +
					"WHERE IdCliente		     = '" + datos[0] + "'";
			}
			else if (accion == "eliminar")
			{
				sql = "DELETE peliculas FROM peliculas WHERE IdPelicula='" + datos[0] + "'";
			}
			procesarSQL(sql);
		}
	}
}
