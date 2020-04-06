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
	public partial class Mantenimiento_de__Responsables : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public Mantenimiento_de__Responsables()
		{
			InitializeComponent();
		}

		private void Mantenimiento_de__Alumnos_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["Alumnos"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdAlumno"] };
		}
		void mostrarDatos()
		{
			try
			{
				lblIdResponsable.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtCodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
				txtDatos.Text = tbl.Rows[posicion].ItemArray[2].ToString();


				lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de Alumnos",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtCodigo.Text = "";
			txtDatos.Text = "";

		}
		void controles(Boolean valor)
		{
			grbNavegacion.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbEdicionderesponsables.Enabled = !valor;
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
				MessageBox.Show("Primer Registro...", "Registros de Alumnos",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void btnUltimo_Click(object sender, EventArgs e)
		{
			posicion = tbl.Rows.Count - 1;
			mostrarDatos();
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
				MessageBox.Show("Ultimo Registro...", "Registros de Alumnos",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
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
					lblIdResponsable.Text,
					txtCodigo.Text,
					txtDatos.Text,
				};
				objConexion.mantenimiento_datos(valores, accion);
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

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de elimina a " + txtDatos.Text, "Registro de Alumnos",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdResponsable.Text };
				objConexion.mantenimiento_datos(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			Busqueda_Alumnos frmBusquedaAlumnos = new Busqueda_Alumnos();
			frmBusquedaAlumnos.ShowDialog();

			if (frmBusquedaAlumnos._IdAlumno > 0)
			{
				posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaAlumnos._IdAlumno));
				mostrarDatos();
			}
		}

		private void grbAlumnos_Enter(object sender, EventArgs e)
		{

		}
	}

}
