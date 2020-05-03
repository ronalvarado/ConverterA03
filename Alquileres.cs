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

	public partial class Alquileres : Form
	{
		conexion_db objConexion = new conexion_db();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public Alquileres()
		{
			InitializeComponent();
		}

		private void Alquileres_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["alquiler"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdAlquiler"] };

			cboIdCliente.DataSource = objConexion.obtener_datos().Tables["clientes"];
			cboIdCliente.DisplayMember = "nombre";
			cboIdCliente.ValueMember = "clientes.IdCliente";

			cboIdPelicula.DataSource = objConexion.obtener_datos().Tables["peliculas"];
			cboIdPelicula.DisplayMember = "nombre";
			cboIdPelicula.ValueMember = "peliculas.IdPelicula";
		}
		void mostrarDatos()
		{
			try
			{

				cboIdCliente.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

				cboIdPelicula.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();

				lblIdAlquiler.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtFPrestamo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtFDevolucion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
				txtValor.Text = tbl.Rows[posicion].ItemArray[5].ToString();
				lblRegistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
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
			cboIdCliente.Text = "";
			cboIdPelicula.Text = "";
			txtFPrestamo.Text = "";
			txtFDevolucion .Text = "";
			txtValor.Text = "";

		}
		void controles(Boolean valor)
		{
			grbNavegar.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbAlquileres.Enabled = !valor;
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
				MessageBox.Show("Primer Registro...", "Registros de Alquiler",
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
				MessageBox.Show("Ultimo Registro...", "Registros de Alquiler",
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

					cboIdCliente.SelectedValue.ToString(),
					cboIdPelicula.SelectedValue.ToString(),
					txtFPrestamo.Text,
					txtFDevolucion.Text,
					txtValor.Text,
				};
				objConexion.mantenimiento_datos_Alquiler(valores, accion);
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
			if (MessageBox.Show("Esta seguro de elimina a " + cboIdCliente.Text, "Registro de Alquiler",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdAlquiler.Text };
				objConexion.mantenimiento_datos_Alquiler(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			BuscarClientes buscarClientes = new BuscarClientes();
			buscarClientes.ShowDialog();

			if (buscarClientes._IdCliente > 0)
			{
				cboIdCliente.SelectedValue = buscarClientes._IdCliente;
			}
		}
	}
}
