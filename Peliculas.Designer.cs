namespace Conversor_A
{
	partial class Peliculas
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
			this.grbNavegar = new System.Windows.Forms.GroupBox();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbEdicionPeliculas = new System.Windows.Forms.GroupBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbPeliculas = new System.Windows.Forms.GroupBox();
			this.txtDuracion = new System.Windows.Forms.TextBox();
			this.lblDuracion = new System.Windows.Forms.Label();
			this.txtGenero = new System.Windows.Forms.TextBox();
			this.txtSipnosis = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblIdPelicula = new System.Windows.Forms.Label();
			this.lblGenero = new System.Windows.Forms.Label();
			this.lblSipnosis = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.grbNavegar.SuspendLayout();
			this.grbEdicionPeliculas.SuspendLayout();
			this.grbPeliculas.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbNavegar
			// 
			this.grbNavegar.BackColor = System.Drawing.Color.Transparent;
			this.grbNavegar.Controls.Add(this.lblRegistros);
			this.grbNavegar.Controls.Add(this.btnUltimo);
			this.grbNavegar.Controls.Add(this.btnSiguiente);
			this.grbNavegar.Controls.Add(this.btnAnterior);
			this.grbNavegar.Controls.Add(this.btnPrimero);
			this.grbNavegar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbNavegar.ForeColor = System.Drawing.Color.White;
			this.grbNavegar.Location = new System.Drawing.Point(12, 347);
			this.grbNavegar.Name = "grbNavegar";
			this.grbNavegar.Size = new System.Drawing.Size(575, 72);
			this.grbNavegar.TabIndex = 11;
			this.grbNavegar.TabStop = false;
			this.grbNavegar.Text = "Navegar";
			// 
			// lblRegistros
			// 
			this.lblRegistros.AutoSize = true;
			this.lblRegistros.Location = new System.Drawing.Point(277, 29);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(0, 15);
			this.lblRegistros.TabIndex = 11;
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.DarkRed;
			this.btnUltimo.Location = new System.Drawing.Point(517, 25);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 10;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.IndianRed;
			this.btnSiguiente.Location = new System.Drawing.Point(393, 25);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 9;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.IndianRed;
			this.btnAnterior.Location = new System.Drawing.Point(138, 25);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 8;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.DarkRed;
			this.btnPrimero.Location = new System.Drawing.Point(17, 25);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 7;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
			// 
			// grbEdicionPeliculas
			// 
			this.grbEdicionPeliculas.BackColor = System.Drawing.Color.Transparent;
			this.grbEdicionPeliculas.Controls.Add(this.btnEliminar);
			this.grbEdicionPeliculas.Controls.Add(this.btnBuscar);
			this.grbEdicionPeliculas.Controls.Add(this.btnModificar);
			this.grbEdicionPeliculas.Controls.Add(this.btnNuevo);
			this.grbEdicionPeliculas.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbEdicionPeliculas.ForeColor = System.Drawing.Color.White;
			this.grbEdicionPeliculas.Location = new System.Drawing.Point(593, 12);
			this.grbEdicionPeliculas.Name = "grbEdicionPeliculas";
			this.grbEdicionPeliculas.Size = new System.Drawing.Size(104, 407);
			this.grbEdicionPeliculas.TabIndex = 10;
			this.grbEdicionPeliculas.TabStop = false;
			this.grbEdicionPeliculas.Text = "Editar Películas";
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
			this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(6, 314);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(92, 31);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.Firebrick;
			this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(6, 230);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(92, 31);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "&Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Firebrick;
			this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(6, 148);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(92, 31);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.Firebrick;
			this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Location = new System.Drawing.Point(6, 60);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(92, 31);
			this.btnNuevo.TabIndex = 1;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// grbPeliculas
			// 
			this.grbPeliculas.BackColor = System.Drawing.Color.Transparent;
			this.grbPeliculas.Controls.Add(this.txtDuracion);
			this.grbPeliculas.Controls.Add(this.lblDuracion);
			this.grbPeliculas.Controls.Add(this.txtGenero);
			this.grbPeliculas.Controls.Add(this.txtSipnosis);
			this.grbPeliculas.Controls.Add(this.txtDescripcion);
			this.grbPeliculas.Controls.Add(this.txtNombre);
			this.grbPeliculas.Controls.Add(this.lblIdPelicula);
			this.grbPeliculas.Controls.Add(this.lblGenero);
			this.grbPeliculas.Controls.Add(this.lblSipnosis);
			this.grbPeliculas.Controls.Add(this.lblDescripcion);
			this.grbPeliculas.Controls.Add(this.lblNombre);
			this.grbPeliculas.Enabled = false;
			this.grbPeliculas.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbPeliculas.ForeColor = System.Drawing.Color.White;
			this.grbPeliculas.Location = new System.Drawing.Point(12, 12);
			this.grbPeliculas.Name = "grbPeliculas";
			this.grbPeliculas.Size = new System.Drawing.Size(575, 329);
			this.grbPeliculas.TabIndex = 9;
			this.grbPeliculas.TabStop = false;
			this.grbPeliculas.Text = "Películas";
			// 
			// txtDuracion
			// 
			this.txtDuracion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDuracion.Location = new System.Drawing.Point(114, 301);
			this.txtDuracion.Name = "txtDuracion";
			this.txtDuracion.Size = new System.Drawing.Size(143, 22);
			this.txtDuracion.TabIndex = 10;
			// 
			// lblDuracion
			// 
			this.lblDuracion.AutoSize = true;
			this.lblDuracion.Location = new System.Drawing.Point(23, 305);
			this.lblDuracion.Name = "lblDuracion";
			this.lblDuracion.Size = new System.Drawing.Size(72, 15);
			this.lblDuracion.TabIndex = 9;
			this.lblDuracion.Text = "Duración:";
			// 
			// txtGenero
			// 
			this.txtGenero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGenero.Location = new System.Drawing.Point(114, 273);
			this.txtGenero.Name = "txtGenero";
			this.txtGenero.Size = new System.Drawing.Size(326, 22);
			this.txtGenero.TabIndex = 8;
			// 
			// txtSipnosis
			// 
			this.txtSipnosis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSipnosis.Location = new System.Drawing.Point(114, 163);
			this.txtSipnosis.Multiline = true;
			this.txtSipnosis.Name = "txtSipnosis";
			this.txtSipnosis.Size = new System.Drawing.Size(455, 104);
			this.txtSipnosis.TabIndex = 7;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BackColor = System.Drawing.Color.White;
			this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(114, 52);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(455, 105);
			this.txtDescripcion.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(114, 24);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(326, 22);
			this.txtNombre.TabIndex = 5;
			// 
			// lblIdPelicula
			// 
			this.lblIdPelicula.AutoSize = true;
			this.lblIdPelicula.Location = new System.Drawing.Point(503, 28);
			this.lblIdPelicula.Name = "lblIdPelicula";
			this.lblIdPelicula.Size = new System.Drawing.Size(22, 15);
			this.lblIdPelicula.TabIndex = 4;
			this.lblIdPelicula.Text = "ID:";
			// 
			// lblGenero
			// 
			this.lblGenero.AutoSize = true;
			this.lblGenero.Location = new System.Drawing.Point(36, 277);
			this.lblGenero.Name = "lblGenero";
			this.lblGenero.Size = new System.Drawing.Size(59, 15);
			this.lblGenero.TabIndex = 3;
			this.lblGenero.Text = "Genero:";
			// 
			// lblSipnosis
			// 
			this.lblSipnosis.AutoSize = true;
			this.lblSipnosis.Location = new System.Drawing.Point(32, 208);
			this.lblSipnosis.Name = "lblSipnosis";
			this.lblSipnosis.Size = new System.Drawing.Size(63, 15);
			this.lblSipnosis.TabIndex = 2;
			this.lblSipnosis.Text = "Sipnosis:";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(6, 95);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(89, 15);
			this.lblDescripcion.TabIndex = 1;
			this.lblDescripcion.Text = "Descripción:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(35, 28);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(60, 15);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre:";
			// 
			// Peliculas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Conversor_A.Properties.Resources.WhatsApp_Image_2020_05_03_at_21_14_47;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(714, 431);
			this.Controls.Add(this.grbNavegar);
			this.Controls.Add(this.grbEdicionPeliculas);
			this.Controls.Add(this.grbPeliculas);
			this.Name = "Peliculas";
			this.Text = "Peliculas";
			this.Load += new System.EventHandler(this.Peliculas_Load);
			this.grbNavegar.ResumeLayout(false);
			this.grbNavegar.PerformLayout();
			this.grbEdicionPeliculas.ResumeLayout(false);
			this.grbPeliculas.ResumeLayout(false);
			this.grbPeliculas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbNavegar;
		private System.Windows.Forms.Label lblRegistros;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
		private System.Windows.Forms.GroupBox grbEdicionPeliculas;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox grbPeliculas;
		private System.Windows.Forms.TextBox txtDuracion;
		private System.Windows.Forms.Label lblDuracion;
		private System.Windows.Forms.TextBox txtGenero;
		private System.Windows.Forms.TextBox txtSipnosis;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblIdPelicula;
		private System.Windows.Forms.Label lblGenero;
		private System.Windows.Forms.Label lblSipnosis;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lblNombre;
	}
}