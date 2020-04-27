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
	public partial class BuscarMatricula : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		public int _IdMatricula;
		public BuscarMatricula()
		{
			InitializeComponent();
		}

		private void BuscarMatricula_Load(object sender, EventArgs e)
		{
			grdBusquedaMatriculas.DataSource =
			   objConexion.obtener_datos().Tables["Matriculas"].DefaultView;
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscar.Text);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaMatriculas.RowCount > 0)
			{
				_IdMatricula = int.Parse(grdBusquedaMatriculas.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Matriculas",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaMatriculas.DataSource;
			bs.Filter = "Nombre_Alumno like '%" + valor + "%' or Fecha like '%" + valor + "%'";
			grdBusquedaMatriculas.DataSource = bs;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
