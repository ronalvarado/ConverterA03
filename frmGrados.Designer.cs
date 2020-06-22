namespace Conversor_A
{
	partial class frmGrados
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
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.grbEdiciondeGrados = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbNavegacion = new System.Windows.Forms.GroupBox();
			this.lblnregistros = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbGrados = new System.Windows.Forms.GroupBox();
			this.lblGrado = new System.Windows.Forms.Label();
			this.txtGrado = new System.Windows.Forms.TextBox();
			this.lblidGrado = new System.Windows.Forms.Label();
			this.grbEdiciondeGrados.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbGrados.SuspendLayout();
			this.SuspendLayout();
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
			// grbEdiciondeGrados
			// 
			this.grbEdiciondeGrados.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeGrados.Controls.Add(this.btnBuscar);
			this.grbEdiciondeGrados.Controls.Add(this.btnEliminar);
			this.grbEdiciondeGrados.Controls.Add(this.btnModificar);
			this.grbEdiciondeGrados.Controls.Add(this.btnNuevo);
			this.grbEdiciondeGrados.ForeColor = System.Drawing.Color.Black;
			this.grbEdiciondeGrados.Location = new System.Drawing.Point(334, 12);
			this.grbEdiciondeGrados.Name = "grbEdiciondeGrados";
			this.grbEdiciondeGrados.Size = new System.Drawing.Size(71, 144);
			this.grbEdiciondeGrados.TabIndex = 19;
			this.grbEdiciondeGrados.TabStop = false;
			this.grbEdiciondeGrados.Text = "Edición de Grados";
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
			this.grbNavegacion.TabIndex = 18;
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
			// grbGrados
			// 
			this.grbGrados.BackColor = System.Drawing.Color.Transparent;
			this.grbGrados.Controls.Add(this.lblGrado);
			this.grbGrados.Controls.Add(this.txtGrado);
			this.grbGrados.Controls.Add(this.lblidGrado);
			this.grbGrados.Enabled = false;
			this.grbGrados.ForeColor = System.Drawing.Color.Black;
			this.grbGrados.Location = new System.Drawing.Point(12, 12);
			this.grbGrados.Name = "grbGrados";
			this.grbGrados.Size = new System.Drawing.Size(316, 81);
			this.grbGrados.TabIndex = 17;
			this.grbGrados.TabStop = false;
			this.grbGrados.Text = "Mantenimiento Grados";
			// 
			// lblGrado
			// 
			this.lblGrado.AutoSize = true;
			this.lblGrado.Location = new System.Drawing.Point(10, 35);
			this.lblGrado.Name = "lblGrado";
			this.lblGrado.Size = new System.Drawing.Size(39, 13);
			this.lblGrado.TabIndex = 7;
			this.lblGrado.Text = "Grado:";
			// 
			// txtGrado
			// 
			this.txtGrado.Location = new System.Drawing.Point(55, 32);
			this.txtGrado.Name = "txtGrado";
			this.txtGrado.Size = new System.Drawing.Size(255, 20);
			this.txtGrado.TabIndex = 6;
			// 
			// lblidGrado
			// 
			this.lblidGrado.AutoSize = true;
			this.lblidGrado.Location = new System.Drawing.Point(278, 16);
			this.lblidGrado.Name = "lblidGrado";
			this.lblidGrado.Size = new System.Drawing.Size(21, 13);
			this.lblidGrado.TabIndex = 1;
			this.lblidGrado.Text = "ID:";
			// 
			// frmGrados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(416, 168);
			this.Controls.Add(this.grbEdiciondeGrados);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbGrados);
			this.Name = "frmGrados";
			this.Text = "frmGrados";
			this.Load += new System.EventHandler(this.frmGrados_Load);
			this.grbEdiciondeGrados.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbGrados.ResumeLayout(false);
			this.grbGrados.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.GroupBox grbEdiciondeGrados;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox grbNavegacion;
		private System.Windows.Forms.Label lblnregistros;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox grbGrados;
		private System.Windows.Forms.Label lblGrado;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.Label lblidGrado;
	}
}