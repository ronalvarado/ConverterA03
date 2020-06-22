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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutorAula));
			this.tutorAulaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.tutorAulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baseEscuelaDataSet = new Conversor_A.BaseEscuelaDataSet();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tutorAulaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.idTaulaLabel1 = new System.Windows.Forms.Label();
			this.nombreDocenteComboBox = new System.Windows.Forms.ComboBox();
			this.tutorAulaDataGridView = new System.Windows.Forms.DataGridView();
			this.tutorAulaTableAdapter = new Conversor_A.BaseEscuelaDataSetTableAdapters.TutorAulaTableAdapter();
			this.tableAdapterManager = new Conversor_A.BaseEscuelaDataSetTableAdapters.TableAdapterManager();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			idTaulaLabel = new System.Windows.Forms.Label();
			nombreDocenteLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tutorAulaBindingNavigator)).BeginInit();
			this.tutorAulaBindingNavigator.SuspendLayout();
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
			// tutorAulaBindingNavigator
			// 
			this.tutorAulaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tutorAulaBindingNavigator.BindingSource = this.tutorAulaBindingSource;
			this.tutorAulaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tutorAulaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tutorAulaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tutorAulaBindingNavigatorSaveItem});
			this.tutorAulaBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.tutorAulaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tutorAulaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tutorAulaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tutorAulaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tutorAulaBindingNavigator.Name = "tutorAulaBindingNavigator";
			this.tutorAulaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tutorAulaBindingNavigator.Size = new System.Drawing.Size(546, 25);
			this.tutorAulaBindingNavigator.TabIndex = 0;
			this.tutorAulaBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Eliminar";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Posición";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Mover último";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tutorAulaBindingNavigatorSaveItem
			// 
			this.tutorAulaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tutorAulaBindingNavigatorSaveItem.Enabled = false;
			this.tutorAulaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tutorAulaBindingNavigatorSaveItem.Image")));
			this.tutorAulaBindingNavigatorSaveItem.Name = "tutorAulaBindingNavigatorSaveItem";
			this.tutorAulaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tutorAulaBindingNavigatorSaveItem.Text = "Guardar datos";
			// 
			// idTaulaLabel1
			// 
			this.idTaulaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tutorAulaBindingSource, "idTaula", true));
			this.idTaulaLabel1.Location = new System.Drawing.Point(68, 47);
			this.idTaulaLabel1.Name = "idTaulaLabel1";
			this.idTaulaLabel1.Size = new System.Drawing.Size(121, 23);
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
			// frmTutorAula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 461);
			this.Controls.Add(this.tutorAulaDataGridView);
			this.Controls.Add(idTaulaLabel);
			this.Controls.Add(this.idTaulaLabel1);
			this.Controls.Add(nombreDocenteLabel);
			this.Controls.Add(this.nombreDocenteComboBox);
			this.Controls.Add(this.tutorAulaBindingNavigator);
			this.Name = "frmTutorAula";
			this.Text = "frmTutorAula";
			this.Load += new System.EventHandler(this.frmTutorAula_Load);
			((System.ComponentModel.ISupportInitialize)(this.tutorAulaBindingNavigator)).EndInit();
			this.tutorAulaBindingNavigator.ResumeLayout(false);
			this.tutorAulaBindingNavigator.PerformLayout();
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
		private System.Windows.Forms.BindingNavigator tutorAulaBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton tutorAulaBindingNavigatorSaveItem;
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