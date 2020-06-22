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
	public partial class Matriculas_ : Form
	{
		public Matriculas_()
		{
			InitializeComponent();
		}

		private void Matriculas__Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'baseEscuelaDataSet.dMatriculas' Puede moverla o quitarla según sea necesario.
			this.dMatriculasTableAdapter.FillsMatriculas(this.baseEscuelaDataSet.dMatriculas);

		}
	}
}
