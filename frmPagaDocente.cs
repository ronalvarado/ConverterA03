using System;
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
	public partial class frmPagaDocente : Form
	{
		conexion_db objConexion = new conexion_db();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public frmPagaDocente()
		{
			InitializeComponent();
		}

		private void frmPagaDocente_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["pagaDocente"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idPago"] };

			cboDocente.DataSource = objConexion.obtener_datos().Tables["Docentes"];
			cboDocente.DisplayMember = "nombreDocente";
			cboDocente.ValueMember = "Docentes.idDocente";

			cboMes.DataSource = objConexion.obtener_datos().Tables["Meses"];
			cboMes.DisplayMember = "nombreMes";
			cboMes.ValueMember = "Meses.idMes";

		}
		void mostrarDatos()
		{
			try
			{
				

				cboDocente.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

				cboMes.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();
				lblidPago.Text = tbl.Rows[posicion].ItemArray[0].ToString();

				txtsueldoBase.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtisss.Text = tbl.Rows[posicion].ItemArray[4].ToString();
				txtafp.Text = tbl.Rows[posicion].ItemArray[5].ToString();
				txtrenta.Text = tbl.Rows[posicion].ItemArray[6].ToString();
				txtpagar.Text = tbl.Rows[posicion].ItemArray[7].ToString();

				lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de Pago a Docentes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtsueldoBase.Text = "";
			txtisss.Text = "";
			txtafp.Text = "";
			txtrenta.Text = "";
			txtpagar.Text = "";

		}
		void controles(Boolean valor)
		{
			grbNavegacion.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbpagaDocente.Enabled = !valor;
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
				MessageBox.Show("Primer Registro...", "Registros de Pago a Docentes",
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
				MessageBox.Show("Ultimo Registro...", "Registros de Pago a Docentes",
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
					lblidPago.Text,
					cboDocente.SelectedValue.ToString(),
					cboMes.SelectedValue.ToString(),
					txtsueldoBase.Text,
					txtisss.Text,
					txtafp.Text,
					txtrenta.Text,
					txtpagar.Text,
				};
				objConexion.mantenimiento_datos_pagaDocente(valores, accion);
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
			if (MessageBox.Show("Esta seguro de elimina a " + cboDocente.Text, "Registro de Pago a Docentes",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblidPago.Text };
				objConexion.mantenimiento_datos_pagaDocente(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnHacer_Click(object sender, EventArgs e)
		{
			decimal num0 = decimal.Parse(txtsueldoBase.Text);
			decimal num1 = decimal.Parse(txtisss.Text);
			decimal num2 = decimal.Parse(txtafp.Text);
			decimal num3 = decimal.Parse(txtrenta.Text);
			decimal resp = 0;
			decimal total = 0;
			resp = num1 + num2 + num3;
			total = num0 - resp;
			txtpagar.Text = "" + total;
		}
	}
}
