namespace Conversor_A
{
	partial class frmeNots
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
			this.grbNotas = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbNavegacion = new System.Windows.Forms.GroupBox();
			this.lblnregistros = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbpagaDocente = new System.Windows.Forms.GroupBox();
			this.lblNota = new System.Windows.Forms.Label();
			this.txtnota = new System.Windows.Forms.TextBox();
			this.txtexamen = new System.Windows.Forms.TextBox();
			this.lblexamen = new System.Windows.Forms.Label();
			this.lblactividad2 = new System.Windows.Forms.Label();
			this.txtactividad2 = new System.Windows.Forms.TextBox();
			this.cboMateria = new System.Windows.Forms.ComboBox();
			this.cboAlumno = new System.Windows.Forms.ComboBox();
			this.txtactividad1 = new System.Windows.Forms.TextBox();
			this.lblactividad1 = new System.Windows.Forms.Label();
			this.lblidMateria = new System.Windows.Forms.Label();
			this.lblidNotas = new System.Windows.Forms.Label();
			this.lblidDocente = new System.Windows.Forms.Label();
			this.grbNotas.SuspendLayout();
			this.grbNavegacion.SuspendLayout();
			this.grbpagaDocente.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbNotas
			// 
			this.grbNotas.BackColor = System.Drawing.Color.Transparent;
			this.grbNotas.Controls.Add(this.btnBuscar);
			this.grbNotas.Controls.Add(this.btnEliminar);
			this.grbNotas.Controls.Add(this.btnModificar);
			this.grbNotas.Controls.Add(this.btnNuevo);
			this.grbNotas.ForeColor = System.Drawing.Color.White;
			this.grbNotas.Location = new System.Drawing.Point(507, 12);
			this.grbNotas.Name = "grbNotas";
			this.grbNotas.Size = new System.Drawing.Size(74, 321);
			this.grbNotas.TabIndex = 18;
			this.grbNotas.TabStop = false;
			this.grbNotas.Text = "Edición de Notas";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(10, 200);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(58, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnEliminar.ForeColor = System.Drawing.Color.Black;
			this.btnEliminar.Location = new System.Drawing.Point(10, 268);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(58, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnModificar.ForeColor = System.Drawing.Color.Black;
			this.btnModificar.Location = new System.Drawing.Point(10, 120);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(58, 23);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Location = new System.Drawing.Point(10, 53);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(58, 23);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// grbNavegacion
			// 
			this.grbNavegacion.BackColor = System.Drawing.Color.Transparent;
			this.grbNavegacion.Controls.Add(this.lblnregistros);
			this.grbNavegacion.Controls.Add(this.btnUltimo);
			this.grbNavegacion.Controls.Add(this.btnSiguiente);
			this.grbNavegacion.Controls.Add(this.btnAnterior);
			this.grbNavegacion.Controls.Add(this.btnPrimero);
			this.grbNavegacion.ForeColor = System.Drawing.Color.White;
			this.grbNavegacion.Location = new System.Drawing.Point(12, 280);
			this.grbNavegacion.Name = "grbNavegacion";
			this.grbNavegacion.Size = new System.Drawing.Size(489, 53);
			this.grbNavegacion.TabIndex = 17;
			this.grbNavegacion.TabStop = false;
			this.grbNavegacion.Text = "Navegación";
			// 
			// lblnregistros
			// 
			this.lblnregistros.AutoSize = true;
			this.lblnregistros.Location = new System.Drawing.Point(242, 24);
			this.lblnregistros.Name = "lblnregistros";
			this.lblnregistros.Size = new System.Drawing.Size(0, 13);
			this.lblnregistros.TabIndex = 7;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.Maroon;
			this.btnUltimo.Location = new System.Drawing.Point(414, 19);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 6;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Maroon;
			this.btnSiguiente.Location = new System.Drawing.Point(302, 19);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 5;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Maroon;
			this.btnAnterior.Location = new System.Drawing.Point(151, 19);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 4;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.Maroon;
			this.btnPrimero.Location = new System.Drawing.Point(38, 19);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 3;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbpagaDocente
			// 
			this.grbpagaDocente.BackColor = System.Drawing.Color.Transparent;
			this.grbpagaDocente.Controls.Add(this.lblNota);
			this.grbpagaDocente.Controls.Add(this.txtnota);
			this.grbpagaDocente.Controls.Add(this.txtexamen);
			this.grbpagaDocente.Controls.Add(this.lblexamen);
			this.grbpagaDocente.Controls.Add(this.lblactividad2);
			this.grbpagaDocente.Controls.Add(this.txtactividad2);
			this.grbpagaDocente.Controls.Add(this.cboMateria);
			this.grbpagaDocente.Controls.Add(this.cboAlumno);
			this.grbpagaDocente.Controls.Add(this.txtactividad1);
			this.grbpagaDocente.Controls.Add(this.lblactividad1);
			this.grbpagaDocente.Controls.Add(this.lblidMateria);
			this.grbpagaDocente.Controls.Add(this.lblidNotas);
			this.grbpagaDocente.Controls.Add(this.lblidDocente);
			this.grbpagaDocente.Enabled = false;
			this.grbpagaDocente.ForeColor = System.Drawing.Color.White;
			this.grbpagaDocente.Location = new System.Drawing.Point(12, 12);
			this.grbpagaDocente.Name = "grbpagaDocente";
			this.grbpagaDocente.Size = new System.Drawing.Size(489, 262);
			this.grbpagaDocente.TabIndex = 16;
			this.grbpagaDocente.TabStop = false;
			this.grbpagaDocente.Text = "Editar Notas";
			// 
			// lblNota
			// 
			this.lblNota.AutoSize = true;
			this.lblNota.Location = new System.Drawing.Point(100, 174);
			this.lblNota.Name = "lblNota";
			this.lblNota.Size = new System.Drawing.Size(33, 13);
			this.lblNota.TabIndex = 15;
			this.lblNota.Text = "Nota:";
			// 
			// txtnota
			// 
			this.txtnota.Location = new System.Drawing.Point(139, 171);
			this.txtnota.Name = "txtnota";
			this.txtnota.Size = new System.Drawing.Size(93, 20);
			this.txtnota.TabIndex = 14;
			// 
			// txtexamen
			// 
			this.txtexamen.Location = new System.Drawing.Point(139, 143);
			this.txtexamen.Name = "txtexamen";
			this.txtexamen.Size = new System.Drawing.Size(93, 20);
			this.txtexamen.TabIndex = 13;
			// 
			// lblexamen
			// 
			this.lblexamen.AutoSize = true;
			this.lblexamen.Location = new System.Drawing.Point(56, 146);
			this.lblexamen.Name = "lblexamen";
			this.lblexamen.Size = new System.Drawing.Size(77, 13);
			this.lblexamen.TabIndex = 12;
			this.lblexamen.Text = "Exámen (30%):";
			// 
			// lblactividad2
			// 
			this.lblactividad2.AutoSize = true;
			this.lblactividad2.Location = new System.Drawing.Point(41, 120);
			this.lblactividad2.Name = "lblactividad2";
			this.lblactividad2.Size = new System.Drawing.Size(92, 13);
			this.lblactividad2.TabIndex = 11;
			this.lblactividad2.Text = "Actividad 2 (35%):";
			// 
			// txtactividad2
			// 
			this.txtactividad2.Location = new System.Drawing.Point(139, 117);
			this.txtactividad2.Name = "txtactividad2";
			this.txtactividad2.Size = new System.Drawing.Size(93, 20);
			this.txtactividad2.TabIndex = 9;
			// 
			// cboMateria
			// 
			this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMateria.FormattingEnabled = true;
			this.cboMateria.Location = new System.Drawing.Point(139, 60);
			this.cboMateria.Name = "cboMateria";
			this.cboMateria.Size = new System.Drawing.Size(298, 21);
			this.cboMateria.TabIndex = 8;
			// 
			// cboAlumno
			// 
			this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAlumno.FormattingEnabled = true;
			this.cboAlumno.Location = new System.Drawing.Point(139, 33);
			this.cboAlumno.Name = "cboAlumno";
			this.cboAlumno.Size = new System.Drawing.Size(298, 21);
			this.cboAlumno.TabIndex = 7;
			// 
			// txtactividad1
			// 
			this.txtactividad1.Location = new System.Drawing.Point(139, 91);
			this.txtactividad1.Name = "txtactividad1";
			this.txtactividad1.Size = new System.Drawing.Size(93, 20);
			this.txtactividad1.TabIndex = 6;
			// 
			// lblactividad1
			// 
			this.lblactividad1.AutoSize = true;
			this.lblactividad1.Location = new System.Drawing.Point(41, 94);
			this.lblactividad1.Name = "lblactividad1";
			this.lblactividad1.Size = new System.Drawing.Size(92, 13);
			this.lblactividad1.TabIndex = 5;
			this.lblactividad1.Text = "Actividad 1 (35%):";
			// 
			// lblidMateria
			// 
			this.lblidMateria.AutoSize = true;
			this.lblidMateria.Location = new System.Drawing.Point(103, 63);
			this.lblidMateria.Name = "lblidMateria";
			this.lblidMateria.Size = new System.Drawing.Size(30, 13);
			this.lblidMateria.TabIndex = 3;
			this.lblidMateria.Text = "Mes:";
			// 
			// lblidNotas
			// 
			this.lblidNotas.AutoSize = true;
			this.lblidNotas.Location = new System.Drawing.Point(446, 36);
			this.lblidNotas.Name = "lblidNotas";
			this.lblidNotas.Size = new System.Drawing.Size(21, 13);
			this.lblidNotas.TabIndex = 1;
			this.lblidNotas.Text = "ID:";
			// 
			// lblidDocente
			// 
			this.lblidDocente.AutoSize = true;
			this.lblidDocente.Location = new System.Drawing.Point(82, 36);
			this.lblidDocente.Name = "lblidDocente";
			this.lblidDocente.Size = new System.Drawing.Size(45, 13);
			this.lblidDocente.TabIndex = 0;
			this.lblidDocente.Text = "Alumno:";
			// 
			// frmeNots
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(592, 344);
			this.Controls.Add(this.grbNotas);
			this.Controls.Add(this.grbNavegacion);
			this.Controls.Add(this.grbpagaDocente);
			this.Name = "frmeNots";
			this.Text = "frmeNots";
			this.Load += new System.EventHandler(this.frmeNots_Load);
			this.grbNotas.ResumeLayout(false);
			this.grbNavegacion.ResumeLayout(false);
			this.grbNavegacion.PerformLayout();
			this.grbpagaDocente.ResumeLayout(false);
			this.grbpagaDocente.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbNotas;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox grbNavegacion;
		private System.Windows.Forms.Label lblnregistros;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox grbpagaDocente;
		private System.Windows.Forms.Label lblNota;
		private System.Windows.Forms.TextBox txtnota;
		private System.Windows.Forms.TextBox txtexamen;
		private System.Windows.Forms.Label lblexamen;
		private System.Windows.Forms.Label lblactividad2;
		private System.Windows.Forms.TextBox txtactividad2;
		private System.Windows.Forms.ComboBox cboMateria;
		private System.Windows.Forms.ComboBox cboAlumno;
		private System.Windows.Forms.TextBox txtactividad1;
		private System.Windows.Forms.Label lblactividad1;
		private System.Windows.Forms.Label lblidMateria;
		private System.Windows.Forms.Label lblidNotas;
		private System.Windows.Forms.Label lblidDocente;
	}
}