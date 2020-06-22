namespace Conversor_A
{
	partial class frmAlumnos
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
			this.grbEdiciondealumnos = new System.Windows.Forms.GroupBox();
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
			this.grbAlumnos = new System.Windows.Forms.GroupBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblEdad = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblIdAlumno = new System.Windows.Forms.Label();
			this.lblCódigo = new System.Windows.Forms.Label();
			this.grbEdiciondealumnos.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbAlumnos.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdiciondealumnos
			// 
			this.grbEdiciondealumnos.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondealumnos.Controls.Add(this.btnBuscar);
			this.grbEdiciondealumnos.Controls.Add(this.btnEliminar);
			this.grbEdiciondealumnos.Controls.Add(this.btnModificar);
			this.grbEdiciondealumnos.Controls.Add(this.btnNuevo);
			this.grbEdiciondealumnos.ForeColor = System.Drawing.Color.Black;
			this.grbEdiciondealumnos.Location = new System.Drawing.Point(571, 12);
			this.grbEdiciondealumnos.Name = "grbEdiciondealumnos";
			this.grbEdiciondealumnos.Size = new System.Drawing.Size(94, 239);
			this.grbEdiciondealumnos.TabIndex = 5;
			this.grbEdiciondealumnos.TabStop = false;
			this.grbEdiciondealumnos.Text = "Edición de Alumnos";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnBuscar.Location = new System.Drawing.Point(6, 142);
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
			this.btnEliminar.Location = new System.Drawing.Point(6, 204);
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
			this.btnModificar.Location = new System.Drawing.Point(6, 90);
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
			this.btnNuevo.Location = new System.Drawing.Point(6, 38);
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
			this.grbNavegacion.ForeColor = System.Drawing.Color.Black;
			this.grbNavegacion.Location = new System.Drawing.Point(12, 257);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(653, 53);
			this.grbNavegacion.TabIndex = 4;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(335, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Maroon;
			this.btnUltimo.Location = new System.Drawing.Point(559, 19);
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
			this.btnSiguiente.Location = new System.Drawing.Point(435, 19);
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
			this.btnAnterior.Location = new System.Drawing.Point(180, 19);
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
			this.btnPrimero.Location = new System.Drawing.Point(59, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbAlumnos
			// 
			this.grbAlumnos.BackColor = System.Drawing.Color.Transparent;
			this.grbAlumnos.Controls.Add(this.txtTelefono);
			this.grbAlumnos.Controls.Add(this.txtDireccion);
			this.grbAlumnos.Controls.Add(this.txtEdad);
			this.grbAlumnos.Controls.Add(this.txtNombre);
			this.grbAlumnos.Controls.Add(this.lblTelefono);
			this.grbAlumnos.Controls.Add(this.lblDireccion);
			this.grbAlumnos.Controls.Add(this.lblEdad);
			this.grbAlumnos.Controls.Add(this.lblNombre);
			this.grbAlumnos.Controls.Add(this.txtCodigo);
			this.grbAlumnos.Controls.Add(this.lblIdAlumno);
			this.grbAlumnos.Controls.Add(this.lblCódigo);
			this.grbAlumnos.Enabled = false;
			this.grbAlumnos.ForeColor = System.Drawing.Color.Black;
			this.grbAlumnos.Location = new System.Drawing.Point(12, 12);
			this.grbAlumnos.Name = "grbAlumnos";
			this.grbAlumnos.Size = new System.Drawing.Size(553, 239);
			this.grbAlumnos.TabIndex = 3;
			this.grbAlumnos.TabStop = false;
			this.grbAlumnos.Text = "Mantenimiento Alumnos ";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(84, 149);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(100, 20);
			this.txtTelefono.TabIndex = 10;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(84, 123);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(175, 20);
			this.txtDireccion.TabIndex = 9;
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(84, 97);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 20);
			this.txtEdad.TabIndex = 8;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(84, 71);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(309, 20);
			this.txtNombre.TabIndex = 7;
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(20, 152);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(49, 13);
			this.lblTelefono.TabIndex = 6;
			this.lblTelefono.Text = "Telefóno";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(20, 126);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(52, 13);
			this.lblDireccion.TabIndex = 5;
			this.lblDireccion.Text = "Dirección";
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.Location = new System.Drawing.Point(20, 100);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(35, 13);
			this.lblEdad.TabIndex = 4;
			this.lblEdad.Text = "Edad:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(20, 74);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(44, 13);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(84, 45);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 2;
			// 
			// lblIdAlumno
			// 
			this.lblIdAlumno.AutoSize = true;
			this.lblIdAlumno.Location = new System.Drawing.Point(238, 48);
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
			// frmAlumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(678, 325);
			this.Controls.Add(this.grbEdiciondealumnos);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbAlumnos);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "frmAlumnos";
			this.Text = "frmAlumnos";
			this.Load += new System.EventHandler(this.frmAlumnos_Load);
			this.grbEdiciondealumnos.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbAlumnos.ResumeLayout(false);
			this.grbAlumnos.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdiciondealumnos;
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
		private System.Windows.Forms.GroupBox grbAlumnos;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblIdAlumno;
		private System.Windows.Forms.Label lblCódigo;
	}
}