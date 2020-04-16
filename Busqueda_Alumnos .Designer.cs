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
			this.components = new System.ComponentModel.Container();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.txtbuscar = new System.Windows.Forms.TextBox();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.grdBusquedaAlumnos = new System.Windows.Forms.DataGridView();
			this.proyectoEscuelaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proyectoEscuela_DataSet = new Conversor_A.ProyectoEscuela_DataSet();
			this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlumnos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuelaDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuela_DataSet)).BeginInit();
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
			this.btnSeleccionar.Location = new System.Drawing.Point(459, 432);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
			this.btnSeleccionar.TabIndex = 2;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(578, 432);
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
			this.grdBusquedaAlumnos.AutoGenerateColumns = false;
			this.grdBusquedaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdBusquedaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno,
            this.Codigo,
            this.Nombre_Alumno,
            this.Edad,
            this.Direccion,
            this.Telefono,
            this.Grado,
            this.Seccion});
			this.grdBusquedaAlumnos.DataSource = this.proyectoEscuelaDataSetBindingSource;
			this.grdBusquedaAlumnos.Location = new System.Drawing.Point(10, 70);
			this.grdBusquedaAlumnos.Margin = new System.Windows.Forms.Padding(1);
			this.grdBusquedaAlumnos.Name = "grdBusquedaAlumnos";
			this.grdBusquedaAlumnos.ReadOnly = true;
			this.grdBusquedaAlumnos.RowHeadersWidth = 102;
			this.grdBusquedaAlumnos.RowTemplate.Height = 40;
			this.grdBusquedaAlumnos.Size = new System.Drawing.Size(1032, 346);
			this.grdBusquedaAlumnos.TabIndex = 10;
			// 
			// proyectoEscuelaDataSetBindingSource
			// 
			this.proyectoEscuelaDataSetBindingSource.DataSource = this.proyectoEscuela_DataSet;
			this.proyectoEscuelaDataSetBindingSource.Position = 0;
			// 
			// proyectoEscuela_DataSet
			// 
			this.proyectoEscuela_DataSet.DataSetName = "ProyectoEscuela_DataSet";
			this.proyectoEscuela_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// IdAlumno
			// 
			this.IdAlumno.DataPropertyName = "IdAlumno";
			this.IdAlumno.HeaderText = "ID";
			this.IdAlumno.MinimumWidth = 12;
			this.IdAlumno.Name = "IdAlumno";
			this.IdAlumno.ReadOnly = true;
			this.IdAlumno.Width = 250;
			// 
			// Codigo
			// 
			this.Codigo.DataPropertyName = "Codigo";
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Nombre_Alumno
			// 
			this.Nombre_Alumno.DataPropertyName = "Nombre_Alumno";
			this.Nombre_Alumno.HeaderText = "Nombre";
			this.Nombre_Alumno.Name = "Nombre_Alumno";
			this.Nombre_Alumno.ReadOnly = true;
			// 
			// Edad
			// 
			this.Edad.DataPropertyName = "Edad";
			this.Edad.HeaderText = "Edad";
			this.Edad.Name = "Edad";
			this.Edad.ReadOnly = true;
			// 
			// Direccion
			// 
			this.Direccion.DataPropertyName = "Direccion";
			this.Direccion.HeaderText = "Dirección";
			this.Direccion.Name = "Direccion";
			this.Direccion.ReadOnly = true;
			// 
			// Telefono
			// 
			this.Telefono.DataPropertyName = "Telefono";
			this.Telefono.HeaderText = "Teléfono";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			// 
			// Grado
			// 
			this.Grado.DataPropertyName = "Grado";
			this.Grado.HeaderText = "Grado";
			this.Grado.Name = "Grado";
			this.Grado.ReadOnly = true;
			// 
			// Seccion
			// 
			this.Seccion.DataPropertyName = "Seccion";
			this.Seccion.HeaderText = "Sección";
			this.Seccion.Name = "Seccion";
			this.Seccion.ReadOnly = true;
			// 
			// Busqueda_Alumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1056, 491);
			this.Controls.Add(this.grdBusquedaAlumnos);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.txtbuscar);
			this.Controls.Add(this.lblBuscar);
			this.Name = "Busqueda_Alumnos";
			this.Text = "Busqueda_Alumnos";
			this.Load += new System.EventHandler(this.Busqueda_Alumnos_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlumnos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuelaDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuela_DataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView grdBusquedaAlumnos;
		private System.Windows.Forms.BindingSource proyectoEscuelaDataSetBindingSource;
		private ProyectoEscuela_DataSet proyectoEscuela_DataSet;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Alumno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
	}
}