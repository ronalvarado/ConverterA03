namespace Conversor_A
{
	partial class Meses
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
			this.grbMeses = new System.Windows.Forms.GroupBox();
			this.txtMes = new System.Windows.Forms.TextBox();
			this.lblIdMes = new System.Windows.Forms.Label();
			this.lblIdMeses = new System.Windows.Forms.Label();
			this.grbNavegacion = new System.Windows.Forms.GroupBox();
			this.lblnregistros = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbEdiciondeMeses = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbMeses.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbEdiciondeMeses.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbMeses
			// 
			this.grbMeses.BackColor = System.Drawing.Color.Transparent;
			this.grbMeses.Controls.Add(this.txtMes);
			this.grbMeses.Controls.Add(this.lblIdMes);
			this.grbMeses.Controls.Add(this.lblIdMeses);
			this.grbMeses.Enabled = false;
			this.grbMeses.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.grbMeses.Location = new System.Drawing.Point(12, 12);
			this.grbMeses.Name = "grbMeses";
			this.grbMeses.Size = new System.Drawing.Size(316, 75);
			this.grbMeses.TabIndex = 8;
			this.grbMeses.TabStop = false;
			this.grbMeses.Text = "Mantenimiento Meses";
			// 
			// txtMes
			// 
			this.txtMes.Location = new System.Drawing.Point(42, 31);
			this.txtMes.Name = "txtMes";
			this.txtMes.Size = new System.Drawing.Size(219, 20);
			this.txtMes.TabIndex = 6;
			// 
			// lblIdMes
			// 
			this.lblIdMes.AutoSize = true;
			this.lblIdMes.Location = new System.Drawing.Point(6, 34);
			this.lblIdMes.Name = "lblIdMes";
			this.lblIdMes.Size = new System.Drawing.Size(30, 13);
			this.lblIdMes.TabIndex = 3;
			this.lblIdMes.Text = "Mes:";
			// 
			// lblIdMeses
			// 
			this.lblIdMeses.AutoSize = true;
			this.lblIdMeses.Location = new System.Drawing.Point(269, 34);
			this.lblIdMeses.Name = "lblIdMeses";
			this.lblIdMeses.Size = new System.Drawing.Size(21, 13);
			this.lblIdMeses.TabIndex = 1;
			this.lblIdMeses.Text = "ID:";
			// 
			// grbNavegacion
			// 
			this.grbNavegacion.BackColor = System.Drawing.Color.Transparent;
			this.grbNavegacion.Controls.Add(this.lblnregistros);
			this.grbNavegacion.Controls.Add(this.btnUltimo);
			this.grbNavegacion.Controls.Add(this.btnSiguiente);
			this.grbNavegacion.Controls.Add(this.btnAnterior);
			this.grbNavegacion.Controls.Add(this.btnPrimero);
			this.grbNavegacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.grbNavegacion.Location = new System.Drawing.Point(12, 93);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(316, 63);
			this.grbNavegacion.TabIndex = 9;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(130, 24);
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
			this.btnSiguiente.Location = new System.Drawing.Point(198, 19);
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
			// grbEdiciondeMeses
			// 
			this.grbEdiciondeMeses.BackColor = System.Drawing.Color.Transparent;
			this.grbEdiciondeMeses.Controls.Add(this.btnBuscar);
			this.grbEdiciondeMeses.Controls.Add(this.btnEliminar);
			this.grbEdiciondeMeses.Controls.Add(this.btnModificar);
			this.grbEdiciondeMeses.Controls.Add(this.btnNuevo);
			this.grbEdiciondeMeses.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.grbEdiciondeMeses.Location = new System.Drawing.Point(334, 12);
			this.grbEdiciondeMeses.Name = "grbEdiciondeMeses";
			this.grbEdiciondeMeses.Size = new System.Drawing.Size(71, 144);
			this.grbEdiciondeMeses.TabIndex = 10;
			this.grbEdiciondeMeses.TabStop = false;
			this.grbEdiciondeMeses.Text = "Edición de Meses";
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
			// Meses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(419, 178);
			this.Controls.Add(this.grbEdiciondeMeses);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbMeses);
			this.Name = "Meses";
			this.Text = "Meses";
			this.Load += new System.EventHandler(this.Meses_Load);
			this.grbMeses.ResumeLayout(false);
			this.grbMeses.PerformLayout();
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbEdiciondeMeses.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbMeses;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.Label lblIdMes;
		private System.Windows.Forms.Label lblIdMeses;
		private System.Windows.Forms.GroupBox grbNavegacion;
		private System.Windows.Forms.Label lblnregistros;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox grbEdiciondeMeses;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
	}
}