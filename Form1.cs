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
	public partial class Form1 : Form
	{
		convertir objconvertir = new convertir();
		public Form1()
		{
			InitializeComponent();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbxtipo.Items.AddRange(objconvertir.Tipo);
			cbxtipo.SelectedIndex = 0;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void cbxtipo_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbxde.Items.Clear();
			cbxa.Items.Clear();
			cbxde.Items.AddRange(objconvertir.Versiones[cbxtipo.SelectedIndex]);
			cbxa.Items.AddRange(objconvertir.Versiones[cbxtipo.SelectedIndex]);
			cbxde.SelectedIndex = 0;
			cbxa.SelectedIndex = 1;
			lblresultado.Text = "?";
			txtconvertir.Text = "0";
		}

		private void btnaconvertir_Click(object sender, EventArgs e)
		{
			try
			{
				lblresultado.Text = "Valor: " + objconvertir.convert (cbxde.SelectedIndex, cbxa.SelectedIndex, double.Parse(txtconvertir.Text), cbxtipo.SelectedIndex) + " " + objconvertir.Versiones[cbxtipo.SelectedIndex][cbxa.SelectedIndex];
			}
			catch (Exception error)
			{
				MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
