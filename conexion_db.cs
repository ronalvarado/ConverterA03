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

            comandosSQL.CommandText = "select * from Materias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Materias");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Grados";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Grados");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Secciones";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Secciones");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Trimestres";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Trimestres");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Aulas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Aulas");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Meses";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Meses");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Asistencias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Asistencias");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select Alumnos.nombreAlumno, Asistencias.idAsistencia, Asistencias.dia, Asistencias.asistio from Asistencias inner join Alumnos on(Alumnos.idAlumno=Asistencias.idAlumno)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Asistencias_Alumnos");

            comandosSQL.CommandText = "select Meses.nombreMes, Asistencias.idAsistencia, Asistencias.dia, Asistencias.asistio from Asistencias inner join Meses on(Meses.idMes=Asistencias.idMes)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Asistencias_Meses");

            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = "select Alumnos.nombreAlumno, Asistencias.idAsistencia, Asistencias.dia, Asistencias.asistio," + " Meses.nombreMes " + " from Asistencias " + " inner join Alumnos on(Alumnos.idAlumno = Asistencias.idAlumno)" + " inner join Meses on(Meses.idMes = Asistencias.idMes)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Alumnos_Meses_Asistencias");

            comandosSQL.CommandText = "select * from pagaDocente";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "pagaDocente");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select Docentes.nombreDocente, pagaDocente.idPago, pagaDocente.sueldoBase, pagaDocente.isss, pagaDocente.afp, pagaDocente.renta, pagaDocente.totalPagar from pagaDocente inner join Docentes on(Docentes.idDocente=pagaDocente.idDocente)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "pagaDocente_Docentes");

            comandosSQL.CommandText = "select Meses.nombreMes, pagaDocente.idPago, pagaDocente.sueldoBase, pagaDocente.isss, pagaDocente.afp, pagaDocente.renta, pagaDocente.totalPagar from pagaDocente inner join Meses on(Meses.idMes=pagaDocente.idMes)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "pagaDocente_Meses");

            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = "select Docentes.nombreDocente, pagaDocente.idPago, pagaDocente.sueldoBase, pagaDocente.isss, pagaDocente.afp, pagaDocente.renta, pagaDocente.totalPagar," + " Meses.nombreMes " + " from pagaDocente " + " inner join Docentes on(Docentes.idDocente = pagaDocente.idDocente) " + " inner join Meses on(Meses.idMes = pagaDocente.idMes)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Docentes_Meses_pagaDocente");

            comandosSQL.CommandText = "select * from Notas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Notas");
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select Alumnos.nombreAlumno, Notas.idNota, Notas.actividad1, Notas.actividad2, Notas.examen, Notas.nota from Notas inner join Alumnos on(Alumnos.idAlumno=Notas.idAlumno)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Notas_Alumnos");

            comandosSQL.CommandText = "select Materias.nombreMateria, Notas.idNota, Notas.actividad1, Notas.actividad2, Notas.examen, Notas.nota from Notas inner join Materias on(Materias.idMateria=Notas.idMateria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Notas_Materia");

            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = "select Alumnos.nombreAlumno,Notas.idNota, Notas.actividad1, Notas.actividad2, Notas.examen, Notas.nota, " + " Materias.nombreMateria " + " from Notas " + " inner join Alumnos on(Alumnos.idAlumno = Notas.idAlumno) " + " inner join Materias on(Materias.idMateria = Notas.idMateria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Alumnos_Materias_Notas");

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
                    "codigo                              = '" + datos[1] + "'," +
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
                    "nombreDocente                   = '" + datos[2] + "'," +
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
        public void mantenimiento_datos_Materias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Materias (codigo,nombreMateria) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Materias SET " +
                    "codigo                    = '" + datos[1] + "'," +
                    "nombreMateria             = '" + datos[2] + "'" +
                    "WHERE idMateria           = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Materias FROM Materias WHERE idMateria='" + datos[0] + "'";
            }
            procesaemSQL(sql);
        }
        void procesaemSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();

        }
        public void mantenimiento_datos_Grados(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Grados (nombreGrado) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Grados SET " +
                    "nombreGrado               = '" + datos[1] + "'" +
                    "WHERE idGrado             = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Grados FROM Grados WHERE idGrado='" + datos[0] + "'";
            }
            procesaaemSQL(sql);
        }
        void procesaaemSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();

        }
        public void mantenimiento_datos_Secciones(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Secciones (nombreSeccion) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Secciones SET " +
                    "nombreSeccion               = '" + datos[1] + "'" +
                    "WHERE idSeccion             = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Secciones FROM Secciones WHERE idSeccion='" + datos[0] + "'";
            }
            procesasaemSQL(sql);
        }
        void procesasaemSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
        public void mantenimiento_datos_Trimestres(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Trimestres (nombreTrimestre) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Trimestres SET " +
                    "nombreTrimestre               = '" + datos[1] + "'" +
                    "WHERE idTrimestre             = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Trimestres FROM Trimestres WHERE idTrimestre='" + datos[0] + "'";
            }
            procesasaenmSQL(sql);
        }
        void procesasaenmSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
        public void mantenimiento_datos_Aulas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Aulas (nombreAula) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Aulas SET " +
                    "nombreAula               = '" + datos[1] + "'" +
                    "WHERE idAula             = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Aulas FROM Aulas WHERE idAula='" + datos[0] + "'";
            }
            procesasanmSQL(sql);
        }
        void procesasanmSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
        public void mantenimiento_datos_Asistencias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Asistencias (idAlumno,idMes,dia,asistio) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Asistencias SET " +
                    "idAlumno						    		 = '" + datos[1] + "'," +
                    "idMes						             	 = '" + datos[2] + "'," +
                    "dia 							             = '" + datos[3] + "'," +
                    "asistio									 = '" + datos[4] + "'" +
                    "WHERE idAsistencia						     = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Asistencias FROM Asistencias WHERE idAsistencia='" + datos[0] + "'";
            }
            proceraSQL(sql);
        }
        void proceraSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();

        }
        public void mantenimiento_datos_pagaDocente(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO pagaDocente (idDocente,idMes,sueldoBase,isss,afp,renta,totalPagar) VALUES(" +
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
                sql = "UPDATE pagaDocente SET " +
                    "idDocente						    		 = '" + datos[1] + "'," +
                    "idMes						             	 = '" + datos[2] + "'," +
                    "sueldoBase							         = '" + datos[3] + "'," +
                    "isss						    		     = '" + datos[4] + "'," +
                    "afp						             	 = '" + datos[5] + "'," +
                    "renta							             = '" + datos[6] + "'," +
                    "totalPagar									 = '" + datos[7] + "'" +
                    "WHERE idPago					    	     = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE pagaDocente FROM pagaDocente WHERE idPago='" + datos[0] + "'";
            }
            procereaSQL(sql);
        }
        void procereaSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
        public void mantenimiento_datos_Notas (String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Notas (idAlumno,idMateria,actividad1,actividad2,examen,nota) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Notas SET " +
                    "idAlumno						    		     = '" + datos[1] + "'," +
                    "idMateria						             	 = '" + datos[2] + "'," +
                    "actividad1							             = '" + datos[3] + "'," +
                    "actividad2						    		     = '" + datos[4] + "'," +
                    "examen						             	     = '" + datos[5] + "'," +
                    "nota									         = '" + datos[6] + "'" +
                    "WHERE idNota					         	     = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Notas FROM Notas WHERE idNota='" + datos[0] + "'";
            }
            procerewaSQL(sql);
        }
        void procerewaSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }
}
