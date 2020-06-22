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
	public partial class frmTutorAula : Form
	{
		public frmTutorAula()
		{
			InitializeComponent();
		}

		private void frmTutorAula_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'baseEscuelaDataSet.TutorAula' Puede moverla o quitarla según sea necesario.
			this.tutorAulaTableAdapter.FillTutorAula(this.baseEscuelaDataSet.TutorAula);

		}
	}
}
