﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_A
{
	public partial class frmAsistencias : Form
	{
		conexion_db objConexion = new conexion_db();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public frmAsistencias()
		{
			InitializeComponent();
		}

		private void frmAsistencias_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["Asistencias"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idAsistencia"] };

			cboAlumno.DataSource = objConexion.obtener_datos().Tables["Alumnos"];
			cboAlumno.DisplayMember = "nombreAlumno";
			cboAlumno.ValueMember = "Alumnos.idAlumno";

			cboMeses.DataSource = objConexion.obtener_datos().Tables["Meses"];
			cboMeses.DisplayMember = "nombreMes";
			cboMeses.ValueMember = "Meses.idMes";
		}
		void mostrarDatos()
		{
			try
			{

				cboAlumno.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

				cboMeses.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();

				lblidAsistencia.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtfecha.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtasistio.Text = tbl.Rows[posicion].ItemArray[4].ToString();
				lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de Alquiler",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtfecha.Text = "";
			txtasistio.Text = "";
			
		}
		void controles(Boolean valor)
		{
			grbNavegacion.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbAsistencia.Enabled = !valor;
		}

		private void btnPrimero_Click(object sender, EventArgs e)
		{
			posicion = 0;
			mostrarDatos();
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			if (posicion > 0)
			{
				posicion--;
				mostrarDatos();
			}
			else
			{
				MessageBox.Show("Primer Registro...", "Registros de Asistencias",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			if (posicion < tbl.Rows.Count - 1)
			{
				posicion++;
				mostrarDatos();
			}
			else
			{
				MessageBox.Show("Ultimo Registro...", "Registros de Asistencias",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			posicion = tbl.Rows.Count - 1;
			mostrarDatos();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			if (btnNuevo.Text == "Nuevo")
			{//boton de nuevo
				btnNuevo.Text = "Guardar";
				btnModificar.Text = "Cancelar";
				accion = "nuevo";
				limpiar_cajas();
				controles(false);
			}
			else
			{ //boton de guardar 
				String[] valores = {
					lblidAsistencia.Text,
					cboAlumno.SelectedValue.ToString(),
					cboMeses.SelectedValue.ToString(),
					txtfecha.Text,
					txtasistio.Text,
				};
				objConexion.mantenimiento_datos_Asistencias(valores, accion);
				actualizarDs();
				posicion = tbl.Rows.Count - 1;
				mostrarDatos();

				controles(true);

				btnNuevo.Text = "Nuevo";
				btnModificar.Text = "Modificar";
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (btnModificar.Text == "Modificar")
			{//boton de modificar
				btnNuevo.Text = "Guardar";
				btnModificar.Text = "Cancelar";
				accion = "modificar";

				controles(false);

				btnNuevo.Text = "Guardar";
				btnModificar.Text = "Cancelar";

			}
			else
			{ //boton de cancelar
				controles(true);
				mostrarDatos();

				btnNuevo.Text = "Nuevo";
				btnModificar.Text = "Modificar";
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de elimina a " + cboAlumno.Text, "Registro de Asistencias",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblidAsistencia.Text };
				objConexion.mantenimiento_datos_Asistencias(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}
	}
}
