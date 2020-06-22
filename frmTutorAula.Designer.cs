namespace Conversor_A
{
	partial class frmTutorAula
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
			System.Windows.Forms.Label idTaulaLabel;
			System.Windows.Forms.Label nombreDocenteLabel;
			this.tutorAulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baseEscuelaDataSet = new Conversor_A.BaseEscuelaDataSet();
			this.idTaulaLabel1 = new System.Windows.Forms.Label();
			this.nombreDocenteComboBox = new System.Windows.Forms.ComboBox();
			this.tutorAulaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tutorAulaTableAdapter = new Conversor_A.BaseEscuelaDataSetTableAdapters.TutorAulaTableAdapter();
			this.tableAdapterManager = new Conversor_A.BaseEscuelaDataSetTableAdapters.TableAdapterManager();
			idTaulaLabel = new System.Windows.Forms.Label();
			nombreDocenteLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tutorAulaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baseEscuelaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tutorAulaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// idTaulaLabel
			// 
			idTaulaLabel.AutoSize = true;
			idTaulaLabel.Location = new System.Drawing.Point(41, 47);
			idTaulaLabel.Name = "idTaulaLabel";
			idTaulaLabel.Size = new System.Drawing.Size(21, 13);
			idTaulaLabel.TabIndex = 1;
			idTaulaLabel.Text = "ID:";
			// 
			// nombreDocenteLabel
			// 
			nombreDocenteLabel.AutoSize = true;
			nombreDocenteLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nombreDocenteLabel.Location = new System.Drawing.Point(26, 73);
			nombreDocenteLabel.Name = "nombreDocenteLabel";
			nombreDocenteLabel.Size = new System.Drawing.Size(85, 17);
			nombreDocenteLabel.TabIndex = 9;
			nombreDocenteLabel.Text = "DOCENTE:";
			// 
			// tutorAulaBindingSource
			// 
			this.tutorAulaBindingSource.DataMember = "TutorAula";
			this.tutorAulaBindingSource.DataSource = this.baseEscuelaDataSet;
			// 
			// baseEscuelaDataSet
			// 
			this.baseEscuelaDataSet.DataSetName = "BaseEscuelaDataSet";
			this.baseEscuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// idTaulaLabel1
			// 
			this.idTaulaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tutorAulaBindingSource, "idTaula", true));
			this.idTaulaLabel1.Location = new System.Drawing.Point(68, 44);
			this.idTaulaLabel1.Name = "idTaulaLabel1";
			this.idTaulaLabel1.Size = new System.Drawing.Size(51, 23);
			this.idTaulaLabel1.TabIndex = 2;
			// 
			// nombreDocenteComboBox
			// 
			this.nombreDocenteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tutorAulaBindingSource, "idDocente", true));
			this.nombreDocenteComboBox.DataSource = this.tutorAulaBindingSource;
			this.nombreDocenteComboBox.DisplayMember = "nombreDocente";
			this.nombreDocenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nombreDocenteComboBox.Enabled = false;
			this.nombreDocenteComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombreDocenteComboBox.FormattingEnabled = true;
			this.nombreDocenteComboBox.Location = new System.Drawing.Point(128, 70);
			this.nombreDocenteComboBox.Name = "nombreDocenteComboBox";
			this.nombreDocenteComboBox.Size = new System.Drawing.Size(341, 25);
			this.nombreDocenteComboBox.TabIndex = 10;
			this.nombreDocenteComboBox.ValueMember = "idDocente";
			// 
			// tutorAulaDataGridView
			// 
			this.tutorAulaDataGridView.AutoGenerateColumns = false;
			this.tutorAulaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.tutorAulaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tutorAulaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
			this.tutorAulaDataGridView.DataSource = this.tutorAulaBindingSource;
			this.tutorAulaDataGridView.Location = new System.Drawing.Point(44, 111);
			this.tutorAulaDataGridView.Name = "tutorAulaDataGridView";
			this.tutorAulaDataGridView.Size = new System.Drawing.Size(450, 254);
			this.tutorAulaDataGridView.TabIndex = 18;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idTaula";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID ";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "nombreAula";
			this.dataGridViewTextBoxColumn3.HeaderText = "Aula";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "nombreDocente";
			this.dataGridViewTextBoxColumn5.HeaderText = "Docente";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Visible = false;
			this.dataGridViewTextBoxColumn5.Width = 300;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "nombreGrado";
			this.dataGridViewTextBoxColumn7.HeaderText = "Grado";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "nombreSeccion";
			this.dataGridViewTextBoxColumn9.HeaderText = "Sección";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// tutorAulaTableAdapter
			// 
			this.tutorAulaTableAdapter.ClearBeforeFill = true;
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
			// frmTutorAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(529, 394);
			this.Controls.Add(this.tutorAulaDataGridView);
			this.Controls.Add(idTaulaLabel);
			this.Controls.Add(this.idTaulaLabel1);
			this.Controls.Add(nombreDocenteLabel);
			this.Controls.Add(this.nombreDocenteComboBox);
			this.Name = "frmTutorAula";
			this.Text = "frmTutorAula";
			this.Load += new System.EventHandler(this.frmTutorAula_Load);
			((System.ComponentModel.ISupportInitialize)(this.tutorAulaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baseEscuelaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tutorAulaDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BaseEscuelaDataSet baseEscuelaDataSet;
		private System.Windows.Forms.BindingSource tutorAulaBindingSource;
		private BaseEscuelaDataSetTableAdapters.TutorAulaTableAdapter tutorAulaTableAdapter;
		private BaseEscuelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Label idTaulaLabel1;
		private System.Windows.Forms.ComboBox nombreDocenteComboBox;
		private System.Windows.Forms.DataGridView tutorAulaDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
	}
}