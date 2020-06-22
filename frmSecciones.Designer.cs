namespace Conversor_A
{
	partial class frmSecciones
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
			this.grbEdiciondeSecciones = new System.Windows.Forms.GroupBox();
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
			this.grbSecciones = new System.Windows.Forms.GroupBox();
			this.lblSeccion = new System.Windows.Forms.Label();
			this.txtSeccion = new System.Windows.Forms.TextBox();
			this.lblidSeccion = new System.Windows.Forms.Label();
			this.grbEdiciondeSecciones.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbSecciones.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdiciondeSecciones
			// 
			this.grbEdiciondeSecciones.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeSecciones.Controls.Add(this.btnBuscar);
			this.grbEdiciondeSecciones.Controls.Add(this.btnEliminar);
			this.grbEdiciondeSecciones.Controls.Add(this.btnModificar);
			this.grbEdiciondeSecciones.Controls.Add(this.btnNuevo);
			this.grbEdiciondeSecciones.ForeColor = System.Drawing.Color.Black;
			this.grbEdiciondeSecciones.Location = new System.Drawing.Point(334, 12);
			this.grbEdiciondeSecciones.Name = "grbEdiciondeSecciones";
			this.grbEdiciondeSecciones.Size = new System.Drawing.Size(71, 144);
			this.grbEdiciondeSecciones.TabIndex = 22;
			this.grbEdiciondeSecciones.TabStop = false;
			this.grbEdiciondeSecciones.Text = "Edición de Secciones";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(7, 87);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(58, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnEliminar.ForeColor = System.Drawing.Color.Black;
			this.btnEliminar.Location = new System.Drawing.Point(6, 116);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(58, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnModificar.ForeColor = System.Drawing.Color.Black;
			this.btnModificar.Location = new System.Drawing.Point(6, 58);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(58, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Location = new System.Drawing.Point(6, 29);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(58, 23);
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
			this.grbNavegacion.Location = new System.Drawing.Point(12, 93);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(316, 63);
			this.grbNavegacion.TabIndex = 21;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(149, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Maroon;
			this.btnUltimo.Location = new System.Drawing.Point(270, 19);
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
			this.btnSiguiente.Location = new System.Drawing.Point(194, 19);
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
			this.btnAnterior.Location = new System.Drawing.Point(73, 19);
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
			this.btnPrimero.Location = new System.Drawing.Point(6, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbSecciones
			// 
			this.grbSecciones.BackColor = System.Drawing.Color.Transparent;
			this.grbSecciones.Controls.Add(this.lblSeccion);
			this.grbSecciones.Controls.Add(this.txtSeccion);
			this.grbSecciones.Controls.Add(this.lblidSeccion);
			this.grbSecciones.Enabled = false;
			this.grbSecciones.ForeColor = System.Drawing.Color.Black;
			this.grbSecciones.Location = new System.Drawing.Point(12, 12);
			this.grbSecciones.Name = "grbSecciones";
			this.grbSecciones.Size = new System.Drawing.Size(316, 81);
			this.grbSecciones.TabIndex = 20;
			this.grbSecciones.TabStop = false;
			this.grbSecciones.Text = "Mantenimiento Secciones";
			// 
			// lblSeccion
			// 
			this.lblSeccion.AutoSize = true;
			this.lblSeccion.Location = new System.Drawing.Point(3, 35);
			this.lblSeccion.Name = "lblSeccion";
			this.lblSeccion.Size = new System.Drawing.Size(49, 13);
			this.lblSeccion.TabIndex = 7;
			this.lblSeccion.Text = "Sección:";
			// 
			// txtSeccion
			// 
			this.txtSeccion.Location = new System.Drawing.Point(55, 32);
			this.txtSeccion.Name = "txtSeccion";
			this.txtSeccion.Size = new System.Drawing.Size(255, 20);
			this.txtSeccion.TabIndex = 6;
			// 
			// lblidSeccion
			// 
			this.lblidSeccion.AutoSize = true;
			this.lblidSeccion.Location = new System.Drawing.Point(278, 16);
			this.lblidSeccion.Name = "lblidSeccion";
			this.lblidSeccion.Size = new System.Drawing.Size(21, 13);
			this.lblidSeccion.TabIndex = 1;
			this.lblidSeccion.Text = "ID:";
			// 
			// frmSecciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(417, 172);
			this.Controls.Add(this.grbEdiciondeSecciones);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbSecciones);
			this.Name = "frmSecciones";
			this.Text = "frmSecciones";
			this.Load += new System.EventHandler(this.frmSecciones_Load);
			this.grbEdiciondeSecciones.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbSecciones.ResumeLayout(false);
			this.grbSecciones.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdiciondeSecciones;
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
		private System.Windows.Forms.GroupBox grbSecciones;
		private System.Windows.Forms.Label lblSeccion;
		private System.Windows.Forms.TextBox txtSeccion;
		private System.Windows.Forms.Label lblidSeccion;
	}
}