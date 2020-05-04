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
	public partial class Clientes : Form
	{
		conexion_db objConexion = new conexion_db();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public Clientes()
		{
			InitializeComponent();
		}

		private void Clientes_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["clientes"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdCliente"] };
		}
		void mostrarDatos()
		{
			try
			{
				lblIdCliente.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtNombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();
				txtDireccion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
				txtTelefono.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtDui.Text = tbl.Rows[posicion].ItemArray[4].ToString();

				lblRegistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de clientes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtNombre.Text = "";
			txtDireccion.Text = "";
			txtTelefono.Text = "";
			txtDui.Text = "";

		}
		void controles(Boolean valor)
		{
			grbNavegar.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbClientes.Enabled = !valor;
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
					lblIdCliente.Text,
					txtNombre.Text,
					txtDireccion.Text,
					txtTelefono.Text,
					txtDui.Text,
				};
				objConexion.mantenimiento_datos_Clientes(valores, accion);
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
			BuscarClientes frmBuscarClientes = new BuscarClientes();
			frmBuscarClientes.ShowDialog();

			if (frmBuscarClientes._IdCliente > 0)
			{
				posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBuscarClientes._IdCliente));
				mostrarDatos();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de elimina a " + txtNombre.Text, "Registro de clientes",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdCliente.Text };
				objConexion.mantenimiento_datos_Clientes(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnPrimero_Click_1(object sender, EventArgs e)
		{
			posicion = 0;
			mostrarDatos();
		}

		private void btnAnterior_Click_1(object sender, EventArgs e)
		{
			if (posicion > 0)
			{
				posicion--;
				mostrarDatos();
			}
			else
			{
				MessageBox.Show("Primer Registro...", "Registros de Clientes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnSiguiente_Click_1(object sender, EventArgs e)
		{
			if (posicion < tbl.Rows.Count - 1)
			{
				posicion++;
				mostrarDatos();
			}
			else
			{
				MessageBox.Show("Ultimo Registro...", "Registros de Clientes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnUltimo_Click_1(object sender, EventArgs e)
		{
			posicion = tbl.Rows.Count - 1;
			mostrarDatos();
		}
	}
}
