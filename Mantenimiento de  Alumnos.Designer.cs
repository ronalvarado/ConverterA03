﻿namespace Conversor_A
{
	partial class Mantenimiento_de__Alumnos
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblIdAlumno = new System.Windows.Forms.Label();
			this.lblCódigo = new System.Windows.Forms.Label();
			this.lblAlumno = new System.Windows.Forms.Label();
			this.txtDatos = new System.Windows.Forms.TextBox();
			this.grbNavegacion = new System.Windows.Forms.GroupBox();
			this.gbrEdiciondealumnos = new System.Windows.Forms.GroupBox();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblnregistros = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.gbrEdiciondealumnos.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDatos);
			this.groupBox1.Controls.Add(this.lblAlumno);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.lblIdAlumno);
			this.groupBox1.Controls.Add(this.lblCódigo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(553, 197);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mantenimiento Alumnos ";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(66, 45);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 2;
			// 
			// lblIdAlumno
			// 
			this.lblIdAlumno.AutoSize = true;
			this.lblIdAlumno.Location = new System.Drawing.Point(172, 48);
			this.lblIdAlumno.Name = "lblIdAlumno";
			this.lblIdAlumno.Size = new System.Drawing.Size(21, 13);
			this.lblIdAlumno.TabIndex = 1;
			this.lblIdAlumno.Text = "ID:";
			// 
			// lblCódigo
			// 
			this.lblCódigo.AutoSize = true;
			this.lblCódigo.Location = new System.Drawing.Point(20, 48);
			this.lblCódigo.Name = "lblCódigo";
			this.lblCódigo.Size = new System.Drawing.Size(40, 13);
			this.lblCódigo.TabIndex = 0;
			this.lblCódigo.Text = "Código";
			// 
			// lblAlumno
			// 
			this.lblAlumno.AutoSize = true;
			this.lblAlumno.Location = new System.Drawing.Point(20, 96);
			this.lblAlumno.Name = "lblAlumno";
			this.lblAlumno.Size = new System.Drawing.Size(90, 13);
			this.lblAlumno.TabIndex = 3;
			this.lblAlumno.Text = "Datos del Alumno";
			// 
			// txtDatos
			// 
			this.txtDatos.Location = new System.Drawing.Point(116, 93);
			this.txtDatos.Multiline = true;
			this.txtDatos.Name = "txtDatos";
			this.txtDatos.Size = new System.Drawing.Size(375, 77);
			this.txtDatos.TabIndex = 4;
			// 
			// grbNavegacion
			// 
			this.grbNavegacion.Controls.Add(this.lblnregistros);
			this.grbNavegacion.Controls.Add(this.btnUltimo);
			this.grbNavegacion.Controls.Add(this.btnSiguiente);
			this.grbNavegacion.Controls.Add(this.btnAnterior);
			this.grbNavegacion.Controls.Add(this.btnPrimero);
			this.grbNavegacion.Location = new System.Drawing.Point(12, 215);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(259, 53);
			this.grbNavegacion.TabIndex = 1;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// gbrEdiciondealumnos
			// 
			this.gbrEdiciondealumnos.Controls.Add(this.btnBuscar);
			this.gbrEdiciondealumnos.Controls.Add(this.btnEliminar);
			this.gbrEdiciondealumnos.Controls.Add(this.btnModificar);
			this.gbrEdiciondealumnos.Controls.Add(this.btnNuevo);
			this.gbrEdiciondealumnos.Location = new System.Drawing.Point(306, 215);
			this.gbrEdiciondealumnos.Name = "gbrEdiciondealumnos";
			this.gbrEdiciondealumnos.Size = new System.Drawing.Size(259, 82);
			this.gbrEdiciondealumnos.TabIndex = 2;
			this.gbrEdiciondealumnos.TabStop = false;
			this.gbrEdiciondealumnos.Text = "Edición de Alumnos";
			// 
			// btnPrimero
			// 
			this.btnPrimero.Location = new System.Drawing.Point(6, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = true;
			// 
			// btnAnterior
			// 
			this.btnAnterior.Location = new System.Drawing.Point(52, 19);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 4;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = true;
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Location = new System.Drawing.Point(167, 19);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = true;
			// 
			// btnUltimo
			// 
			this.btnUltimo.Location = new System.Drawing.Point(213, 19);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 6;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(6, 19);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(87, 19);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(168, 19);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(87, 48);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(89, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// Mantenimiento_de__Alumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 311);
			this.Controls.Add(this.gbrEdiciondealumnos);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.groupBox1);
			this.Name = "Mantenimiento_de__Alumnos";
			this.Text = "Mantenimiento_de__Alumnos";
			this.Load += new System.EventHandler(this.Mantenimiento_de__Alumnos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.gbrEdiciondealumnos.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblCódigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblIdAlumno;
		private System.Windows.Forms.TextBox txtDatos;
		private System.Windows.Forms.Label lblAlumno;
		private System.Windows.Forms.GroupBox grbNavegacion;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox gbrEdiciondealumnos;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Label lblnregistros;
	}
}