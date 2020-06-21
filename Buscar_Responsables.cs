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
	public partial class Buscar_Responsables : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		public int _idResponsable;
		public Buscar_Responsables()
		{
			InitializeComponent();
		}

		private void Buscar_Responsables_Load(object sender, EventArgs e)
		{
			grdBusquedaResponsables.DataSource =
			 objConexion.obtener_datos().Tables["Responsables"].DefaultView;
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaResponsables.RowCount > 0)
			{
				_idResponsable = int.Parse(grdBusquedaResponsables.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Responsables",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaResponsables.DataSource;
			bs.Filter = "Nombre_Responsables like '%" + valor + "%'";
			grdBusquedaResponsables.DataSource = bs;
		}

		

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (grdBusquedaResponsables.RowCount > 0)
            {
                _idResponsable = int.Parse(grdBusquedaResponsables.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Responsables",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscarresponsable_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscarresponsable.Text);

        }
    }
    }

