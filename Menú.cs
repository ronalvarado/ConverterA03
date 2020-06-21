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
	public partial class Menú : Form
	{
		public Menú()
		{
			InitializeComponent();
		}

		private void btnAlumno_Click(object sender, EventArgs e)
		{
			frmAlumnos frmAlumnos = new frmAlumnos();

			frmAlumnos.Show();
		}

		private void btnResponsable_Click(object sender, EventArgs e)
		{
			frmResponsables frmResponsables = new frmResponsables();

			frmResponsables.Show();
		}

		private void btnDocente_Click(object sender, EventArgs e)
		{
			frmDocentes frmDocentes = new frmDocentes();

			frmDocentes.Show();
		}
	}
}
