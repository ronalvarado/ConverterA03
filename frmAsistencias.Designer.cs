namespace Conversor_A
{
	partial class frmAsistencias
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
			this.lblIdAlumno = new System.Windows.Forms.Label();
			this.lblidAsistencia = new System.Windows.Forms.Label();
			this.lblfecha = new System.Windows.Forms.Label();
			this.cboAlumno = new System.Windows.Forms.ComboBox();
			this.txtasistio = new System.Windows.Forms.TextBox();
			this.lblasistio = new System.Windows.Forms.Label();
			this.grbAsistencia = new System.Windows.Forms.GroupBox();
			this.cboMeses = new System.Windows.Forms.ComboBox();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.lblIdMes = new System.Windows.Forms.Label();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.lblnregistros = new System.Windows.Forms.Label();
			this.grbNavegacion = new System.Windows.Forms.GroupBox();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.grbEdiciondeAsistencias = new System.Windows.Forms.GroupBox();
			this.grbAsistencia.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbEdiciondeAsistencias.SuspendLayout();
			this.SuspendLayout();
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
			// lblidAsistencia
			// 
			this.lblidAsistencia.AutoSize = true;
			this.lblidAsistencia.Location = new System.Drawing.Point(411, 38);
			this.lblidAsistencia.Name = "lblidAsistencia";
			this.lblidAsistencia.Size = new System.Drawing.Size(21, 13);
			this.lblidAsistencia.TabIndex = 1;
			this.lblidAsistencia.Text = "ID:";
			// 
			// lblfecha
			// 
			this.lblfecha.AutoSize = true;
			this.lblfecha.Location = new System.Drawing.Point(28, 96);
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Size = new System.Drawing.Size(37, 13);
			this.lblfecha.TabIndex = 5;
			this.lblfecha.Text = "fecha:";
			// 
			// cboAlumno
			// 
			this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAlumno.FormattingEnabled = true;
			this.cboAlumno.Location = new System.Drawing.Point(98, 35);
			this.cboAlumno.Name = "cboAlumno";
			this.cboAlumno.Size = new System.Drawing.Size(298, 21);
			this.cboAlumno.TabIndex = 7;
			// 
			// txtasistio
			// 
			this.txtasistio.Location = new System.Drawing.Point(98, 119);
			this.txtasistio.Name = "txtasistio";
			this.txtasistio.Size = new System.Drawing.Size(45, 20);
			this.txtasistio.TabIndex = 9;
			// 
			// lblasistio
			// 
			this.lblasistio.AutoSize = true;
			this.lblasistio.Location = new System.Drawing.Point(25, 126);
			this.lblasistio.Name = "lblasistio";
			this.lblasistio.Size = new System.Drawing.Size(40, 13);
			this.lblasistio.TabIndex = 11;
			this.lblasistio.Text = "Asistió:";
			// 
			// grbAsistencia
			// 
			this.grbAsistencia.BackColor = System.Drawing.Color.Transparent;
			this.grbAsistencia.Controls.Add(this.lblasistio);
			this.grbAsistencia.Controls.Add(this.txtasistio);
			this.grbAsistencia.Controls.Add(this.cboMeses);
			this.grbAsistencia.Controls.Add(this.cboAlumno);
			this.grbAsistencia.Controls.Add(this.txtfecha);
			this.grbAsistencia.Controls.Add(this.lblfecha);
			this.grbAsistencia.Controls.Add(this.lblIdMes);
			this.grbAsistencia.Controls.Add(this.lblidAsistencia);
			this.grbAsistencia.Controls.Add(this.lblIdAlumno);
			this.grbAsistencia.Enabled = false;
			this.grbAsistencia.ForeColor = System.Drawing.Color.White;
			this.grbAsistencia.Location = new System.Drawing.Point(12, 12);
			this.grbAsistencia.Name = "grbAsistencia";
			this.grbAsistencia.Size = new System.Drawing.Size(489, 180);
			this.grbAsistencia.TabIndex = 10;
			this.grbAsistencia.TabStop = false;
			this.grbAsistencia.Text = "Mantenimiento Asistencias";
			// 
			// cboMeses
			// 
			this.cboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMeses.FormattingEnabled = true;
			this.cboMeses.Location = new System.Drawing.Point(98, 62);
			this.cboMeses.Name = "cboMeses";
			this.cboMeses.Size = new System.Drawing.Size(298, 21);
			this.cboMeses.TabIndex = 8;
			// 
			// txtfecha
			// 
			this.txtfecha.Location = new System.Drawing.Point(98, 93);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(170, 20);
			this.txtfecha.TabIndex = 6;
			// 
			// lblIdMes
			// 
			this.lblIdMes.AutoSize = true;
			this.lblIdMes.Location = new System.Drawing.Point(35, 65);
			this.lblIdMes.Name = "lblIdMes";
			this.lblIdMes.Size = new System.Drawing.Size(30, 13);
			this.lblIdMes.TabIndex = 3;
			this.lblIdMes.Text = "Mes:";
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.Maroon;
			this.btnPrimero.Location = new System.Drawing.Point(38, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Maroon;
			this.btnAnterior.Location = new System.Drawing.Point(151, 19);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 4;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Maroon;
			this.btnSiguiente.Location = new System.Drawing.Point(302, 19);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Maroon;
			this.btnUltimo.Location = new System.Drawing.Point(414, 19);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 6;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(242, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
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
			this.grbNavegacion.Location = new System.Drawing.Point(12, 198);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(489, 53);
			this.grbNavegacion.TabIndex = 11;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Location = new System.Drawing.Point(6, 37);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(58, 23);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnModificar.ForeColor = System.Drawing.Color.Black;
			this.btnModificar.Location = new System.Drawing.Point(6, 95);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(58, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnEliminar.ForeColor = System.Drawing.Color.Black;
			this.btnEliminar.Location = new System.Drawing.Point(6, 204);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(58, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(6, 151);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(58, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// grbEdiciondeAsistencias
			// 
			this.grbEdiciondeAsistencias.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeAsistencias.Controls.Add(this.btnBuscar);
			this.grbEdiciondeAsistencias.Controls.Add(this.btnEliminar);
			this.grbEdiciondeAsistencias.Controls.Add(this.btnModificar);
			this.grbEdiciondeAsistencias.Controls.Add(this.btnNuevo);
			this.grbEdiciondeAsistencias.ForeColor = System.Drawing.Color.White;
			this.grbEdiciondeAsistencias.Location = new System.Drawing.Point(507, 12);
			this.grbEdiciondeAsistencias.Name = "grbEdiciondeAsistencias";
			this.grbEdiciondeAsistencias.Size = new System.Drawing.Size(74, 238);
			this.grbEdiciondeAsistencias.TabIndex = 12;
			this.grbEdiciondeAsistencias.TabStop = false;
			this.grbEdiciondeAsistencias.Text = "Edición de Asistencias";
			// 
			// frmAsistencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(593, 264);
			this.Controls.Add(this.grbEdiciondeAsistencias);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbAsistencia);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "frmAsistencias";
			this.Text = "frmAsistencias";
			this.Load += new System.EventHandler(this.frmAsistencias_Load);
			this.grbAsistencia.ResumeLayout(false);
			this.grbAsistencia.PerformLayout();
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbEdiciondeAsistencias.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblIdAlumno;
		private System.Windows.Forms.Label lblidAsistencia;
		private System.Windows.Forms.Label lblfecha;
		private System.Windows.Forms.ComboBox cboAlumno;
		private System.Windows.Forms.TextBox txtasistio;
		private System.Windows.Forms.Label lblasistio;
		private System.Windows.Forms.GroupBox grbAsistencia;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Label lblnregistros;
		private System.Windows.Forms.GroupBox grbNavegacion;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.GroupBox grbEdiciondeAsistencias;
		private System.Windows.Forms.ComboBox cboMeses;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label lblIdMes;
	}
}