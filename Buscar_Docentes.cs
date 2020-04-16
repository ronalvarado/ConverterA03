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
	public partial class Buscar_Docentes : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		public int _IdDocente;
		public Buscar_Docentes()
		{
			InitializeComponent();
		}

	

		private void Buscar_Docentes_Load(object sender, EventArgs e)
		{
			grdBusquedaDocentes.DataSource =
		 objConexion.obtener_datos().Tables["Docentes"].DefaultView;
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaDocentes.RowCount > 0)
			{
				_IdDocente = int.Parse(grdBusquedaDocentes.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Docentes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaDocentes.DataSource;
			bs.Filter = "Docente like '%" + valor + "%'";
			grdBusquedaDocentes.DataSource = bs;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtbuscarDocente_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscarDocente.Text);
		}
	}
}
