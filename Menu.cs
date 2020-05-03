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

		private void btnClientes_Click(object sender, EventArgs e)
		{
			Clientes Clientes = new Clientes();

			Clientes.Show();
		}

		private void btnPeliculas_Click(object sender, EventArgs e)
		{
			Peliculas Peliculas = new Peliculas();

			Peliculas.Show();
		}

		private void btnAlquiler_Click(object sender, EventArgs e)
		{
			Alquileres Alquileres = new Alquileres();

			Alquileres.Show();
		}
	}
}
