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
	public partial class TutorAula : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public TutorAula()
		{
			InitializeComponent();
		}

		private void TutorAula_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["TutordAula"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdAula"] };
		}
		void mostrarDatos()
		{
			try
			{
				cboIdDocente.DataSource = objConexion.obtener_datos().Tables["Docentes"];
				cboIdDocente.DisplayMember = "Docente";
				cboIdDocente.ValueMember = "Docentes.IdDocente";
				cboIdDocente.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

				lblIdAula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtCodigo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
				txtGrado.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtSeccion.Text = tbl.Rows[posicion].ItemArray[4].ToString();

				lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de Tutor Aula",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtCodigo.Text = "";
			txtGrado.Text = "";
			txtSeccion.Text = "";
		}
		void controles(Boolean valor)
		{
			grbNavegacion.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbAulas.Enabled = !valor;
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
				MessageBox.Show("Primer Registro...", "Registros de Tutor de Aula",
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
				MessageBox.Show("Ultimo Registro...", "Registros de Tutor de Aula",
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
					lblIdAula.Text,
					txtCodigo.Text,
					txtGrado.Text,
					txtSeccion.Text,
				};
				objConexion.mantenimiento_TutordAula (valores, accion);
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
			if (MessageBox.Show("Esta seguro de elimina a " + txtGrado.Text, "Registro de Matriculas",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdAula.Text };
				objConexion.mantenimiento_datos(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{

		}
	}
}
