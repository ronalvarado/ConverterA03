namespace Conversor_A
{
	partial class frmResponsables
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsables));
			this.grbEdicionderesponsables = new System.Windows.Forms.GroupBox();
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
			this.grbResponsables = new System.Windows.Forms.GroupBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.lblNit = new System.Windows.Forms.Label();
			this.txtDui = new System.Windows.Forms.TextBox();
			this.lblDui = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.lblEdad = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblIdResponsable = new System.Windows.Forms.Label();
			this.lblCódigo = new System.Windows.Forms.Label();
			this.grbEdicionderesponsables.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbResponsables.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdicionderesponsables
			// 
			this.grbEdicionderesponsables.BackColor = System.Drawing.Color.Transparent;
			this.grbEdicionderesponsables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbEdicionderesponsables.BackgroundImage")));
			this.grbEdicionderesponsables.Controls.Add(this.btnBuscar);
			this.grbEdicionderesponsables.Controls.Add(this.btnEliminar);
			this.grbEdicionderesponsables.Controls.Add(this.btnModificar);
			this.grbEdicionderesponsables.Controls.Add(this.btnNuevo);
			this.grbEdicionderesponsables.ForeColor = System.Drawing.Color.Black;
			this.grbEdicionderesponsables.Location = new System.Drawing.Point(436, 12);
			this.grbEdicionderesponsables.Name = "grbEdicionderesponsables";
			this.grbEdicionderesponsables.Size = new System.Drawing.Size(90, 293);
			this.grbEdicionderesponsables.TabIndex = 8;
			this.grbEdicionderesponsables.TabStop = false;
			this.grbEdicionderesponsables.Text = "Edición de Resposables";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.Teal;
			this.btnBuscar.Location = new System.Drawing.Point(6, 171);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Teal;
			this.btnEliminar.Location = new System.Drawing.Point(6, 240);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Teal;
			this.btnModificar.Location = new System.Drawing.Point(6, 100);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.Teal;
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
			this.grbNavegacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbNavegacion.BackgroundImage")));
			this.grbNavegacion.Controls.Add(this.lblnregistros);
			this.grbNavegacion.Controls.Add(this.btnUltimo);
			this.grbNavegacion.Controls.Add(this.btnSiguiente);
			this.grbNavegacion.Controls.Add(this.btnAnterior);
			this.grbNavegacion.Controls.Add(this.btnPrimero);
			this.grbNavegacion.ForeColor = System.Drawing.Color.Black;
			this.grbNavegacion.Location = new System.Drawing.Point(12, 252);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(418, 53);
			this.grbNavegacion.TabIndex = 7;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(207, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Brown;
			this.btnUltimo.Location = new System.Drawing.Point(350, 19);
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
			this.btnSiguiente.Location = new System.Drawing.Point(269, 19);
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
			this.btnAnterior.Location = new System.Drawing.Point(105, 19);
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
			this.btnPrimero.Location = new System.Drawing.Point(20, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbResponsables
			// 
			this.grbResponsables.BackColor = System.Drawing.Color.Transparent;
			this.grbResponsables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbResponsables.BackgroundImage")));
			this.grbResponsables.Controls.Add(this.txtTelefono);
			this.grbResponsables.Controls.Add(this.lblTelefono);
			this.grbResponsables.Controls.Add(this.txtNit);
			this.grbResponsables.Controls.Add(this.lblNit);
			this.grbResponsables.Controls.Add(this.txtDui);
			this.grbResponsables.Controls.Add(this.lblDui);
			this.grbResponsables.Controls.Add(this.txtDireccion);
			this.grbResponsables.Controls.Add(this.lblDireccion);
			this.grbResponsables.Controls.Add(this.txtEdad);
			this.grbResponsables.Controls.Add(this.lblEdad);
			this.grbResponsables.Controls.Add(this.txtNombre);
			this.grbResponsables.Controls.Add(this.lblNombre);
			this.grbResponsables.Controls.Add(this.txtCodigo);
			this.grbResponsables.Controls.Add(this.lblIdResponsable);
			this.grbResponsables.Controls.Add(this.lblCódigo);
			this.grbResponsables.Enabled = false;
			this.grbResponsables.ForeColor = System.Drawing.Color.Black;
			this.grbResponsables.Location = new System.Drawing.Point(12, 12);
			this.grbResponsables.Name = "grbResponsables";
			this.grbResponsables.Size = new System.Drawing.Size(418, 234);
			this.grbResponsables.TabIndex = 6;
			this.grbResponsables.TabStop = false;
			this.grbResponsables.Text = "Mantenimiento Responsables";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(81, 201);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(100, 20);
			this.txtTelefono.TabIndex = 14;
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(20, 200);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(52, 13);
			this.lblTelefono.TabIndex = 13;
			this.lblTelefono.Text = "Teléfono:";
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(81, 175);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(126, 20);
			this.txtNit.TabIndex = 12;
			// 
			// lblNit
			// 
			this.lblNit.AutoSize = true;
			this.lblNit.Location = new System.Drawing.Point(20, 174);
			this.lblNit.Name = "lblNit";
			this.lblNit.Size = new System.Drawing.Size(28, 13);
			this.lblNit.TabIndex = 11;
			this.lblNit.Text = "NIT:";
			// 
			// txtDui
			// 
			this.txtDui.Location = new System.Drawing.Point(81, 149);
			this.txtDui.Name = "txtDui";
			this.txtDui.Size = new System.Drawing.Size(126, 20);
			this.txtDui.TabIndex = 10;
			// 
			// lblDui
			// 
			this.lblDui.AutoSize = true;
			this.lblDui.Location = new System.Drawing.Point(20, 148);
			this.lblDui.Name = "lblDui";
			this.lblDui.Size = new System.Drawing.Size(29, 13);
			this.lblDui.TabIndex = 9;
			this.lblDui.Text = "DUI:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(81, 123);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(260, 20);
			this.txtDireccion.TabIndex = 8;
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(20, 122);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(55, 13);
			this.lblDireccion.TabIndex = 7;
			this.lblDireccion.Text = "Dirección:";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(81, 97);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 20);
			this.txtEdad.TabIndex = 6;
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.Location = new System.Drawing.Point(20, 99);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(35, 13);
			this.lblEdad.TabIndex = 5;
			this.lblEdad.Text = "Edad:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(81, 71);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(260, 20);
			this.txtNombre.TabIndex = 4;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(20, 74);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(47, 13);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(81, 45);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 2;
			// 
			// lblIdResponsable
			// 
			this.lblIdResponsable.AutoSize = true;
			this.lblIdResponsable.Location = new System.Drawing.Point(210, 48);
			this.lblIdResponsable.Name = "lblIdResponsable";
			this.lblIdResponsable.Size = new System.Drawing.Size(21, 13);
			this.lblIdResponsable.TabIndex = 1;
			this.lblIdResponsable.Text = "ID:";
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
			// frmResponsables
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(544, 319);
			this.Controls.Add(this.grbEdicionderesponsables);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbResponsables);
			this.Name = "frmResponsables";
			this.Text = "frmResponsables";
			this.Load += new System.EventHandler(this.frmResponsables_Load);
			this.grbEdicionderesponsables.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbResponsables.ResumeLayout(false);
			this.grbResponsables.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdicionderesponsables;
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
		private System.Windows.Forms.GroupBox grbResponsables;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.TextBox txtNit;
		private System.Windows.Forms.Label lblNit;
		private System.Windows.Forms.TextBox txtDui;
		private System.Windows.Forms.Label lblDui;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblIdResponsable;
		private System.Windows.Forms.Label lblCódigo;
	}
}