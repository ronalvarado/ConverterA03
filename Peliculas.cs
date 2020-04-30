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
	public partial class Peliculas : Form
	{
		Conexion_db objConexion = new Conexion_db();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public Peliculas()
		{
			InitializeComponent();
		}

		private void Peliculas_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["peliculas"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdPelicula"] };
		}
		void mostrarDatos()
		{
			try
			{
				lblIdPelicula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtNombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();
				txtDescripcion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
				txtSipnosis.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtGenero.Text = tbl.Rows[posicion].ItemArray[4].ToString();
				txtDuracion.Text = tbl.Rows[posicion].ItemArray[5].ToString();
				lblRegistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de peliculas",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtNombre.Text = "";
			txtDescripcion.Text = "";
			txtSipnosis.Text = "";
			txtGenero.Text = "";
			txtDuracion.Text = "";

		}
		void controles(Boolean valor)
		{
			grbNavegar.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbPeliculas.Enabled = !valor;
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
				MessageBox.Show("Primer Registro...", "Registros de Peliculas",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			posicion = tbl.Rows.Count - 1;
			mostrarDatos();
		}

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			if (posicion < tbl.Rows.Count - 1)
			{
				posicion++;
				mostrarDatos();
			}
			else
			{
				MessageBox.Show("Ultimo Registro...", "Registros de Peliculas",
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
					lblIdPelicula.Text,
					txtNombre.Text,
					txtDescripcion.Text,
					txtSipnosis.Text,
					txtGenero.Text,
					txtDuracion.Text,
				};
				objConexion.mantenimiento_datos_Peliculas(valores, accion);
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
			BuscarPeliculas frmBuscarPeliculas = new BuscarPeliculas();
			frmBuscarPeliculas.ShowDialog();

			if (frmBuscarPeliculas._IdPelicula > 0)
			{
				posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBuscarPeliculas._IdPelicula));
				mostrarDatos();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de elimina a " + txtNombre.Text, "Registro de Peliculas",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdPelicula.Text };
				objConexion.mantenimiento_datos_Peliculas(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos(); 
			}
		}
	}
}
 //001