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
	public partial class frmResponsables : Form
	{
		conexion_db objConexion = new conexion_db();
		int posicion = 0;
		string accion = "nuevo";
		DataTable tbl = new DataTable();

		public frmResponsables()
		{
			InitializeComponent();
		}

		private void frmResponsables_Load(object sender, EventArgs e)
		{
			actualizarDs();
			mostrarDatos();
		}
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Responsables"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idResponsable"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblIdResponsable.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtCodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtNombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtEdad.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtDireccion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtDui.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtNit.Text = tbl.Rows[posicion].ItemArray[6].ToString();
                txtTelefono.Text = tbl.Rows[posicion].ItemArray[7].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Responsables",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }
        void limpiar_cajas()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            txtNit.Text = "";
            txtTelefono.Text = "";

        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btnEliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbResponsables.Enabled = !valor;
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
                MessageBox.Show("Primer Registro...", "Registros de Responsables",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Responsables",
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
                    lblIdResponsable.Text,
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtEdad.Text,
                    txtDireccion.Text,
                    txtDui.Text,
                    txtNit.Text,
                    txtTelefono.Text,
                };
                objConexion.mantenimiento_datos_Responsables(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtNombre.Text, "Registro de Responsables",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblIdResponsable.Text };
                objConexion.mantenimiento_datos_Responsables(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }
    }
}
