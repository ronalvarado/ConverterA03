namespace Conversor_A
{
	partial class frmANotas
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
			System.Windows.Forms.Label idNotaLabel;
			System.Windows.Forms.Label nombreMateriaLabel;
			System.Windows.Forms.Label nombreTrimestreLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmANotas));
			System.Windows.Forms.Label idMateriaLabel1;
			System.Windows.Forms.Label idTrimestreLabel1;
			this.baseEscuelaDataSet = new Conversor_A.BaseEscuelaDataSet();
			this.aNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.aNotasTableAdapter = new Conversor_A.BaseEscuelaDataSetTableAdapters.ANotasTableAdapter();
			this.tableAdapterManager = new Conversor_A.BaseEscuelaDataSetTableAdapters.TableAdapterManager();
			this.aNotasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.idNotaLabel1 = new System.Windows.Forms.Label();
			this.nombreMateriaComboBox = new System.Windows.Forms.ComboBox();
			this.nombreTrimestreComboBox = new System.Windows.Forms.ComboBox();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.aNotasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.idMateriaLabel2 = new System.Windows.Forms.Label();
			this.idTrimestreLabel2 = new System.Windows.Forms.Label();
			this.aNotasDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			idNotaLabel = new System.Windows.Forms.Label();
			nombreMateriaLabel = new System.Windows.Forms.Label();
			nombreTrimestreLabel = new System.Windows.Forms.Label();
			idMateriaLabel1 = new System.Windows.Forms.Label();
			idTrimestreLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.baseEscuelaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aNotasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aNotasBindingNavigator)).BeginInit();
			this.aNotasBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aNotasDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// baseEscuelaDataSet
			// 
			this.baseEscuelaDataSet.DataSetName = "BaseEscuelaDataSet";
			this.baseEscuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// aNotasBindingSource
			// 
			this.aNotasBindingSource.DataMember = "ANotas";
			this.aNotasBindingSource.DataSource = this.baseEscuelaDataSet;
			// 
			// aNotasTableAdapter
			// 
			this.aNotasTableAdapter.ClearBeforeFill = true;
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
			// aNotasBindingNavigator
			// 
			this.aNotasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.aNotasBindingNavigator.BindingSource = this.aNotasBindingSource;
			this.aNotasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.aNotasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.aNotasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aNotasBindingNavigatorSaveItem});
			this.aNotasBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.aNotasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.aNotasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.aNotasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.aNotasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.aNotasBindingNavigator.Name = "aNotasBindingNavigator";
			this.aNotasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.aNotasBindingNavigator.Size = new System.Drawing.Size(699, 25);
			this.aNotasBindingNavigator.TabIndex = 0;
			this.aNotasBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// idNotaLabel
			// 
			idNotaLabel.AutoSize = true;
			idNotaLabel.Location = new System.Drawing.Point(12, 45);
			idNotaLabel.Name = "idNotaLabel";
			idNotaLabel.Size = new System.Drawing.Size(47, 13);
			idNotaLabel.TabIndex = 1;
			idNotaLabel.Text = "ID Nota:";
			// 
			// idNotaLabel1
			// 
			this.idNotaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aNotasBindingSource, "idNota", true));
			this.idNotaLabel1.Location = new System.Drawing.Point(65, 41);
			this.idNotaLabel1.Name = "idNotaLabel1";
			this.idNotaLabel1.Size = new System.Drawing.Size(55, 23);
			this.idNotaLabel1.TabIndex = 2;
			// 
			// nombreMateriaLabel
			// 
			nombreMateriaLabel.AutoSize = true;
			nombreMateriaLabel.Location = new System.Drawing.Point(12, 133);
			nombreMateriaLabel.Name = "nombreMateriaLabel";
			nombreMateriaLabel.Size = new System.Drawing.Size(45, 13);
			nombreMateriaLabel.TabIndex = 13;
			nombreMateriaLabel.Text = "Materia:";
			// 
			// nombreMateriaComboBox
			// 
			this.nombreMateriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aNotasBindingSource, "nombreMateria", true));
			this.nombreMateriaComboBox.DataSource = this.aNotasBindingSource;
			this.nombreMateriaComboBox.DisplayMember = "nombreMateria";
			this.nombreMateriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nombreMateriaComboBox.FormattingEnabled = true;
			this.nombreMateriaComboBox.Location = new System.Drawing.Point(79, 130);
			this.nombreMateriaComboBox.Name = "nombreMateriaComboBox";
			this.nombreMateriaComboBox.Size = new System.Drawing.Size(293, 21);
			this.nombreMateriaComboBox.TabIndex = 14;
			this.nombreMateriaComboBox.ValueMember = "idMateria";
			// 
			// nombreTrimestreLabel
			// 
			nombreTrimestreLabel.AutoSize = true;
			nombreTrimestreLabel.Location = new System.Drawing.Point(409, 133);
			nombreTrimestreLabel.Name = "nombreTrimestreLabel";
			nombreTrimestreLabel.Size = new System.Drawing.Size(53, 13);
			nombreTrimestreLabel.TabIndex = 17;
			nombreTrimestreLabel.Text = "Trimestre:";
			// 
			// nombreTrimestreComboBox
			// 
			this.nombreTrimestreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aNotasBindingSource, "idTrimestre", true));
			this.nombreTrimestreComboBox.DataSource = this.aNotasBindingSource;
			this.nombreTrimestreComboBox.DisplayMember = "nombreTrimestre";
			this.nombreTrimestreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nombreTrimestreComboBox.FormattingEnabled = true;
			this.nombreTrimestreComboBox.Location = new System.Drawing.Point(468, 130);
			this.nombreTrimestreComboBox.Name = "nombreTrimestreComboBox";
			this.nombreTrimestreComboBox.Size = new System.Drawing.Size(121, 21);
			this.nombreTrimestreComboBox.TabIndex = 18;
			this.nombreTrimestreComboBox.ValueMember = "idTrimestre";
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
			// aNotasBindingNavigatorSaveItem
			// 
			this.aNotasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aNotasBindingNavigatorSaveItem.Enabled = false;
			this.aNotasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aNotasBindingNavigatorSaveItem.Image")));
			this.aNotasBindingNavigatorSaveItem.Name = "aNotasBindingNavigatorSaveItem";
			this.aNotasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.aNotasBindingNavigatorSaveItem.Text = "Guardar datos";
			// 
			// idMateriaLabel1
			// 
			idMateriaLabel1.AutoSize = true;
			idMateriaLabel1.Location = new System.Drawing.Point(12, 91);
			idMateriaLabel1.Name = "idMateriaLabel1";
			idMateriaLabel1.Size = new System.Drawing.Size(59, 13);
			idMateriaLabel1.TabIndex = 24;
			idMateriaLabel1.Text = "ID Materia:";
			// 
			// idMateriaLabel2
			// 
			this.idMateriaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.idMateriaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aNotasBindingSource, "idMateria", true));
			this.idMateriaLabel2.Location = new System.Drawing.Point(77, 86);
			this.idMateriaLabel2.Name = "idMateriaLabel2";
			this.idMateriaLabel2.Size = new System.Drawing.Size(43, 23);
			this.idMateriaLabel2.TabIndex = 25;
			// 
			// idTrimestreLabel1
			// 
			idTrimestreLabel1.AutoSize = true;
			idTrimestreLabel1.Location = new System.Drawing.Point(409, 91);
			idTrimestreLabel1.Name = "idTrimestreLabel1";
			idTrimestreLabel1.Size = new System.Drawing.Size(67, 13);
			idTrimestreLabel1.TabIndex = 25;
			idTrimestreLabel1.Text = "ID Trimestre:";
			// 
			// idTrimestreLabel2
			// 
			this.idTrimestreLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.idTrimestreLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aNotasBindingSource, "idTrimestre", true));
			this.idTrimestreLabel2.Location = new System.Drawing.Point(482, 86);
			this.idTrimestreLabel2.Name = "idTrimestreLabel2";
			this.idTrimestreLabel2.Size = new System.Drawing.Size(36, 23);
			this.idTrimestreLabel2.TabIndex = 26;
			// 
			// aNotasDataGridView
			// 
			this.aNotasDataGridView.AutoGenerateColumns = false;
			this.aNotasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.aNotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.aNotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
			this.aNotasDataGridView.DataSource = this.aNotasBindingSource;
			this.aNotasDataGridView.Location = new System.Drawing.Point(12, 183);
			this.aNotasDataGridView.Name = "aNotasDataGridView";
			this.aNotasDataGridView.Size = new System.Drawing.Size(671, 220);
			this.aNotasDataGridView.TabIndex = 26;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idNota";
			this.dataGridViewTextBoxColumn1.HeaderText = "idNota";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "nombreAlumno";
			this.dataGridViewTextBoxColumn11.HeaderText = "Alumno";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Width = 250;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "actividad1";
			this.dataGridViewTextBoxColumn2.HeaderText = "Actividad1";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "actividad2";
			this.dataGridViewTextBoxColumn3.HeaderText = "Actividad2";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "examen ";
			this.dataGridViewTextBoxColumn4.HeaderText = "Exámen ";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "nota";
			this.dataGridViewTextBoxColumn5.HeaderText = "Nota";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 75;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "idMateria";
			this.dataGridViewTextBoxColumn6.HeaderText = "idMateria";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Visible = false;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "nombreMateria";
			this.dataGridViewTextBoxColumn7.HeaderText = "nombreMateria";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "idTrimestre";
			this.dataGridViewTextBoxColumn8.HeaderText = "idTrimestre";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Visible = false;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "nombreTrimestre";
			this.dataGridViewTextBoxColumn9.HeaderText = "nombreTrimestre";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Visible = false;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "idAlumno";
			this.dataGridViewTextBoxColumn10.HeaderText = "idAlumno";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Visible = false;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "Expr1";
			this.dataGridViewTextBoxColumn12.HeaderText = "Expr1";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Visible = false;
			// 
			// frmANotas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Conversor_A.Properties.Resources.fondo_del_aqua_7733781;
			this.ClientSize = new System.Drawing.Size(699, 487);
			this.Controls.Add(this.aNotasDataGridView);
			this.Controls.Add(idTrimestreLabel1);
			this.Controls.Add(this.idTrimestreLabel2);
			this.Controls.Add(idMateriaLabel1);
			this.Controls.Add(this.idMateriaLabel2);
			this.Controls.Add(idNotaLabel);
			this.Controls.Add(this.idNotaLabel1);
			this.Controls.Add(nombreMateriaLabel);
			this.Controls.Add(this.nombreMateriaComboBox);
			this.Controls.Add(nombreTrimestreLabel);
			this.Controls.Add(this.nombreTrimestreComboBox);
			this.Controls.Add(this.aNotasBindingNavigator);
			this.Name = "frmANotas";
			this.Text = "frmANotas";
			this.Load += new System.EventHandler(this.frmANotas_Load);
			((System.ComponentModel.ISupportInitialize)(this.baseEscuelaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aNotasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aNotasBindingNavigator)).EndInit();
			this.aNotasBindingNavigator.ResumeLayout(false);
			this.aNotasBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aNotasDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BaseEscuelaDataSet baseEscuelaDataSet;
		private System.Windows.Forms.BindingSource aNotasBindingSource;
		private BaseEscuelaDataSetTableAdapters.ANotasTableAdapter aNotasTableAdapter;
		private BaseEscuelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator aNotasBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton aNotasBindingNavigatorSaveItem;
		private System.Windows.Forms.Label idNotaLabel1;
		private System.Windows.Forms.ComboBox nombreMateriaComboBox;
		private System.Windows.Forms.ComboBox nombreTrimestreComboBox;
		private System.Windows.Forms.Label idMateriaLabel2;
		private System.Windows.Forms.Label idTrimestreLabel2;
		private System.Windows.Forms.DataGridView aNotasDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
	}
}