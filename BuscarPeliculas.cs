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
	public partial class BuscarPeliculas : Form
	{
		conexion_db objConexion = new conexion_db();
		public int _IdPelicula;

		public BuscarPeliculas()
		{
			InitializeComponent();
		}

		private void BuscarPeliculas_Load(object sender, EventArgs e)
		{
            grdBuscarPeliculas.DataSource =
              objConexion.obtener_datos().Tables["peliculas"].DefaultView;
        }

		private void txtbuscarPeliculas_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscarPeliculas.Text);
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBuscarPeliculas.RowCount > 0)
			{
				_IdPelicula = int.Parse(grdBuscarPeliculas.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busquedapelicula",
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
			bs.DataSource = grdBuscarPeliculas.DataSource;
            bs.Filter = "nombre like '%" + valor + "%' or duracion like '%" + valor + "%' or descripcion like '%" + valor + "%'";

            //  bs.Filter = "nombre like '%" + valor + "%' or descripcion like '%" + valor + "%' or sipnosis like '%" + valor + "%'";
            grdBuscarPeliculas.DataSource = bs;
		}

        private void grdBuscarPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
