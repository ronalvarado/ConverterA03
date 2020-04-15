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
	public partial class Busqueda_Alumnos : Form
	{
		Conexion_BD objConexion = new Conexion_BD();
		public int _IdAlumno;
		public Busqueda_Alumnos()
		{
			InitializeComponent();
		}

		private void Busqueda_Alumnos_Load(object sender, EventArgs e)
		{
			grdBusquedaAlumnos.DataSource =
			   objConexion.obtener_datos().Tables["Alumnos"].DefaultView;
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			if (grdBusquedaAlumnos.RowCount > 0)
			{
				_IdAlumno = int.Parse(grdBusquedaAlumnos.CurrentRow.Cells[0].Value.ToString());
				Close();
			}
			else
			{
				MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Alumnos",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void filtrar_datos(String valor)
		{
			BindingSource bs = new BindingSource();
			bs.DataSource = grdBusquedaAlumnos.DataSource;
			bs.Filter = "Nombre_Alumno like '%" + valor + "%'";
			grdBusquedaAlumnos.DataSource = bs;
		}

		private void txtbuscar_TextChanged(object sender, EventArgs e)
		{
			filtrar_datos(txtbuscar.Text);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
