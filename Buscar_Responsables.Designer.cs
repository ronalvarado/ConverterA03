namespace Conversor_A
{
	partial class Buscar_Responsables
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
			this.grdBusquedaResponsables = new System.Windows.Forms.DataGridView();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.lblbuscar = new System.Windows.Forms.Label();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.IdResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaResponsables)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(493, 428);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(77, 31);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// grdBusquedaResponsables
			// 
			this.grdBusquedaResponsables.AllowUserToAddRows = false;
			this.grdBusquedaResponsables.AllowUserToDeleteRows = false;
			this.grdBusquedaResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaResponsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdResponsable,
            this.codigo,
            this.Datos});
			this.grdBusquedaResponsables.Location = new System.Drawing.Point(10, 65);
			this.grdBusquedaResponsables.Margin = new System.Windows.Forms.Padding(1);
			this.grdBusquedaResponsables.Name = "grdBusquedaResponsables";
			this.grdBusquedaResponsables.ReadOnly = true;
			this.grdBusquedaResponsables.RowHeadersWidth = 102;
			this.grdBusquedaResponsables.RowTemplate.Height = 40;
			this.grdBusquedaResponsables.Size = new System.Drawing.Size(617, 346);
			this.grdBusquedaResponsables.TabIndex = 14;
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(75, 22);
			this.txtbuscar.Margin = new System.Windows.Forms.Padding(1);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(295, 20);
			this.txtbuscar.TabIndex = 13;
			// 
			// lblbuscar
			// 
			this.lblbuscar.AutoSize = true;
			this.lblbuscar.Location = new System.Drawing.Point(10, 25);
			this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblbuscar.Name = "lblbuscar";
			this.lblbuscar.Size = new System.Drawing.Size(54, 13);
			this.lblbuscar.TabIndex = 12;
			this.lblbuscar.Text = "BUSCAR:";
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(397, 428);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(94, 31);
			this.btnSeleccionar.TabIndex = 11;
			this.btnSeleccionar.Text = "SELECCIONAR";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			// 
			// IdResponsable
			// 
			this.IdResponsable.DataPropertyName = "IdResponsable";
			this.IdResponsable.HeaderText = "ID";
			this.IdResponsable.MinimumWidth = 12;
			this.IdResponsable.Name = "IdResponsable";
			this.IdResponsable.ReadOnly = true;
			this.IdResponsable.Visible = false;
			this.IdResponsable.Width = 250;
			// 
			// codigo
			// 
			this.codigo.DataPropertyName = "codigo";
			this.codigo.HeaderText = "CODIGO";
			this.codigo.MinimumWidth = 12;
			this.codigo.Name = "codigo";
			this.codigo.ReadOnly = true;
			this.codigo.Width = 250;
			// 
			// Datos
			// 
			this.Datos.DataPropertyName = "Datos";
			this.Datos.HeaderText = "DATOS";
			this.Datos.MinimumWidth = 12;
			this.Datos.Name = "Datos";
			this.Datos.ReadOnly = true;
			this.Datos.Width = 150;
			// 
			// Buscar_Responsables
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 483);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.grdBusquedaResponsables);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.lblbuscar);
			this.Controls.Add(this.btnSeleccionar);
			this.Name = "Buscar_Responsables";
			this.Text = "Buscar_Responsables";
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaResponsables)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView grdBusquedaResponsables;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdResponsable;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label lblbuscar;
		private System.Windows.Forms.Button btnSeleccionar;
	}
}