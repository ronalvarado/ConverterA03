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
    }
}
