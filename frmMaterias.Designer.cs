namespace Conversor_A
{
	partial class frmMaterias
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
			this.grbEdiciondeMateria = new System.Windows.Forms.GroupBox();
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
			this.grbMateria = new System.Windows.Forms.GroupBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblMateria = new System.Windows.Forms.Label();
			this.txtMateria = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblIdMateria = new System.Windows.Forms.Label();
			this.grbEdiciondeMateria.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbMateria.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbEdiciondeMateria
			// 
			this.grbEdiciondeMateria.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeMateria.Controls.Add(this.btnBuscar);
			this.grbEdiciondeMateria.Controls.Add(this.btnEliminar);
			this.grbEdiciondeMateria.Controls.Add(this.btnModificar);
			this.grbEdiciondeMateria.Controls.Add(this.btnNuevo);
			this.grbEdiciondeMateria.ForeColor = System.Drawing.Color.Black;
			this.grbEdiciondeMateria.Location = new System.Drawing.Point(334, 12);
			this.grbEdiciondeMateria.Name = "grbEdiciondeMateria";
			this.grbEdiciondeMateria.Size = new System.Drawing.Size(71, 144);
			this.grbEdiciondeMateria.TabIndex = 16;
			this.grbEdiciondeMateria.TabStop = false;
			this.grbEdiciondeMateria.Text = "Edición de Materias";
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
			this.grbNavegacion.TabIndex = 15;
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
			// grbMateria
			// 
			this.grbMateria.BackColor = System.Drawing.Color.Transparent;
			this.grbMateria.Controls.Add(this.txtCodigo);
			this.grbMateria.Controls.Add(this.lblMateria);
			this.grbMateria.Controls.Add(this.txtMateria);
			this.grbMateria.Controls.Add(this.lblCodigo);
			this.grbMateria.Controls.Add(this.lblIdMateria);
			this.grbMateria.Enabled = false;
			this.grbMateria.ForeColor = System.Drawing.Color.Black;
			this.grbMateria.Location = new System.Drawing.Point(12, 12);
			this.grbMateria.Name = "grbMateria";
			this.grbMateria.Size = new System.Drawing.Size(316, 81);
			this.grbMateria.TabIndex = 14;
			this.grbMateria.TabStop = false;
			this.grbMateria.Text = "Mantenimiento Materias";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(55, 31);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(219, 20);
			this.txtCodigo.TabIndex = 8;
			// 
			// lblMateria
			// 
			this.lblMateria.AutoSize = true;
			this.lblMateria.Location = new System.Drawing.Point(6, 58);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(45, 13);
			this.lblMateria.TabIndex = 7;
			this.lblMateria.Text = "Materia:";
			// 
			// txtMateria
			// 
			this.txtMateria.Location = new System.Drawing.Point(55, 55);
			this.txtMateria.Name = "txtMateria";
			this.txtMateria.Size = new System.Drawing.Size(255, 20);
			this.txtMateria.TabIndex = 6;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(6, 34);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(43, 13);
			this.lblCodigo.TabIndex = 3;
			this.lblCodigo.Text = "Código:";
			// 
			// lblIdMateria
			// 
			this.lblIdMateria.AutoSize = true;
			this.lblIdMateria.Location = new System.Drawing.Point(280, 34);
			this.lblIdMateria.Name = "lblIdMateria";
			this.lblIdMateria.Size = new System.Drawing.Size(21, 13);
			this.lblIdMateria.TabIndex = 1;
			this.lblIdMateria.Text = "ID:";
			// 
			// frmMaterias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::Conversor_A.Properties.Resources.lineas_abstractas_curvas_fondo_azul_sombra_23_2148273610;
			this.ClientSize = new System.Drawing.Size(422, 169);
			this.Controls.Add(this.grbEdiciondeMateria);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbMateria);
			this.Name = "frmMaterias";
			this.Text = "frmMaterias";
			this.Load += new System.EventHandler(this.frmMaterias_Load);
			this.grbEdiciondeMateria.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbMateria.ResumeLayout(false);
			this.grbMateria.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbEdiciondeMateria;
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
		private System.Windows.Forms.GroupBox grbMateria;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.TextBox txtMateria;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblIdMateria;
	}
}