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
	public partial class Mensu : Form
	{
		public Mensu()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			frmAlumnos frmAlumnos = new frmAlumnos();

			frmAlumnos.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			frmResponsables frmResponsables = new frmResponsables();

			frmResponsables.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Matriculas_ matriculas_ = new Matriculas_();

			matriculas_.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			frmAsistencias frmAsistencias = new frmAsistencias();

			frmAsistencias.Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			frmANotas frmANotas = new frmANotas();

			frmANotas.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			frmDocentes frmDocentes = new frmDocentes();

			frmDocentes.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			frmPagaDocente frmPagaDocente = new frmPagaDocente();

			frmPagaDocente.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			frmMaterias frmMaterias = new frmMaterias();

			frmMaterias.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frmTutorAula frmTutorAula = new frmTutorAula();

			frmTutorAula.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			frmeNots frmeNots = new frmeNots();

			frmeNots.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmGrados frmGrados = new frmGrados();

			frmGrados.Show();
		}
	}
}
