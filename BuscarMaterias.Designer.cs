namespace Conversor_A
{
	partial class BuscarMaterias
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
			this.grdBusquedaMaterias = new System.Windows.Forms.DataGridView();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.lblBuscar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaMaterias)).BeginInit();
			this.SuspendLayout();
			// 
			// grdBusquedaMaterias
			// 
			this.grdBusquedaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaMaterias.Location = new System.Drawing.Point(9, 49);
			this.grdBusquedaMaterias.Name = "grdBusquedaMaterias";
			this.grdBusquedaMaterias.Size = new System.Drawing.Size(831, 346);
			this.grdBusquedaMaterias.TabIndex = 19;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(544, 410);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(71, 23);
			this.btnCancelar.TabIndex = 18;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(166, 410);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(71, 23);
			this.btnSeleccionar.TabIndex = 17;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(75, 12);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(298, 20);
			this.txtbuscar.TabIndex = 16;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
			// 
			// lblBuscar
			// 
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Location = new System.Drawing.Point(15, 15);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(54, 13);
			this.lblBuscar.TabIndex = 15;
			this.lblBuscar.Text = "BUSCAR:";
			// 
			// BuscarMaterias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 442);
			this.Controls.Add(this.grdBusquedaMaterias);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.lblBuscar);
			this.Name = "BuscarMaterias";
			this.Text = "BuscarMaterias";
			this.Load += new System.EventHandler(this.BuscarMaterias_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaMaterias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdBusquedaMaterias;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label lblBuscar;
	}
}