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
	public partial class Matriculas : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public Matriculas()
		{
			InitializeComponent();
		}

		private void Matriculas_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();

		}
		void actualizarDs()
		{
			tbl = objConexion.obtener_datos().Tables["Matriculas"];
			tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdMatricula"] };
           

            cboIdAlumno.DataSource = objConexion.obtener_datos().Tables["Alumnos"];
			cboIdAlumno.DisplayMember = "Nombre_Alumno";
			cboIdAlumno.ValueMember = "Alumnos.IdAlumno";

			cboIdResponsables.DataSource = objConexion.obtener_datos().Tables["Responsables"];
			cboIdResponsables.DisplayMember = "Nombre_Responsables";
			cboIdResponsables.ValueMember = "Responsables.IdResponsables";

           

        }
		void mostrarDatos()
		{
			try
			{
				
				cboIdAlumno.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();
		
				cboIdResponsables.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();
                txtFecha.Text = tbl.Rows[posicion].ItemArray[3].ToString();

                lblIdMatricula.Text = tbl.Rows[posicion].ItemArray[0].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
			}
			catch (Exception)
			{
				MessageBox.Show("No hay Datos que mostrar", "Registros de Matricula",
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
				MessageBox.Show("Primer Registro...", "Registros de Matricula",
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
				MessageBox.Show("Ultimo Registro...", "Registros de Matricula",
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
txtFecha.Text = ""; 
            cboIdAlumno.Text = "";
            cboIdResponsables.Text = "";
        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btnEliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbMatriculas.Enabled = !valor;
            
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
					lblIdMatricula.Text,
                                        txtFecha.Text,

                    cboIdResponsables.SelectedValue.ToString(),
                    cboIdResponsables.SelectedValue.ToString(),

                };
				objConexion.mantenimiento_Matriculas(valores, accion);
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
			if (MessageBox.Show("Esta seguro de elimina a " + cboIdResponsables.Text, "Registro de Matricula",
			  MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				String[] valores = { lblIdMatricula.Text };
				objConexion.mantenimiento_Matriculas(valores, "eliminar");

				actualizarDs();
				posicion = posicion > 0 ? posicion - 1 : 0;
				mostrarDatos();
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			BuscarMatricula frmBusquedaMatriculas = new BuscarMatricula();
			frmBusquedaMatriculas.ShowDialog();

			if (frmBusquedaMatriculas._IdMatricula > 0)
			{
				posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaMatriculas._IdMatricula));
				mostrarDatos();
			}
		}
	}
}
