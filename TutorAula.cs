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

			cboIdDocente.DataSource = objConexion.obtener_datos().Tables["Docentes"];
			cboIdDocente.DisplayMember = "Docente";
			cboIdDocente.ValueMember = "Docentes.IdDocente";
		}
		void mostrarDatos()
		{
			try
			{
				cboIdDocente.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

				lblIdAula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtCodigo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
				txtGrado.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtSeccion.Text = tbl.Rows[posicion].ItemArray[4].ToString();

				lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de TutordAula",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
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
				MessageBox.Show("Primer Registro...", "Registros de TutordAula",
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
				MessageBox.Show("Ultimo Registro...", "Registros de TutordAula",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			posicion = tbl.Rows.Count - 1;
			mostrarDatos();
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
                    cboIdDocente.SelectedValue.ToString(),

                    lblIdAula.Text,
					txtCodigo.Text,
					txtGrado.Text,
					txtSeccion.Text,
                };
				objConexion.mantenimiento_datos_TutordAula(valores, accion);
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
			if (MessageBox.Show("Esta seguro de elimina a " + lblIdAula.Text, "Registro de TutordAula",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { txtCodigo.Text };
				objConexion.mantenimiento_datos_TutordAula(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			BuscarTutor frmBusquedaAulas = new BuscarTutor();
			frmBusquedaAulas.ShowDialog();

			if (frmBusquedaAulas._IdAula > 0)
			{
				posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaAulas._IdAula));
				mostrarDatos();
			}
		}

		private void btnBuscarDocentes_Click(object sender, EventArgs e)
		{
			Buscar_Docentes buscarDocente = new Buscar_Docentes();
			buscarDocente.ShowDialog();

			if (buscarDocente._IdDocente > 0)
			{
				cboIdDocente.SelectedValue = buscarDocente._IdDocente;
			}
		}
	}
}
