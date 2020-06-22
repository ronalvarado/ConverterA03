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

		private void btnMateria_Click(object sender, EventArgs e)
		{
			frmMaterias frmMaterias = new frmMaterias();

			frmMaterias.Show();
		}

		private void btnGrados_Click(object sender, EventArgs e)
		{
			frmGrados frmGrados = new frmGrados();

			frmGrados.Show();
		}

		private void btnSeccion_Click(object sender, EventArgs e)
		{
			frmSecciones frmSecciones = new frmSecciones();

			frmSecciones.Show();
		}

		private void btnTrimestre_Click(object sender, EventArgs e)
		{
			frmTrimestres frmTrimestres = new frmTrimestres();

			frmTrimestres.Show();
		}

		private void btnAula_Click(object sender, EventArgs e)
		{
			frmAulas frmAulas = new frmAulas();

			frmAulas.Show();
		}

		private void btnAsistencia_Click(object sender, EventArgs e)
		{
			frmAsistencias frmAsistencias = new frmAsistencias();

			frmAsistencias.Show();
		}

		private void btnpagaDocente_Click(object sender, EventArgs e)
		{
			frmPagaDocente frmPagaDocente = new frmPagaDocente();

			frmPagaDocente.Show();
		}

		//private void btnNota_Click(object sender, EventArgs e)
		//{
		//	FrmNotas FrmNotas = new FrmNotas();

		//	FrmNotas.Show();
		//}

		private void btnTutor_Click(object sender, EventArgs e)
		{
			frmTutorAula frmTutorAula = new frmTutorAula();

			frmTutorAula.Show();
		}

		private void btnMatricula_Click(object sender, EventArgs e)
		{
			Matriculas_ matriculas_ = new Matriculas_();

			matriculas_.Show();
		}
	}
}
