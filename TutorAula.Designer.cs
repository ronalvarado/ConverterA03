﻿namespace Conversor_A
{
	partial class TutorAula
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorAula));
			this.grbEdiciondeTutorAula = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbNavegacion = new System.Windows.Forms.GroupBox();
			this.lblnregistros = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbAulas = new System.Windows.Forms.GroupBox();
			this.btnBuscarDocentes = new System.Windows.Forms.Button();
			this.txtSeccion = new System.Windows.Forms.TextBox();
			this.lblSeccion = new System.Windows.Forms.Label();
			this.txtGrado = new System.Windows.Forms.TextBox();
			this.lblGrado = new System.Windows.Forms.Label();
			this.cboIdDocente = new System.Windows.Forms.ComboBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblIdAula = new System.Windows.Forms.Label();
			this.lblIdDocente = new System.Windows.Forms.Label();
			this.grbEdiciondeTutorAula.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbAulas.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdiciondeTutorAula
			// 
			this.grbEdiciondeTutorAula.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeTutorAula.Controls.Add(this.btnBuscar);
			this.grbEdiciondeTutorAula.Controls.Add(this.btnEliminar);
			this.grbEdiciondeTutorAula.Controls.Add(this.btnModificar);
			this.grbEdiciondeTutorAula.Controls.Add(this.btnNuevo);
			this.grbEdiciondeTutorAula.ForeColor = System.Drawing.Color.White;
			this.grbEdiciondeTutorAula.Location = new System.Drawing.Point(575, 12);
			this.grbEdiciondeTutorAula.Name = "grbEdiciondeTutorAula";
			this.grbEdiciondeTutorAula.Size = new System.Drawing.Size(88, 236);
			this.grbEdiciondeTutorAula.TabIndex = 11;
			this.grbEdiciondeTutorAula.TabStop = false;
			this.grbEdiciondeTutorAula.Text = "Edición de Tutor de Aula";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnBuscar.Location = new System.Drawing.Point(6, 132);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnEliminar.Location = new System.Drawing.Point(6, 183);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnModificar.Location = new System.Drawing.Point(6, 80);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnNuevo.Location = new System.Drawing.Point(6, 35);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// grbNavegacion
			// 
			this.grbNavegacion.BackColor = System.Drawing.Color.Transparent;
			this.grbNavegacion.Controls.Add(this.lblnregistros);
			this.grbNavegacion.Controls.Add(this.btnUltimo);
			this.grbNavegacion.Controls.Add(this.btnSiguiente);
			this.grbNavegacion.Controls.Add(this.btnAnterior);
			this.grbNavegacion.Controls.Add(this.btnPrimero);
			this.grbNavegacion.ForeColor = System.Drawing.Color.White;
			this.grbNavegacion.Location = new System.Drawing.Point(12, 195);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(557, 53);
			this.grbNavegacion.TabIndex = 10;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(268, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Maroon;
			this.btnUltimo.Location = new System.Drawing.Point(466, 19);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 6;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Maroon;
			this.btnSiguiente.Location = new System.Drawing.Point(356, 19);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Maroon;
			this.btnAnterior.Location = new System.Drawing.Point(144, 19);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 4;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.Maroon;
			this.btnPrimero.ForeColor = System.Drawing.Color.White;
			this.btnPrimero.Location = new System.Drawing.Point(45, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbAulas
			// 
			this.grbAulas.BackColor = System.Drawing.Color.Transparent;
			this.grbAulas.Controls.Add(this.btnBuscarDocentes);
			this.grbAulas.Controls.Add(this.txtSeccion);
			this.grbAulas.Controls.Add(this.lblSeccion);
			this.grbAulas.Controls.Add(this.txtGrado);
			this.grbAulas.Controls.Add(this.lblGrado);
			this.grbAulas.Controls.Add(this.cboIdDocente);
			this.grbAulas.Controls.Add(this.txtCodigo);
			this.grbAulas.Controls.Add(this.lblCodigo);
			this.grbAulas.Controls.Add(this.lblIdAula);
			this.grbAulas.Controls.Add(this.lblIdDocente);
			this.grbAulas.Enabled = false;
			this.grbAulas.ForeColor = System.Drawing.Color.White;
			this.grbAulas.Location = new System.Drawing.Point(12, 12);
			this.grbAulas.Name = "grbAulas";
			this.grbAulas.Size = new System.Drawing.Size(557, 177);
			this.grbAulas.TabIndex = 9;
			this.grbAulas.TabStop = false;
			this.grbAulas.Text = "Mantenimiento Tutor de Aulas";
			// 
			// btnBuscarDocentes
			// 
			this.btnBuscarDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnBuscarDocentes.Location = new System.Drawing.Point(402, 35);
			this.btnBuscarDocentes.Name = "btnBuscarDocentes";
			this.btnBuscarDocentes.Size = new System.Drawing.Size(75, 23);
			this.btnBuscarDocentes.TabIndex = 12;
			this.btnBuscarDocentes.Text = "Buscar Docentes";
			this.btnBuscarDocentes.UseVisualStyleBackColor = false;
			this.btnBuscarDocentes.Click += new System.EventHandler(this.btnBuscarDocentes_Click);
			// 
			// txtSeccion
			// 
			this.txtSeccion.Location = new System.Drawing.Point(98, 129);
			this.txtSeccion.Name = "txtSeccion";
			this.txtSeccion.Size = new System.Drawing.Size(170, 20);
			this.txtSeccion.TabIndex = 11;
			// 
			// lblSeccion
			// 
			this.lblSeccion.AutoSize = true;
			this.lblSeccion.Location = new System.Drawing.Point(20, 132);
			this.lblSeccion.Name = "lblSeccion";
			this.lblSeccion.Size = new System.Drawing.Size(49, 13);
			this.lblSeccion.TabIndex = 10;
			this.lblSeccion.Text = "Sección:";
			// 
			// txtGrado
			// 
			this.txtGrado.Location = new System.Drawing.Point(98, 103);
			this.txtGrado.Name = "txtGrado";
			this.txtGrado.Size = new System.Drawing.Size(170, 20);
			this.txtGrado.TabIndex = 9;
			// 
			// lblGrado
			// 
			this.lblGrado.AutoSize = true;
			this.lblGrado.Location = new System.Drawing.Point(20, 106);
			this.lblGrado.Name = "lblGrado";
			this.lblGrado.Size = new System.Drawing.Size(39, 13);
			this.lblGrado.TabIndex = 8;
			this.lblGrado.Text = "Grado:";
			// 
			// cboIdDocente
			// 
			this.cboIdDocente.FormattingEnabled = true;
			this.cboIdDocente.Location = new System.Drawing.Point(98, 35);
			this.cboIdDocente.Name = "cboIdDocente";
			this.cboIdDocente.Size = new System.Drawing.Size(298, 21);
			this.cboIdDocente.TabIndex = 7;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(98, 77);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(170, 20);
			this.txtCodigo.TabIndex = 6;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(20, 80);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(43, 13);
			this.lblCodigo.TabIndex = 5;
			this.lblCodigo.Text = "Código:";
			// 
			// lblIdAula
			// 
			this.lblIdAula.AutoSize = true;
			this.lblIdAula.Location = new System.Drawing.Point(397, 80);
			this.lblIdAula.Name = "lblIdAula";
			this.lblIdAula.Size = new System.Drawing.Size(21, 13);
			this.lblIdAula.TabIndex = 1;
			this.lblIdAula.Text = "ID:";
			// 
			// lblIdDocente
			// 
			this.lblIdDocente.AutoSize = true;
			this.lblIdDocente.Location = new System.Drawing.Point(20, 38);
			this.lblIdDocente.Name = "lblIdDocente";
			this.lblIdDocente.Size = new System.Drawing.Size(51, 13);
			this.lblIdDocente.TabIndex = 0;
			this.lblIdDocente.Text = "Docente:";
			// 
			// TutorAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(676, 256);
			this.Controls.Add(this.grbEdiciondeTutorAula);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbAulas);
			this.Name = "TutorAula";
			this.Text = "TutorAula";
			this.Load += new System.EventHandler(this.TutorAula_Load);
			this.grbEdiciondeTutorAula.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbAulas.ResumeLayout(false);
			this.grbAulas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdiciondeTutorAula;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox grbNavegacion;
		private System.Windows.Forms.Label lblnregistros;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox grbAulas;
		private System.Windows.Forms.ComboBox cboIdDocente;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblIdAula;
		private System.Windows.Forms.Label lblIdDocente;
		private System.Windows.Forms.TextBox txtSeccion;
		private System.Windows.Forms.Label lblSeccion;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.Label lblGrado;
		private System.Windows.Forms.Button btnBuscarDocentes;
	}
}