namespace Conversor_A
{
	partial class BuscarClientes
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.txtbuscarCliente = new System.Windows.Forms.TextBox();
			this.lblbuscar = new System.Windows.Forms.Label();
			this.grdBusquedaClientes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(554, 9);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(77, 31);
			this.btnCancelar.TabIndex = 24;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(458, 9);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 31);
			this.btnSeleccionar.TabIndex = 23;
			this.btnSeleccionar.Text = "SELECCIONAR";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// txtbuscarCliente
			// 
			this.txtbuscarCliente.Location = new System.Drawing.Point(130, 15);
			this.txtbuscarCliente.Margin = new System.Windows.Forms.Padding(1);
			this.txtbuscarCliente.Name = "txtbuscarCliente";
			this.txtbuscarCliente.Size = new System.Drawing.Size(295, 20);
			this.txtbuscarCliente.TabIndex = 22;
			this.txtbuscarCliente.TextChanged += new System.EventHandler(this.txtbuscarDocente_TextChanged);
			// 
			// lblbuscar
			// 
			this.lblbuscar.AutoSize = true;
			this.lblbuscar.Location = new System.Drawing.Point(65, 18);
			this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblbuscar.Name = "lblbuscar";
			this.lblbuscar.Size = new System.Drawing.Size(54, 13);
			this.lblbuscar.TabIndex = 21;
			this.lblbuscar.Text = "BUSCAR:";
			// 
			// grdBusquedaClientes
			// 
			this.grdBusquedaClientes.AllowUserToAddRows = false;
			this.grdBusquedaClientes.AllowUserToDeleteRows = false;
			this.grdBusquedaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaClientes.Location = new System.Drawing.Point(10, 64);
			this.grdBusquedaClientes.Margin = new System.Windows.Forms.Padding(1);
			this.grdBusquedaClientes.Name = "grdBusquedaClientes";
			this.grdBusquedaClientes.ReadOnly = true;
			this.grdBusquedaClientes.RowHeadersWidth = 102;
			this.grdBusquedaClientes.RowTemplate.Height = 40;
			this.grdBusquedaClientes.Size = new System.Drawing.Size(960, 346);
			this.grdBusquedaClientes.TabIndex = 20;
			this.grdBusquedaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBusquedaClientes_CellContentClick);
			// 
			// BuscarClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 424);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.txtbuscarCliente);
			this.Controls.Add(this.lblbuscar);
			this.Controls.Add(this.grdBusquedaClientes);
			this.Name = "BuscarClientes";
			this.Text = "BuscarClientes";
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.TextBox txtbuscarCliente;
		private System.Windows.Forms.Label lblbuscar;
		private System.Windows.Forms.DataGridView grdBusquedaClientes;
	}
}