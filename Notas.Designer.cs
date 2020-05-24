namespace Conversor_A
{
	partial class Notas
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
			System.Windows.Forms.Label idAlumnoLabel;
			System.Windows.Forms.Label nombre_AlumnoLabel;
			System.Windows.Forms.Label idTrimestreLabel;
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label idMateriaLabel;
			System.Windows.Forms.Label nombre_MateriaLabel;
			System.Windows.Forms.Label idEvaluacionLabel;
			System.Windows.Forms.Label examen_Label;
			System.Windows.Forms.Label actividad1Label;
			System.Windows.Forms.Label actividad2Label;
			System.Windows.Forms.Label notaLabel;
			System.Windows.Forms.Label idNotaLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
			this.notasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proyectoEscuela_DataSet = new Conversor_A.ProyectoEscuela_DataSet();
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
			this.notasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.idAlumnoComboBox = new System.Windows.Forms.ComboBox();
			this.nombre_AlumnoComboBox = new System.Windows.Forms.ComboBox();
			this.idTrimestreComboBox = new System.Windows.Forms.ComboBox();
			this.nombreComboBox = new System.Windows.Forms.ComboBox();
			this.idMateriaComboBox = new System.Windows.Forms.ComboBox();
			this.nombre_MateriaComboBox = new System.Windows.Forms.ComboBox();
			this.idEvaluacionComboBox = new System.Windows.Forms.ComboBox();
			this.examen_TextBox = new System.Windows.Forms.TextBox();
			this.actividad1TextBox = new System.Windows.Forms.TextBox();
			this.actividad2TextBox = new System.Windows.Forms.TextBox();
			this.notaTextBox = new System.Windows.Forms.TextBox();
			this.notasTableAdapter = new Conversor_A.ProyectoEscuela_DataSetTableAdapters.NotasTableAdapter();
			this.tableAdapterManager = new Conversor_A.ProyectoEscuela_DataSetTableAdapters.TableAdapterManager();
			this.idNotaComboBox = new System.Windows.Forms.ComboBox();
			this.notasDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			idAlumnoLabel = new System.Windows.Forms.Label();
			nombre_AlumnoLabel = new System.Windows.Forms.Label();
			idTrimestreLabel = new System.Windows.Forms.Label();
			nombreLabel = new System.Windows.Forms.Label();
			idMateriaLabel = new System.Windows.Forms.Label();
			nombre_MateriaLabel = new System.Windows.Forms.Label();
			idEvaluacionLabel = new System.Windows.Forms.Label();
			examen_Label = new System.Windows.Forms.Label();
			actividad1Label = new System.Windows.Forms.Label();
			actividad2Label = new System.Windows.Forms.Label();
			notaLabel = new System.Windows.Forms.Label();
			idNotaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).BeginInit();
			this.notasBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuela_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// idAlumnoLabel
			// 
			idAlumnoLabel.AutoSize = true;
			idAlumnoLabel.Location = new System.Drawing.Point(57, 67);
			idAlumnoLabel.Name = "idAlumnoLabel";
			idAlumnoLabel.Size = new System.Drawing.Size(57, 13);
			idAlumnoLabel.TabIndex = 2;
			idAlumnoLabel.Text = "Id Alumno:";
			// 
			// nombre_AlumnoLabel
			// 
			nombre_AlumnoLabel.AutoSize = true;
			nombre_AlumnoLabel.Location = new System.Drawing.Point(29, 105);
			nombre_AlumnoLabel.Name = "nombre_AlumnoLabel";
			nombre_AlumnoLabel.Size = new System.Drawing.Size(85, 13);
			nombre_AlumnoLabel.TabIndex = 4;
			nombre_AlumnoLabel.Text = "Nombre Alumno:";
			// 
			// idTrimestreLabel
			// 
			idTrimestreLabel.AutoSize = true;
			idTrimestreLabel.Location = new System.Drawing.Point(298, 67);
			idTrimestreLabel.Name = "idTrimestreLabel";
			idTrimestreLabel.Size = new System.Drawing.Size(65, 13);
			idTrimestreLabel.TabIndex = 6;
			idTrimestreLabel.Text = "Id Trimestre:";
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.Location = new System.Drawing.Point(316, 105);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(47, 13);
			nombreLabel.TabIndex = 8;
			nombreLabel.Text = "Nombre:";
			// 
			// idMateriaLabel
			// 
			idMateriaLabel.AutoSize = true;
			idMateriaLabel.Location = new System.Drawing.Point(552, 67);
			idMateriaLabel.Name = "idMateriaLabel";
			idMateriaLabel.Size = new System.Drawing.Size(57, 13);
			idMateriaLabel.TabIndex = 10;
			idMateriaLabel.Text = "Id Materia:";
			// 
			// nombre_MateriaLabel
			// 
			nombre_MateriaLabel.AutoSize = true;
			nombre_MateriaLabel.Location = new System.Drawing.Point(524, 105);
			nombre_MateriaLabel.Name = "nombre_MateriaLabel";
			nombre_MateriaLabel.Size = new System.Drawing.Size(85, 13);
			nombre_MateriaLabel.TabIndex = 12;
			nombre_MateriaLabel.Text = "Nombre Materia:";
			// 
			// idEvaluacionLabel
			// 
			idEvaluacionLabel.AutoSize = true;
			idEvaluacionLabel.Location = new System.Drawing.Point(39, 145);
			idEvaluacionLabel.Name = "idEvaluacionLabel";
			idEvaluacionLabel.Size = new System.Drawing.Size(75, 13);
			idEvaluacionLabel.TabIndex = 14;
			idEvaluacionLabel.Text = "Id Evaluacion:";
			// 
			// examen_Label
			// 
			examen_Label.AutoSize = true;
			examen_Label.Location = new System.Drawing.Point(12, 216);
			examen_Label.Name = "examen_Label";
			examen_Label.Size = new System.Drawing.Size(51, 13);
			examen_Label.TabIndex = 16;
			examen_Label.Text = "Examen :";
			// 
			// actividad1Label
			// 
			actividad1Label.AutoSize = true;
			actividad1Label.Location = new System.Drawing.Point(189, 216);
			actividad1Label.Name = "actividad1Label";
			actividad1Label.Size = new System.Drawing.Size(60, 13);
			actividad1Label.TabIndex = 18;
			actividad1Label.Text = "Actividad1:";
			// 
			// actividad2Label
			// 
			actividad2Label.AutoSize = true;
			actividad2Label.Location = new System.Drawing.Point(384, 216);
			actividad2Label.Name = "actividad2Label";
			actividad2Label.Size = new System.Drawing.Size(60, 13);
			actividad2Label.TabIndex = 20;
			actividad2Label.Text = "Actividad2:";
			// 
			// notaLabel
			// 
			notaLabel.AutoSize = true;
			notaLabel.Location = new System.Drawing.Point(582, 216);
			notaLabel.Name = "notaLabel";
			notaLabel.Size = new System.Drawing.Size(33, 13);
			notaLabel.TabIndex = 22;
			notaLabel.Text = "Nota:";
			// 
			// idNotaLabel
			// 
			idNotaLabel.AutoSize = true;
			idNotaLabel.Location = new System.Drawing.Point(310, 34);
			idNotaLabel.Name = "idNotaLabel";
			idNotaLabel.Size = new System.Drawing.Size(45, 13);
			idNotaLabel.TabIndex = 24;
			idNotaLabel.Text = "Id Nota:";
			// 
			// notasBindingNavigator
			// 
			this.notasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.notasBindingNavigator.BindingSource = this.notasBindingSource;
			this.notasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.notasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.notasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasBindingNavigatorSaveItem});
			this.notasBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.notasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.notasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.notasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.notasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.notasBindingNavigator.Name = "notasBindingNavigator";
			this.notasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.notasBindingNavigator.Size = new System.Drawing.Size(888, 25);
			this.notasBindingNavigator.TabIndex = 0;
			this.notasBindingNavigator.Text = "bindingNavigator1";
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
			// notasBindingSource
			// 
			this.notasBindingSource.DataMember = "Notas";
			this.notasBindingSource.DataSource = this.proyectoEscuela_DataSet;
			// 
			// proyectoEscuela_DataSet
			// 
			this.proyectoEscuela_DataSet.DataSetName = "ProyectoEscuela_DataSet";
			this.proyectoEscuela_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// notasBindingNavigatorSaveItem
			// 
			this.notasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.notasBindingNavigatorSaveItem.Enabled = false;
			this.notasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasBindingNavigatorSaveItem.Image")));
			this.notasBindingNavigatorSaveItem.Name = "notasBindingNavigatorSaveItem";
			this.notasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.notasBindingNavigatorSaveItem.Text = "Guardar datos";
			// 
			// idAlumnoComboBox
			// 
			this.idAlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdAlumno", true));
			this.idAlumnoComboBox.FormattingEnabled = true;
			this.idAlumnoComboBox.Location = new System.Drawing.Point(145, 64);
			this.idAlumnoComboBox.Name = "idAlumnoComboBox";
			this.idAlumnoComboBox.Size = new System.Drawing.Size(121, 21);
			this.idAlumnoComboBox.TabIndex = 3;
			// 
			// nombre_AlumnoComboBox
			// 
			this.nombre_AlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Nombre_Alumno", true));
			this.nombre_AlumnoComboBox.FormattingEnabled = true;
			this.nombre_AlumnoComboBox.Location = new System.Drawing.Point(145, 102);
			this.nombre_AlumnoComboBox.Name = "nombre_AlumnoComboBox";
			this.nombre_AlumnoComboBox.Size = new System.Drawing.Size(121, 21);
			this.nombre_AlumnoComboBox.TabIndex = 5;
			// 
			// idTrimestreComboBox
			// 
			this.idTrimestreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdTrimestre", true));
			this.idTrimestreComboBox.FormattingEnabled = true;
			this.idTrimestreComboBox.Location = new System.Drawing.Point(387, 64);
			this.idTrimestreComboBox.Name = "idTrimestreComboBox";
			this.idTrimestreComboBox.Size = new System.Drawing.Size(121, 21);
			this.idTrimestreComboBox.TabIndex = 7;
			// 
			// nombreComboBox
			// 
			this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Nombre", true));
			this.nombreComboBox.FormattingEnabled = true;
			this.nombreComboBox.Location = new System.Drawing.Point(387, 102);
			this.nombreComboBox.Name = "nombreComboBox";
			this.nombreComboBox.Size = new System.Drawing.Size(121, 21);
			this.nombreComboBox.TabIndex = 9;
			// 
			// idMateriaComboBox
			// 
			this.idMateriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdMateria", true));
			this.idMateriaComboBox.FormattingEnabled = true;
			this.idMateriaComboBox.Location = new System.Drawing.Point(615, 64);
			this.idMateriaComboBox.Name = "idMateriaComboBox";
			this.idMateriaComboBox.Size = new System.Drawing.Size(121, 21);
			this.idMateriaComboBox.TabIndex = 11;
			// 
			// nombre_MateriaComboBox
			// 
			this.nombre_MateriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Nombre_Materia", true));
			this.nombre_MateriaComboBox.FormattingEnabled = true;
			this.nombre_MateriaComboBox.Location = new System.Drawing.Point(615, 102);
			this.nombre_MateriaComboBox.Name = "nombre_MateriaComboBox";
			this.nombre_MateriaComboBox.Size = new System.Drawing.Size(121, 21);
			this.nombre_MateriaComboBox.TabIndex = 13;
			// 
			// idEvaluacionComboBox
			// 
			this.idEvaluacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdEvaluacion", true));
			this.idEvaluacionComboBox.FormattingEnabled = true;
			this.idEvaluacionComboBox.Location = new System.Drawing.Point(145, 142);
			this.idEvaluacionComboBox.Name = "idEvaluacionComboBox";
			this.idEvaluacionComboBox.Size = new System.Drawing.Size(121, 21);
			this.idEvaluacionComboBox.TabIndex = 15;
			// 
			// examen_TextBox
			// 
			this.examen_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Examen ", true));
			this.examen_TextBox.Location = new System.Drawing.Point(69, 213);
			this.examen_TextBox.Name = "examen_TextBox";
			this.examen_TextBox.Size = new System.Drawing.Size(100, 20);
			this.examen_TextBox.TabIndex = 17;
			// 
			// actividad1TextBox
			// 
			this.actividad1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Actividad1", true));
			this.actividad1TextBox.Location = new System.Drawing.Point(255, 213);
			this.actividad1TextBox.Name = "actividad1TextBox";
			this.actividad1TextBox.Size = new System.Drawing.Size(100, 20);
			this.actividad1TextBox.TabIndex = 19;
			// 
			// actividad2TextBox
			// 
			this.actividad2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Actividad2", true));
			this.actividad2TextBox.Location = new System.Drawing.Point(450, 213);
			this.actividad2TextBox.Name = "actividad2TextBox";
			this.actividad2TextBox.Size = new System.Drawing.Size(100, 20);
			this.actividad2TextBox.TabIndex = 21;
			// 
			// notaTextBox
			// 
			this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "Nota", true));
			this.notaTextBox.Location = new System.Drawing.Point(632, 213);
			this.notaTextBox.Name = "notaTextBox";
			this.notaTextBox.Size = new System.Drawing.Size(100, 20);
			this.notaTextBox.TabIndex = 23;
			// 
			// notasTableAdapter
			// 
			this.notasTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AlumnosTableAdapter = null;
			this.tableAdapterManager.AsistenciasTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.DocentesTableAdapter = null;
			this.tableAdapterManager.EvaluacionTableAdapter = null;
			this.tableAdapterManager.MateriasTableAdapter = null;
			this.tableAdapterManager.MatriculasTableAdapter = null;
			this.tableAdapterManager.MesesTableAdapter = null;
			this.tableAdapterManager.PgaDocentesTableAdapter = null;
			this.tableAdapterManager.ResponsablesTableAdapter = null;
			this.tableAdapterManager.TrimestresTableAdapter = null;
			this.tableAdapterManager.TutordAulaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Conversor_A.ProyectoEscuela_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// idNotaComboBox
			// 
			this.idNotaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "IdNota", true));
			this.idNotaComboBox.FormattingEnabled = true;
			this.idNotaComboBox.Location = new System.Drawing.Point(361, 31);
			this.idNotaComboBox.Name = "idNotaComboBox";
			this.idNotaComboBox.Size = new System.Drawing.Size(121, 21);
			this.idNotaComboBox.TabIndex = 25;
			// 
			// notasDataGridView
			// 
			this.notasDataGridView.AutoGenerateColumns = false;
			this.notasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.notasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11});
			this.notasDataGridView.DataSource = this.notasBindingSource;
			this.notasDataGridView.Location = new System.Drawing.Point(12, 248);
			this.notasDataGridView.Name = "notasDataGridView";
			this.notasDataGridView.Size = new System.Drawing.Size(856, 319);
			this.notasDataGridView.TabIndex = 25;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "IdNota";
			this.dataGridViewTextBoxColumn12.HeaderText = "IdNota";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.Width = 50;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Alumno";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de Alumno";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 300;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
			this.dataGridViewTextBoxColumn4.HeaderText = "Trimestre";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre_Materia";
			this.dataGridViewTextBoxColumn6.HeaderText = "Nombre de Materia";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Actividad1";
			this.dataGridViewTextBoxColumn9.HeaderText = "Actividad1";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 75;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Actividad2";
			this.dataGridViewTextBoxColumn10.HeaderText = "Actividad2";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 75;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Examen ";
			this.dataGridViewTextBoxColumn8.HeaderText = "Examen ";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Width = 60;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Nota";
			this.dataGridViewTextBoxColumn11.HeaderText = "Nota";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Width = 50;
			// 
			// Notas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 587);
			this.Controls.Add(this.notasDataGridView);
			this.Controls.Add(idNotaLabel);
			this.Controls.Add(this.idNotaComboBox);
			this.Controls.Add(notaLabel);
			this.Controls.Add(this.notaTextBox);
			this.Controls.Add(actividad2Label);
			this.Controls.Add(this.actividad2TextBox);
			this.Controls.Add(actividad1Label);
			this.Controls.Add(this.actividad1TextBox);
			this.Controls.Add(examen_Label);
			this.Controls.Add(this.examen_TextBox);
			this.Controls.Add(idEvaluacionLabel);
			this.Controls.Add(this.idEvaluacionComboBox);
			this.Controls.Add(nombre_MateriaLabel);
			this.Controls.Add(this.nombre_MateriaComboBox);
			this.Controls.Add(idMateriaLabel);
			this.Controls.Add(this.idMateriaComboBox);
			this.Controls.Add(nombreLabel);
			this.Controls.Add(this.nombreComboBox);
			this.Controls.Add(idTrimestreLabel);
			this.Controls.Add(this.idTrimestreComboBox);
			this.Controls.Add(nombre_AlumnoLabel);
			this.Controls.Add(this.nombre_AlumnoComboBox);
			this.Controls.Add(idAlumnoLabel);
			this.Controls.Add(this.idAlumnoComboBox);
			this.Controls.Add(this.notasBindingNavigator);
			this.Name = "Notas";
			this.Text = "Notas";
			this.Load += new System.EventHandler(this.Notas_Load);
			((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).EndInit();
			this.notasBindingNavigator.ResumeLayout(false);
			this.notasBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoEscuela_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ProyectoEscuela_DataSet proyectoEscuela_DataSet;
		private System.Windows.Forms.BindingSource notasBindingSource;
		private ProyectoEscuela_DataSetTableAdapters.NotasTableAdapter notasTableAdapter;
		private ProyectoEscuela_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator notasBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton notasBindingNavigatorSaveItem;
		private System.Windows.Forms.ComboBox idAlumnoComboBox;
		private System.Windows.Forms.ComboBox nombre_AlumnoComboBox;
		private System.Windows.Forms.ComboBox idTrimestreComboBox;
		private System.Windows.Forms.ComboBox nombreComboBox;
		private System.Windows.Forms.ComboBox idMateriaComboBox;
		private System.Windows.Forms.ComboBox nombre_MateriaComboBox;
		private System.Windows.Forms.ComboBox idEvaluacionComboBox;
		private System.Windows.Forms.TextBox examen_TextBox;
		private System.Windows.Forms.TextBox actividad1TextBox;
		private System.Windows.Forms.TextBox actividad2TextBox;
		private System.Windows.Forms.TextBox notaTextBox;
		private System.Windows.Forms.ComboBox idNotaComboBox;
		private System.Windows.Forms.DataGridView notasDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
	}
}