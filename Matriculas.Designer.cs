namespace Conversor_A
{
	partial class Matriculas
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
			this.grbEdiciondeMatriculas = new System.Windows.Forms.GroupBox();
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
			this.grbMatriculas = new System.Windows.Forms.GroupBox();
			this.cboIdResponsables = new System.Windows.Forms.ComboBox();
			this.cboIdAlumno = new System.Windows.Forms.ComboBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblIdResponsables = new System.Windows.Forms.Label();
			this.lblIdMatricula = new System.Windows.Forms.Label();
			this.lblIdAlumno = new System.Windows.Forms.Label();
			this.grbEdiciondeMatriculas.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbMatriculas.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdiciondeMatriculas
			// 
			this.grbEdiciondeMatriculas.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeMatriculas.Controls.Add(this.btnBuscar);
			this.grbEdiciondeMatriculas.Controls.Add(this.btnEliminar);
			this.grbEdiciondeMatriculas.Controls.Add(this.btnModificar);
			this.grbEdiciondeMatriculas.Controls.Add(this.btnNuevo);
			this.grbEdiciondeMatriculas.ForeColor = System.Drawing.Color.White;
			this.grbEdiciondeMatriculas.Location = new System.Drawing.Point(575, 12);
			this.grbEdiciondeMatriculas.Name = "grbEdiciondeMatriculas";
			this.grbEdiciondeMatriculas.Size = new System.Drawing.Size(86, 188);
			this.grbEdiciondeMatriculas.TabIndex = 8;
			this.grbEdiciondeMatriculas.TabStop = false;
			this.grbEdiciondeMatriculas.Text = "Edición de Matrículas";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnBuscar.Location = new System.Drawing.Point(6, 117);
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
			this.btnEliminar.Location = new System.Drawing.Point(6, 159);
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
			this.btnModificar.Location = new System.Drawing.Point(6, 76);
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
			this.btnNuevo.Location = new System.Drawing.Point(5, 33);
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
			this.grbNavegacion.Location = new System.Drawing.Point(12, 147);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(557, 53);
			this.grbNavegacion.TabIndex = 7;
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
			// grbMatriculas
			// 
			this.grbMatriculas.BackColor = System.Drawing.Color.Transparent;
			this.grbMatriculas.Controls.Add(this.cboIdResponsables);
			this.grbMatriculas.Controls.Add(this.cboIdAlumno);
			this.grbMatriculas.Controls.Add(this.txtFecha);
			this.grbMatriculas.Controls.Add(this.lblFecha);
			this.grbMatriculas.Controls.Add(this.lblIdResponsables);
			this.grbMatriculas.Controls.Add(this.lblIdMatricula);
			this.grbMatriculas.Controls.Add(this.lblIdAlumno);
			this.grbMatriculas.Enabled = false;
			this.grbMatriculas.ForeColor = System.Drawing.Color.White;
			this.grbMatriculas.Location = new System.Drawing.Point(12, 12);
			this.grbMatriculas.Name = "grbMatriculas";
			this.grbMatriculas.Size = new System.Drawing.Size(557, 129);
			this.grbMatriculas.TabIndex = 6;
			this.grbMatriculas.TabStop = false;
			this.grbMatriculas.Text = "Mantenimiento Matrículas";
			// 
			// cboIdResponsables
			// 
			this.cboIdResponsables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboIdResponsables.FormattingEnabled = true;
			this.cboIdResponsables.Location = new System.Drawing.Point(98, 62);
			this.cboIdResponsables.Name = "cboIdResponsables";
			this.cboIdResponsables.Size = new System.Drawing.Size(298, 21);
			this.cboIdResponsables.TabIndex = 8;
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
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(98, 96);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(170, 20);
			this.txtFecha.TabIndex = 6;
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(20, 99);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(40, 13);
			this.lblFecha.TabIndex = 5;
			this.lblFecha.Text = "Fecha:";
			// 
			// lblIdResponsables
			// 
			this.lblIdResponsables.AutoSize = true;
			this.lblIdResponsables.Location = new System.Drawing.Point(20, 67);
			this.lblIdResponsables.Name = "lblIdResponsables";
			this.lblIdResponsables.Size = new System.Drawing.Size(72, 13);
			this.lblIdResponsables.TabIndex = 3;
			this.lblIdResponsables.Text = "Responsable:";
			// 
			// lblIdMatricula
			// 
			this.lblIdMatricula.AutoSize = true;
			this.lblIdMatricula.Location = new System.Drawing.Point(411, 38);
			this.lblIdMatricula.Name = "lblIdMatricula";
			this.lblIdMatricula.Size = new System.Drawing.Size(21, 13);
			this.lblIdMatricula.TabIndex = 1;
			this.lblIdMatricula.Text = "ID:";
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
			// Matriculas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Conversor_A.Properties.Resources.tema_azul_clasico_abstracto_fondo_pantalla_23_2148410363;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(672, 214);
			this.Controls.Add(this.grbEdiciondeMatriculas);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbMatriculas);
			this.Name = "Matriculas";
			this.Text = "Matriculas";
			this.Load += new System.EventHandler(this.Matriculas_Load);
			this.grbEdiciondeMatriculas.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbMatriculas.ResumeLayout(false);
			this.grbMatriculas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdiciondeMatriculas;
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
		private System.Windows.Forms.GroupBox grbMatriculas;
		private System.Windows.Forms.ComboBox cboIdResponsables;
		private System.Windows.Forms.ComboBox cboIdAlumno;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lblIdResponsables;
		private System.Windows.Forms.Label lblIdMatricula;
		private System.Windows.Forms.Label lblIdAlumno;
	}
}