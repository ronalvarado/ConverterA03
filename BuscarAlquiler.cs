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
    public partial class BuscarAlquiler : Form
    {
        conexion_db objConexion = new conexion_db();
        public int _IdAlquiler;
        public BuscarAlquiler()
        {
            InitializeComponent();
        }

        private void BuscarAlquiler_Load(object sender, EventArgs e)
        {
            grdBusquedaAlquiler.DataSource =
             objConexion.obtener_datos().Tables["clientes_peliculas_alquiler"].DefaultView;
        }

        private void txtbuscarCliente_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscarCliente.Text);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaAlquiler.RowCount > 0)
            {
                _IdAlquiler = int.Parse(grdBusquedaAlquiler.CurrentRow.Cells["IdAlquiler"].Value.ToString());

                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void filtrar_datos(String valor)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = grdBusquedaAlquiler.DataSource;
                bs.Filter = "  nombre like '%" + valor + "%' or fechaPrestamo like '%" + valor + "%' or fechaDevolucion like '%" + valor + "%' or valor like '%" + valor + "%'";
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
