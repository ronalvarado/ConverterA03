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
	public partial class Notas : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public Notas()
		{
			InitializeComponent();
		}

		private void Notas_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["Notas"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdNota"] };

			cboIdAlumno.DataSource = objConexion.obtener_datos().Tables["Alumnos"];
			cboIdAlumno.DisplayMember = "Nombre_Alumno";
			cboIdAlumno.ValueMember = "Alumnos.IdAlumno";

			cboIdMateria.DataSource = objConexion.obtener_datos().Tables["Materias"];
			cboIdMateria.DisplayMember = "Nombre_Materia";
			cboIdMateria.ValueMember = "Materias.IdMateria";

		}
		void mostrarDatos()
		{
			try
			{

				cboIdAlumno.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

				cboIdMateria.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();

				lblIdNota.Text = tbl.Rows[posicion].ItemArray[0].ToString();
				txtExamen.Text = tbl.Rows[posicion].ItemArray[3].ToString();
				txtActividad1.Text = tbl.Rows[posicion].ItemArray[4].ToString();
				txtActividad2.Text = tbl.Rows[posicion].ItemArray[5].ToString();
				txtNota.Text = tbl.Rows[posicion].ItemArray[6].ToString();

				lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de Asistencia",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				limpiar_cajas();
			}
		}
		void limpiar_cajas()
		{
			txtExamen.Text = "";
			txtActividad1.Text = "";
			txtActividad2.Text = "";
			txtNota.Text = "";
		}
		void controles(Boolean valor)
		{
			grbNavegacion.Enabled = valor;
			btnEliminar.Enabled = valor;
			btnBuscar.Enabled = valor;
			grbNota.Enabled = !valor;
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
				MessageBox.Show("Primer Registro...", "Registros de Notas",
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
				MessageBox.Show("Ultimo Registro...", "Registros de Notas",
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
					lblIdNota.Text,
					cboIdAlumno.SelectedValue.ToString(),
					cboIdMateria.SelectedValue.ToString(),
					txtExamen.Text,
					txtActividad1.Text,
					txtActividad2.Text,
					txtNota.Text,
					
			};
				objConexion.mantenimiento_datos_Notas(valores, accion);
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
			if (MessageBox.Show("Esta seguro de elimina a " + cboIdAlumno.Text, "Registro de Notas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdNota.Text };
				objConexion.mantenimiento_datos_Notas(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnHacer_Click(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtExamen.Text);
			double num2 = double.Parse(txtActividad1.Text);
			double num3 = double.Parse(txtActividad2.Text);
			double r1 = 0;
			double r2 = 0;
			double r3 = 0;
			double resp = 0;
				r1 = num1 * 0.30;
				r2 = num2 * 0.35;
				r3 = num3 * 0.35;
				resp = r1 + r2 + r3;
			(txtNota.Text) = "" + resp;
		}
	}
}
