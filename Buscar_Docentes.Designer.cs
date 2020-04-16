namespace Conversor_A
{
	partial class Buscar_Docentes
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
			this.grdBusquedaDocentes = new System.Windows.Forms.DataGridView();
			this.txtbuscarDocente = new System.Windows.Forms.TextBox();
			this.lblbuscar = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaDocentes)).BeginInit();
			this.SuspendLayout();
			// 
			// grdBusquedaDocentes
			// 
			this.grdBusquedaDocentes.AllowUserToAddRows = false;
			this.grdBusquedaDocentes.AllowUserToDeleteRows = false;
			this.grdBusquedaDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaDocentes.Location = new System.Drawing.Point(10, 75);
			this.grdBusquedaDocentes.Margin = new System.Windows.Forms.Padding(1);
			this.grdBusquedaDocentes.Name = "grdBusquedaDocentes";
			this.grdBusquedaDocentes.ReadOnly = true;
			this.grdBusquedaDocentes.RowHeadersWidth = 102;
			this.grdBusquedaDocentes.RowTemplate.Height = 40;
			this.grdBusquedaDocentes.Size = new System.Drawing.Size(960, 346);
			this.grdBusquedaDocentes.TabIndex = 15;
			
			// 
			// txtbuscarDocente
			// 
			this.txtbuscarDocente.Location = new System.Drawing.Point(130, 26);
			this.txtbuscarDocente.Margin = new System.Windows.Forms.Padding(1);
			this.txtbuscarDocente.Name = "txtbuscarDocente";
			this.txtbuscarDocente.Size = new System.Drawing.Size(295, 20);
			this.txtbuscarDocente.TabIndex = 17;
			this.txtbuscarDocente.TextChanged += new System.EventHandler(this.txtbuscarDocente_TextChanged);
			// 
			// lblbuscar
			// 
			this.lblbuscar.AutoSize = true;
			this.lblbuscar.Location = new System.Drawing.Point(65, 29);
			this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblbuscar.Name = "lblbuscar";
			this.lblbuscar.Size = new System.Drawing.Size(54, 13);
			this.lblbuscar.TabIndex = 16;
			this.lblbuscar.Text = "BUSCAR:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(502, 434);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(77, 31);
			this.btnCancelar.TabIndex = 19;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(388, 434);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 31);
			this.btnSeleccionar.TabIndex = 18;
			this.btnSeleccionar.Text = "SELECCIONAR";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// Buscar_Docentes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 475);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.txtbuscarDocente);
			this.Controls.Add(this.lblbuscar);
			this.Controls.Add(this.grdBusquedaDocentes);
			this.Name = "Buscar_Docentes";
			this.Text = "Buscar_Docentes";
			this.Load += new System.EventHandler(this.Buscar_Docentes_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaDocentes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdBusquedaDocentes;
		private System.Windows.Forms.TextBox txtbuscarDocente;
		private System.Windows.Forms.Label lblbuscar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
	}
}