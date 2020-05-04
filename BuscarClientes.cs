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
	public partial class BuscarClientes : Form
	{
		conexion_db objConexion = new conexion_db();
		public int _IdCliente;

		public BuscarClientes()
		{
			InitializeComponent();
		}

		private void txtbuscarCliente_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscarCliente.Text);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaClientes.RowCount > 0)
			{
				_IdCliente = int.Parse(grdBusquedaClientes.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaClientes.DataSource;
			bs.Filter = "nombre like '%" + valor + "%' or direccion like '%" + valor + "%' or telefono like '%" + valor + "%'";
			grdBusquedaClientes.DataSource = bs;
		}

	
        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            grdBusquedaClientes.DataSource =
              objConexion.obtener_datos().Tables["clientes"].DefaultView;
        }
    }
}
