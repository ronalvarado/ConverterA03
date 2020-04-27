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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Mantenimiento_de__Alumnos Mantenimiento_de__Alumnos = new Mantenimiento_de__Alumnos();

            Mantenimiento_de__Alumnos.Show();
        }

        private void btnResponsables_Click(object sender, EventArgs e)
        {
            Mantenimiento_de__Responsables Mantenimiento_de__Responsables = new Mantenimiento_de__Responsables();

            Mantenimiento_de__Responsables.Show();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            Mantenimiento_Docentes Mantenimiento_Docentes = new Mantenimiento_Docentes();

            Mantenimiento_Docentes.Show();
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            Matriculas Matriculas = new Matriculas();

            Matriculas.Show();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            TutorAula TutorAula = new TutorAula();

            TutorAula.Show();
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            Meses Meses = new Meses();

            Meses.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias Materias = new Materias();
            Materias.Show();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            Asistencias Asistencias = new Asistencias();

            Asistencias.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            Notas Notas = new Notas();

            Notas.Show();
        }
    }
}
