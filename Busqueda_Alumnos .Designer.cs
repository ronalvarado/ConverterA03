namespace Conversor_A
{
	partial class Busqueda_Alumnos
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
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.grdBusquedaAlumnos = new System.Windows.Forms.DataGridView();
			this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBuscar
			// 
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Location = new System.Drawing.Point(59, 37);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(54, 13);
			this.lblBuscar.TabIndex = 0;
			this.lblBuscar.Text = "BUSCAR:";
			// 
			// txtbuscar
			// 
			this.txtbuscar.Location = new System.Drawing.Point(119, 34);
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.Size = new System.Drawing.Size(302, 20);
			this.txtbuscar.TabIndex = 1;
			this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(267, 441);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
			this.btnSeleccionar.TabIndex = 2;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(362, 441);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// grdBusquedaAlumnos
			// 
			this.grdBusquedaAlumnos.AllowUserToAddRows = false;
			this.grdBusquedaAlumnos.AllowUserToDeleteRows = false;
			this.grdBusquedaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno});
			this.grdBusquedaAlumnos.Location = new System.Drawing.Point(10, 76);
			this.grdBusquedaAlumnos.Margin = new System.Windows.Forms.Padding(1);
			this.grdBusquedaAlumnos.Name = "grdBusquedaAlumnos";
			this.grdBusquedaAlumnos.ReadOnly = true;
			this.grdBusquedaAlumnos.RowHeadersWidth = 102;
			this.grdBusquedaAlumnos.RowTemplate.Height = 40;
			this.grdBusquedaAlumnos.Size = new System.Drawing.Size(537, 346);
			this.grdBusquedaAlumnos.TabIndex = 10;
			// 
			// IdAlumno
			// 
			this.IdAlumno.DataPropertyName = "IdAlumno";
			this.IdAlumno.HeaderText = "ID";
			this.IdAlumno.MinimumWidth = 12;
			this.IdAlumno.Name = "IdAlumno";
			this.IdAlumno.ReadOnly = true;
			this.IdAlumno.Visible = false;
			this.IdAlumno.Width = 250;
			// 
			// Busqueda_Alumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 491);
			this.Controls.Add(this.grdBusquedaAlumnos);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.lblBuscar);
			this.Name = "Busqueda_Alumnos";
			this.Text = "Busqueda_Alumnos";
			this.Load += new System.EventHandler(this.Busqueda_Alumnos_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlumnos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView grdBusquedaAlumnos;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
	}
}