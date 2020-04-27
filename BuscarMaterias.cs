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
	public partial class BuscarMaterias : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		public int _IdMateria;
		public BuscarMaterias()
		{
			InitializeComponent();
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscar.Text);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaMaterias.RowCount > 0)
			{
				_IdMateria = int.Parse(grdBusquedaMaterias.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Materias",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaMaterias.DataSource;
			bs.Filter = "Nombre_Materia like '%" + valor + "%'";
			grdBusquedaMaterias.DataSource = bs;
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BuscarMaterias_Load(object sender, EventArgs e)
		{
			grdBusquedaMaterias.DataSource =
			   objConexion.obtener_datos().Tables["Materias"].DefaultView;
		}
	}
}
