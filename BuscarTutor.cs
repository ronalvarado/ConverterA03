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
	public partial class BuscarTutor : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		public int _IdAula;
		public BuscarTutor()
		{
			InitializeComponent();
		}

		private void BuscarTutor_Load(object sender, EventArgs e)
		{
			grdBusquedaAulas.DataSource =
			   objConexion.obtener_datos().Tables["TutordAula"].DefaultView;
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscar.Text);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaAulas.RowCount > 0)
			{
				_IdAula = int.Parse(grdBusquedaAulas.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Aulas",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaAulas.DataSource;
			bs.Filter = "Grado like '%" + valor + "%' or Seccion like '%" + valor + "%'";
			grdBusquedaAulas.DataSource = bs;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
