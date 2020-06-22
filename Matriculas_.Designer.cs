namespace Conversor_A
{
	partial class Matriculas_
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
			System.Windows.Forms.Label idMatriculaLabel;
			System.Windows.Forms.Label codigoLabel;
			System.Windows.Forms.Label nombreAlumnoLabel;
			System.Windows.Forms.Label fechaMatriculaLabel;
			this.baseEscuelaDataSet = new Conversor_A.BaseEscuelaDataSet();
			this.dMatriculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dMatriculasTableAdapter = new Conversor_A.BaseEscuelaDataSetTableAdapters.dMatriculasTableAdapter();
			this.tableAdapterManager = new Conversor_A.BaseEscuelaDataSetTableAdapters.TableAdapterManager();
			this.idMatriculaLabel1 = new System.Windows.Forms.Label();
			this.codigoTextBox = new System.Windows.Forms.TextBox();
			this.nombreAlumnoComboBox = new System.Windows.Forms.ComboBox();
			this.fechaMatriculaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.dMatriculasDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			idMatriculaLabel = new System.Windows.Forms.Label();
			codigoLabel = new System.Windows.Forms.Label();
			nombreAlumnoLabel = new System.Windows.Forms.Label();
			fechaMatriculaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.baseEscuelaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dMatriculasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dMatriculasDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// idMatriculaLabel
			// 
			idMatriculaLabel.AutoSize = true;
			idMatriculaLabel.Location = new System.Drawing.Point(36, 30);
			idMatriculaLabel.Name = "idMatriculaLabel";
			idMatriculaLabel.Size = new System.Drawing.Size(67, 13);
			idMatriculaLabel.TabIndex = 0;
			idMatriculaLabel.Text = "ID Matricula:";
			// 
			// codigoLabel
			// 
			codigoLabel.AutoSize = true;
			codigoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			codigoLabel.Location = new System.Drawing.Point(12, 73);
			codigoLabel.Name = "codigoLabel";
			codigoLabel.Size = new System.Drawing.Size(52, 16);
			codigoLabel.TabIndex = 4;
			codigoLabel.Text = "Código:";
			// 
			// nombreAlumnoLabel
			// 
			nombreAlumnoLabel.AutoSize = true;
			nombreAlumnoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nombreAlumnoLabel.Location = new System.Drawing.Point(153, 75);
			nombreAlumnoLabel.Name = "nombreAlumnoLabel";
			nombreAlumnoLabel.Size = new System.Drawing.Size(56, 16);
			nombreAlumnoLabel.TabIndex = 6;
			nombreAlumnoLabel.Text = "Alumno:";
			// 
			// fechaMatriculaLabel
			// 
			fechaMatriculaLabel.AutoSize = true;
			fechaMatriculaLabel.Location = new System.Drawing.Point(365, 27);
			fechaMatriculaLabel.Name = "fechaMatriculaLabel";
			fechaMatriculaLabel.Size = new System.Drawing.Size(101, 13);
			fechaMatriculaLabel.TabIndex = 20;
			fechaMatriculaLabel.Text = "Fecha de Matricula:";
			// 
			// baseEscuelaDataSet
			// 
			this.baseEscuelaDataSet.DataSetName = "BaseEscuelaDataSet";
			this.baseEscuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dMatriculasBindingSource
			// 
			this.dMatriculasBindingSource.DataMember = "dMatriculas";
			this.dMatriculasBindingSource.DataSource = this.baseEscuelaDataSet;
			// 
			// dMatriculasTableAdapter
			// 
			this.dMatriculasTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AlumnosTableAdapter = null;
			this.tableAdapterManager.AsistenciasTableAdapter = null;
			this.tableAdapterManager.AulasTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.dNotasTableAdapter = null;
			this.tableAdapterManager.DocentesTableAdapter = null;
			this.tableAdapterManager.GradosTableAdapter = null;
			this.tableAdapterManager.MateriasTableAdapter = null;
			this.tableAdapterManager.MatriculasTableAdapter = null;
			this.tableAdapterManager.MesesTableAdapter = null;
			this.tableAdapterManager.NotasTableAdapter = null;
			this.tableAdapterManager.pagaDocenteTableAdapter = null;
			this.tableAdapterManager.ResponsablesTableAdapter = null;
			this.tableAdapterManager.SeccionesTableAdapter = null;
			this.tableAdapterManager.TAulaTableAdapter = null;
			this.tableAdapterManager.TrimestresTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Conversor_A.BaseEscuelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// idMatriculaLabel1
			// 
			this.idMatriculaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMatriculasBindingSource, "idMatricula", true));
			this.idMatriculaLabel1.Location = new System.Drawing.Point(106, 24);
			this.idMatriculaLabel1.Name = "idMatriculaLabel1";
			this.idMatriculaLabel1.Size = new System.Drawing.Size(86, 23);
			this.idMatriculaLabel1.TabIndex = 1;
			// 
			// codigoTextBox
			// 
			this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMatriculasBindingSource, "codigo", true));
			this.codigoTextBox.Location = new System.Drawing.Point(70, 72);
			this.codigoTextBox.Name = "codigoTextBox";
			this.codigoTextBox.Size = new System.Drawing.Size(77, 20);
			this.codigoTextBox.TabIndex = 5;
			// 
			// nombreAlumnoComboBox
			// 
			this.nombreAlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dMatriculasBindingSource, "idAlumno", true));
			this.nombreAlumnoComboBox.DataSource = this.dMatriculasBindingSource;
			this.nombreAlumnoComboBox.DisplayMember = "nombreAlumno";
			this.nombreAlumnoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nombreAlumnoComboBox.FormattingEnabled = true;
			this.nombreAlumnoComboBox.Location = new System.Drawing.Point(215, 73);
			this.nombreAlumnoComboBox.Name = "nombreAlumnoComboBox";
			this.nombreAlumnoComboBox.Size = new System.Drawing.Size(330, 21);
			this.nombreAlumnoComboBox.TabIndex = 7;
			this.nombreAlumnoComboBox.ValueMember = "idAlumno";
			// 
			// fechaMatriculaDateTimePicker
			// 
			this.fechaMatriculaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dMatriculasBindingSource, "fechaMatricula", true));
			this.fechaMatriculaDateTimePicker.Location = new System.Drawing.Point(472, 24);
			this.fechaMatriculaDateTimePicker.Name = "fechaMatriculaDateTimePicker";
			this.fechaMatriculaDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechaMatriculaDateTimePicker.TabIndex = 21;
			// 
			// dMatriculasDataGridView
			// 
			this.dMatriculasDataGridView.AutoGenerateColumns = false;
			this.dMatriculasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dMatriculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dMatriculasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11});
			this.dMatriculasDataGridView.DataSource = this.dMatriculasBindingSource;
			this.dMatriculasDataGridView.Location = new System.Drawing.Point(15, 129);
			this.dMatriculasDataGridView.Name = "dMatriculasDataGridView";
			this.dMatriculasDataGridView.Size = new System.Drawing.Size(773, 220);
			this.dMatriculasDataGridView.TabIndex = 21;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idMatricula";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID Matricula";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 75;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "idAlumno";
			this.dataGridViewTextBoxColumn2.HeaderText = "idAlumno";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo";
			this.dataGridViewTextBoxColumn3.HeaderText = "codigo";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "nombreAlumno";
			this.dataGridViewTextBoxColumn4.HeaderText = "nombreAlumno";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "idResponsable";
			this.dataGridViewTextBoxColumn5.HeaderText = "idResponsable";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "nombreResponsable";
			this.dataGridViewTextBoxColumn6.HeaderText = "Responsable";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 200;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "direccion";
			this.dataGridViewTextBoxColumn12.HeaderText = "Dirección";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.Width = 175;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "telefono";
			this.dataGridViewTextBoxColumn13.HeaderText = "Teléfono";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "nombreGrado";
			this.dataGridViewTextBoxColumn8.HeaderText = "Grado";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "nombreSeccion";
			this.dataGridViewTextBoxColumn10.HeaderText = "Sección";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "idGrado";
			this.dataGridViewTextBoxColumn7.HeaderText = "idGrado";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "idSeccion";
			this.dataGridViewTextBoxColumn9.HeaderText = "idSeccion";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Visible = false;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "fechaMatricula";
			this.dataGridViewTextBoxColumn11.HeaderText = "fechaMatricula";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Visible = false;
			// 
			// Matriculas_
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Conversor_A.Properties.Resources.fondo_del_aqua_7733781;
			this.ClientSize = new System.Drawing.Size(800, 460);
			this.Controls.Add(this.dMatriculasDataGridView);
			this.Controls.Add(idMatriculaLabel);
			this.Controls.Add(this.idMatriculaLabel1);
			this.Controls.Add(codigoLabel);
			this.Controls.Add(this.codigoTextBox);
			this.Controls.Add(nombreAlumnoLabel);
			this.Controls.Add(this.nombreAlumnoComboBox);
			this.Controls.Add(fechaMatriculaLabel);
			this.Controls.Add(this.fechaMatriculaDateTimePicker);
			this.Name = "Matriculas_";
			this.Text = "Matriculas_";
			this.Load += new System.EventHandler(this.Matriculas__Load);
			((System.ComponentModel.ISupportInitialize)(this.baseEscuelaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dMatriculasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dMatriculasDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BaseEscuelaDataSet baseEscuelaDataSet;
		private System.Windows.Forms.BindingSource dMatriculasBindingSource;
		private BaseEscuelaDataSetTableAdapters.dMatriculasTableAdapter dMatriculasTableAdapter;
		private BaseEscuelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Label idMatriculaLabel1;
		private System.Windows.Forms.TextBox codigoTextBox;
		private System.Windows.Forms.ComboBox nombreAlumnoComboBox;
		private System.Windows.Forms.DateTimePicker fechaMatriculaDateTimePicker;
		private System.Windows.Forms.DataGridView dMatriculasDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
	}
}