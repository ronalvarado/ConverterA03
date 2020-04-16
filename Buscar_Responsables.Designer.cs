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
			this.components = new System.ComponentModel.Container();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.grdBusquedaResponsables = new System.Windows.Forms.DataGridView();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.lblbuscar = new System.Windows.Forms.Label();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.proyectoEscuela_DataSet1 = new Conversor_A.ProyectoEscuela_DataSet1();
			this.responsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.responsablesTableAdapter = new Conversor_A.ProyectoEscuela_DataSet1TableAdapters.ResponsablesTableAdapter();
			this.IdResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idResponsablesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaResponsables)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuela_DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.responsablesBindingSource)).BeginInit();
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
			this.grdBusquedaResponsables.AutoGenerateColumns = false;
			this.grdBusquedaResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaResponsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdResponsable,
            this.codigo,
            this.idResponsablesDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
			this.grdBusquedaResponsables.DataSource = this.responsablesBindingSource;
			this.grdBusquedaResponsables.Location = new System.Drawing.Point(10, 65);
			this.grdBusquedaResponsables.Margin = new System.Windows.Forms.Padding(1);
			this.grdBusquedaResponsables.Name = "grdBusquedaResponsables";
			this.grdBusquedaResponsables.ReadOnly = true;
			this.grdBusquedaResponsables.RowHeadersWidth = 102;
			this.grdBusquedaResponsables.RowTemplate.Height = 40;
			this.grdBusquedaResponsables.Size = new System.Drawing.Size(960, 346);
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
			// proyectoEscuela_DataSet1
			// 
			this.proyectoEscuela_DataSet1.DataSetName = "ProyectoEscuela_DataSet1";
			this.proyectoEscuela_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// responsablesBindingSource
			// 
			this.responsablesBindingSource.DataMember = "Responsables";
			this.responsablesBindingSource.DataSource = this.proyectoEscuela_DataSet1;
			// 
			// responsablesTableAdapter
			// 
			this.responsablesTableAdapter.ClearBeforeFill = true;
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
			this.codigo.HeaderText = "Código";
			this.codigo.MinimumWidth = 12;
			this.codigo.Name = "codigo";
			this.codigo.ReadOnly = true;
			this.codigo.Width = 250;
			// 
			// idResponsablesDataGridViewTextBoxColumn
			// 
			this.idResponsablesDataGridViewTextBoxColumn.DataPropertyName = "IdResponsables";
			this.idResponsablesDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.idResponsablesDataGridViewTextBoxColumn.Name = "idResponsablesDataGridViewTextBoxColumn";
			this.idResponsablesDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// edadDataGridViewTextBoxColumn
			// 
			this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
			this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
			this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
			this.edadDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// direccionDataGridViewTextBoxColumn
			// 
			this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion ";
			this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
			this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
			this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dUIDataGridViewTextBoxColumn
			// 
			this.dUIDataGridViewTextBoxColumn.DataPropertyName = "DUI";
			this.dUIDataGridViewTextBoxColumn.HeaderText = "DUI";
			this.dUIDataGridViewTextBoxColumn.Name = "dUIDataGridViewTextBoxColumn";
			this.dUIDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nITDataGridViewTextBoxColumn
			// 
			this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
			this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
			this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
			this.nITDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telefonoDataGridViewTextBoxColumn
			// 
			this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
			this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
			this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
			this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Buscar_Responsables
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 483);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.grdBusquedaResponsables);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.lblbuscar);
			this.Controls.Add(this.btnSeleccionar);
			this.Name = "Buscar_Responsables";
			this.Text = "Buscar_Responsables";
			this.Load += new System.EventHandler(this.Buscar_Responsables_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaResponsables)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuela_DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.responsablesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView grdBusquedaResponsables;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Label lblbuscar;
		private System.Windows.Forms.Button btnSeleccionar;
		private ProyectoEscuela_DataSet1 proyectoEscuela_DataSet1;
		private System.Windows.Forms.BindingSource responsablesBindingSource;
		private ProyectoEscuela_DataSet1TableAdapters.ResponsablesTableAdapter responsablesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdResponsable;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn idResponsablesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
	}
}