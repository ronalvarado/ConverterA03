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
	public partial class frmANotas : Form
	{
		public frmANotas()
		{
			InitializeComponent();
		}

		private void frmANotas_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'baseEscuelaDataSet.ANotas' Puede moverla o quitarla según sea necesario.
			this.aNotasTableAdapter.FillANotas(this.baseEscuelaDataSet.ANotas);

		}
	}
}
