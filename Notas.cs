﻿using System;
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
	public partial class Notas : Form
	{
		public Notas()
		{
			InitializeComponent();
		}

		private void Notas_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'proyectoEscuela_DataSet.Notas' Puede moverla o quitarla según sea necesario.
			this.notasTableAdapter.FillNota(this.proyectoEscuela_DataSet.Notas);

		}
	}
}

