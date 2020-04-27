namespace Conversor_A
{
	partial class BuscarTutor
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
			this.grdBusquedaAulas = new System.Windows.Forms.DataGridView();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.lblBuscar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAulas)).BeginInit();
			this.SuspendLayout();
			// 
			// grdBusquedaAulas
			// 
			this.grdBusquedaAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaAulas.Location = new System.Drawing.Point(12, 82);
			this.grdBusquedaAulas.Name = "grdBusquedaAulas";
			this.grdBusquedaAulas.Size = new System.Drawing.Size(960, 346);
			this.grdBusquedaAulas.TabIndex = 9;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(547, 443);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(169, 443);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
			this.btnSeleccionar.TabIndex = 7;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(78, 45);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(302, 20);
			this.txtbuscar.TabIndex = 6;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
			// 
			// lblBuscar
			// 
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Location = new System.Drawing.Point(18, 48);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(54, 13);
			this.lblBuscar.TabIndex = 5;
			this.lblBuscar.Text = "BUSCAR:";
			// 
			// BuscarTutor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 510);
			this.Controls.Add(this.grdBusquedaAulas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.lblBuscar);
			this.Name = "BuscarTutor";
			this.Text = "BuscarTutor";
			this.Load += new System.EventHandler(this.BuscarTutor_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAulas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdBusquedaAulas;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label lblBuscar;
	}
}