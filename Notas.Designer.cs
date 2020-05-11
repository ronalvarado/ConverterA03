namespace Conversor_A
{
	partial class Notas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
			this.grbEdiciondeNotas = new System.Windows.Forms.GroupBox();
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
			this.grbNota = new System.Windows.Forms.GroupBox();
			this.btnHacer = new System.Windows.Forms.Button();
			this.lblAct2 = new System.Windows.Forms.Label();
			this.txtNota = new System.Windows.Forms.TextBox();
			this.lblNota = new System.Windows.Forms.Label();
			this.txtActividad2 = new System.Windows.Forms.TextBox();
			this.txtActividad1 = new System.Windows.Forms.TextBox();
			this.lblExam = new System.Windows.Forms.Label();
			this.cboIdMateria = new System.Windows.Forms.ComboBox();
			this.cboIdAlumno = new System.Windows.Forms.ComboBox();
			this.txtExamen = new System.Windows.Forms.TextBox();
			this.lblAct1 = new System.Windows.Forms.Label();
			this.lblIdMaterias = new System.Windows.Forms.Label();
			this.lblIdNota = new System.Windows.Forms.Label();
			this.lblIdAlumno = new System.Windows.Forms.Label();
			this.grbEdiciondeNotas.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbNota.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdiciondeNotas
			// 
			this.grbEdiciondeNotas.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeNotas.Controls.Add(this.btnBuscar);
			this.grbEdiciondeNotas.Controls.Add(this.btnEliminar);
			this.grbEdiciondeNotas.Controls.Add(this.btnModificar);
			this.grbEdiciondeNotas.Controls.Add(this.btnNuevo);
			this.grbEdiciondeNotas.ForeColor = System.Drawing.Color.White;
			this.grbEdiciondeNotas.Location = new System.Drawing.Point(575, 12);
			this.grbEdiciondeNotas.Name = "grbEdiciondeNotas";
			this.grbEdiciondeNotas.Size = new System.Drawing.Size(86, 277);
			this.grbEdiciondeNotas.TabIndex = 11;
			this.grbEdiciondeNotas.TabStop = false;
			this.grbEdiciondeNotas.Text = "Edición de Notas";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnBuscar.Location = new System.Drawing.Point(5, 177);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnEliminar.Location = new System.Drawing.Point(5, 238);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnModificar.Location = new System.Drawing.Point(5, 115);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnNuevo.ForeColor = System.Drawing.Color.White;
			this.btnNuevo.Location = new System.Drawing.Point(5, 57);
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
			this.grbNavegacion.Location = new System.Drawing.Point(12, 236);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(557, 53);
			this.grbNavegacion.TabIndex = 10;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(277, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Brown;
			this.btnUltimo.Location = new System.Drawing.Point(468, 19);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 6;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Brown;
			this.btnSiguiente.Location = new System.Drawing.Point(380, 19);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Brown;
			this.btnAnterior.Location = new System.Drawing.Point(145, 19);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 4;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.Brown;
			this.btnPrimero.Location = new System.Drawing.Point(36, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbNota
			// 
			this.grbNota.BackColor = System.Drawing.Color.Transparent;
			this.grbNota.Controls.Add(this.btnHacer);
			this.grbNota.Controls.Add(this.lblAct2);
			this.grbNota.Controls.Add(this.txtNota);
			this.grbNota.Controls.Add(this.lblNota);
			this.grbNota.Controls.Add(this.txtActividad2);
			this.grbNota.Controls.Add(this.txtActividad1);
			this.grbNota.Controls.Add(this.lblExam);
			this.grbNota.Controls.Add(this.cboIdMateria);
			this.grbNota.Controls.Add(this.cboIdAlumno);
			this.grbNota.Controls.Add(this.txtExamen);
			this.grbNota.Controls.Add(this.lblAct1);
			this.grbNota.Controls.Add(this.lblIdMaterias);
			this.grbNota.Controls.Add(this.lblIdNota);
			this.grbNota.Controls.Add(this.lblIdAlumno);
			this.grbNota.Enabled = false;
			this.grbNota.ForeColor = System.Drawing.Color.White;
			this.grbNota.Location = new System.Drawing.Point(12, 12);
			this.grbNota.Name = "grbNota";
			this.grbNota.Size = new System.Drawing.Size(557, 218);
			this.grbNota.TabIndex = 9;
			this.grbNota.TabStop = false;
			this.grbNota.Text = "Mantenimiento Notas";
			// 
			// btnHacer
			// 
			this.btnHacer.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnHacer.Location = new System.Drawing.Point(298, 172);
			this.btnHacer.Name = "btnHacer";
			this.btnHacer.Size = new System.Drawing.Size(75, 23);
			this.btnHacer.TabIndex = 16;
			this.btnHacer.Text = "Hacer";
			this.btnHacer.UseVisualStyleBackColor = false;
			this.btnHacer.Click += new System.EventHandler(this.btnHacer_Click);
			// 
			// lblAct2
			// 
			this.lblAct2.AutoSize = true;
			this.lblAct2.Location = new System.Drawing.Point(13, 151);
			this.lblAct2.Name = "lblAct2";
			this.lblAct2.Size = new System.Drawing.Size(60, 13);
			this.lblAct2.TabIndex = 15;
			this.lblAct2.Text = "Actividad2:";
			// 
			// txtNota
			// 
			this.txtNota.Location = new System.Drawing.Point(98, 174);
			this.txtNota.Name = "txtNota";
			this.txtNota.Size = new System.Drawing.Size(170, 20);
			this.txtNota.TabIndex = 14;
			// 
			// lblNota
			// 
			this.lblNota.AutoSize = true;
			this.lblNota.Location = new System.Drawing.Point(17, 177);
			this.lblNota.Name = "lblNota";
			this.lblNota.Size = new System.Drawing.Size(33, 13);
			this.lblNota.TabIndex = 13;
			this.lblNota.Text = "Nota:";
			// 
			// txtActividad2
			// 
			this.txtActividad2.Location = new System.Drawing.Point(98, 148);
			this.txtActividad2.Name = "txtActividad2";
			this.txtActividad2.Size = new System.Drawing.Size(170, 20);
			this.txtActividad2.TabIndex = 12;
			// 
			// txtActividad1
			// 
			this.txtActividad1.Location = new System.Drawing.Point(98, 122);
			this.txtActividad1.Name = "txtActividad1";
			this.txtActividad1.Size = new System.Drawing.Size(170, 20);
			this.txtActividad1.TabIndex = 10;
			// 
			// lblExam
			// 
			this.lblExam.AutoSize = true;
			this.lblExam.Location = new System.Drawing.Point(22, 99);
			this.lblExam.Name = "lblExam";
			this.lblExam.Size = new System.Drawing.Size(48, 13);
			this.lblExam.TabIndex = 9;
			this.lblExam.Text = "Examen:";
			// 
			// cboIdMateria
			// 
			this.cboIdMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboIdMateria.FormattingEnabled = true;
			this.cboIdMateria.Location = new System.Drawing.Point(98, 62);
			this.cboIdMateria.Name = "cboIdMateria";
			this.cboIdMateria.Size = new System.Drawing.Size(298, 21);
			this.cboIdMateria.TabIndex = 8;
			// 
			// cboIdAlumno
			// 
			this.cboIdAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboIdAlumno.FormattingEnabled = true;
			this.cboIdAlumno.Location = new System.Drawing.Point(98, 35);
			this.cboIdAlumno.Name = "cboIdAlumno";
			this.cboIdAlumno.Size = new System.Drawing.Size(298, 21);
			this.cboIdAlumno.TabIndex = 7;
			// 
			// txtExamen
			// 
			this.txtExamen.Location = new System.Drawing.Point(98, 96);
			this.txtExamen.Name = "txtExamen";
			this.txtExamen.Size = new System.Drawing.Size(170, 20);
			this.txtExamen.TabIndex = 6;
			// 
			// lblAct1
			// 
			this.lblAct1.AutoSize = true;
			this.lblAct1.Location = new System.Drawing.Point(13, 125);
			this.lblAct1.Name = "lblAct1";
			this.lblAct1.Size = new System.Drawing.Size(57, 13);
			this.lblAct1.TabIndex = 5;
			this.lblAct1.Text = "Actividad1";
			// 
			// lblIdMaterias
			// 
			this.lblIdMaterias.AutoSize = true;
			this.lblIdMaterias.Location = new System.Drawing.Point(20, 67);
			this.lblIdMaterias.Name = "lblIdMaterias";
			this.lblIdMaterias.Size = new System.Drawing.Size(50, 13);
			this.lblIdMaterias.TabIndex = 3;
			this.lblIdMaterias.Text = "Materias:";
			// 
			// lblIdNota
			// 
			this.lblIdNota.AutoSize = true;
			this.lblIdNota.Location = new System.Drawing.Point(411, 38);
			this.lblIdNota.Name = "lblIdNota";
			this.lblIdNota.Size = new System.Drawing.Size(21, 13);
			this.lblIdNota.TabIndex = 1;
			this.lblIdNota.Text = "ID:";
			// 
			// lblIdAlumno
			// 
			this.lblIdAlumno.AutoSize = true;
			this.lblIdAlumno.Location = new System.Drawing.Point(20, 38);
			this.lblIdAlumno.Name = "lblIdAlumno";
			this.lblIdAlumno.Size = new System.Drawing.Size(45, 13);
			this.lblIdAlumno.TabIndex = 0;
			this.lblIdAlumno.Text = "Alumno:";
			// 
			// Notas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(671, 301);
			this.Controls.Add(this.grbEdiciondeNotas);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbNota);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "Notas";
			this.Text = "Notas";
			this.Load += new System.EventHandler(this.Notas_Load);
			this.grbEdiciondeNotas.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbNota.ResumeLayout(false);
			this.grbNota.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdiciondeNotas;
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
		private System.Windows.Forms.GroupBox grbNota;
		private System.Windows.Forms.Label lblAct2;
		private System.Windows.Forms.TextBox txtNota;
		private System.Windows.Forms.Label lblNota;
		private System.Windows.Forms.TextBox txtActividad2;
		private System.Windows.Forms.TextBox txtActividad1;
		private System.Windows.Forms.Label lblExam;
		private System.Windows.Forms.ComboBox cboIdMateria;
		private System.Windows.Forms.ComboBox cboIdAlumno;
		private System.Windows.Forms.TextBox txtExamen;
		private System.Windows.Forms.Label lblAct1;
		private System.Windows.Forms.Label lblIdMaterias;
		private System.Windows.Forms.Label lblIdNota;
		private System.Windows.Forms.Label lblIdAlumno;
		private System.Windows.Forms.Button btnHacer;
	}
}