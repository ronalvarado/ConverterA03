namespace Conversor_A
{
	partial class Clientes
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
			this.grbEdicionClientes = new System.Windows.Forms.GroupBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.grbClientes = new System.Windows.Forms.GroupBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtDui = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblIdCliente = new System.Windows.Forms.Label();
			this.lblDui = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnUltimo = new System.Windows.Forms.Button();
			this.btnSiguiente = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.btnPrimero = new System.Windows.Forms.Button();
			this.grbNavegar.SuspendLayout();
			this.grbEdicionClientes.SuspendLayout();
			this.grbClientes.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbNavegar
			// 
			this.grbNavegar.BackColor = System.Drawing.Color.Transparent;
			this.grbNavegar.Controls.Add(this.btnUltimo);
			this.grbNavegar.Controls.Add(this.btnSiguiente);
			this.grbNavegar.Controls.Add(this.btnAnterior);
			this.grbNavegar.Controls.Add(this.btnPrimero);
			this.grbNavegar.Controls.Add(this.lblRegistros);
			this.grbNavegar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbNavegar.ForeColor = System.Drawing.Color.White;
			this.grbNavegar.Location = new System.Drawing.Point(12, 280);
			this.grbNavegar.Name = "grbNavegar";
			this.grbNavegar.Size = new System.Drawing.Size(575, 72);
			this.grbNavegar.TabIndex = 8;
			this.grbNavegar.TabStop = false;
			this.grbNavegar.Text = "Navegar";
			// 
			// lblRegistros
			// 
			this.lblRegistros.AutoSize = true;
			this.lblRegistros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegistros.Location = new System.Drawing.Point(272, 29);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(0, 22);
			this.lblRegistros.TabIndex = 11;
			// 
			// grbEdicionClientes
			// 
			this.grbEdicionClientes.BackColor = System.Drawing.Color.Transparent;
			this.grbEdicionClientes.Controls.Add(this.btnEliminar);
			this.grbEdicionClientes.Controls.Add(this.btnBuscar);
			this.grbEdicionClientes.Controls.Add(this.btnModificar);
			this.grbEdicionClientes.Controls.Add(this.btnNuevo);
			this.grbEdicionClientes.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbEdicionClientes.ForeColor = System.Drawing.Color.White;
			this.grbEdicionClientes.Location = new System.Drawing.Point(593, 12);
			this.grbEdicionClientes.Name = "grbEdicionClientes";
			this.grbEdicionClientes.Size = new System.Drawing.Size(104, 340);
			this.grbEdicionClientes.TabIndex = 7;
			this.grbEdicionClientes.TabStop = false;
			this.grbEdicionClientes.Text = "Editar Clientes";
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
			this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Black;
			this.btnEliminar.Location = new System.Drawing.Point(6, 287);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(92, 31);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.IndianRed;
			this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.Black;
			this.btnBuscar.Location = new System.Drawing.Point(6, 209);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(92, 31);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "&Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.IndianRed;
			this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.Color.Black;
			this.btnModificar.Location = new System.Drawing.Point(6, 125);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(92, 31);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.IndianRed;
			this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.ForeColor = System.Drawing.Color.Black;
			this.btnNuevo.Location = new System.Drawing.Point(6, 48);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(92, 31);
			this.btnNuevo.TabIndex = 1;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// grbClientes
			// 
			this.grbClientes.BackColor = System.Drawing.Color.Transparent;
			this.grbClientes.Controls.Add(this.txtDireccion);
			this.grbClientes.Controls.Add(this.txtDui);
			this.grbClientes.Controls.Add(this.txtTelefono);
			this.grbClientes.Controls.Add(this.txtNombre);
			this.grbClientes.Controls.Add(this.lblIdCliente);
			this.grbClientes.Controls.Add(this.lblDui);
			this.grbClientes.Controls.Add(this.lblTelefono);
			this.grbClientes.Controls.Add(this.lblDireccion);
			this.grbClientes.Controls.Add(this.lblNombre);
			this.grbClientes.Enabled = false;
			this.grbClientes.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbClientes.ForeColor = System.Drawing.Color.White;
			this.grbClientes.Location = new System.Drawing.Point(12, 12);
			this.grbClientes.Name = "grbClientes";
			this.grbClientes.Size = new System.Drawing.Size(575, 262);
			this.grbClientes.TabIndex = 6;
			this.grbClientes.TabStop = false;
			this.grbClientes.Text = "Clientes";
			// 
			// txtDireccion
			// 
			this.txtDireccion.BackColor = System.Drawing.Color.White;
			this.txtDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDireccion.Location = new System.Drawing.Point(92, 90);
			this.txtDireccion.Multiline = true;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(272, 51);
			this.txtDireccion.TabIndex = 6;
			// 
			// txtDui
			// 
			this.txtDui.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDui.Location = new System.Drawing.Point(92, 224);
			this.txtDui.Name = "txtDui";
			this.txtDui.Size = new System.Drawing.Size(143, 22);
			this.txtDui.TabIndex = 8;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(92, 179);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(143, 22);
			this.txtTelefono.TabIndex = 7;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(92, 36);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(407, 22);
			this.txtNombre.TabIndex = 5;
			// 
			// lblIdCliente
			// 
			this.lblIdCliente.AutoSize = true;
			this.lblIdCliente.Location = new System.Drawing.Point(505, 39);
			this.lblIdCliente.Name = "lblIdCliente";
			this.lblIdCliente.Size = new System.Drawing.Size(22, 15);
			this.lblIdCliente.TabIndex = 4;
			this.lblIdCliente.Text = "ID:";
			// 
			// lblDui
			// 
			this.lblDui.AutoSize = true;
			this.lblDui.Location = new System.Drawing.Point(50, 227);
			this.lblDui.Name = "lblDui";
			this.lblDui.Size = new System.Drawing.Size(30, 15);
			this.lblDui.TabIndex = 3;
			this.lblDui.Text = "DUI:";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(8, 182);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(72, 15);
			this.lblTelefono.TabIndex = 2;
			this.lblTelefono.Text = "Teléfono:";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(6, 108);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(74, 15);
			this.lblDireccion.TabIndex = 1;
			this.lblDireccion.Text = "Direccion:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(20, 39);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(60, 15);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre:";
			// 
			// btnUltimo
			// 
			this.btnUltimo.BackColor = System.Drawing.Color.DarkRed;
			this.btnUltimo.Location = new System.Drawing.Point(519, 25);
			this.btnUltimo.Name = "btnUltimo";
			this.btnUltimo.Size = new System.Drawing.Size(40, 23);
			this.btnUltimo.TabIndex = 15;
			this.btnUltimo.Text = ">|";
			this.btnUltimo.UseVisualStyleBackColor = false;
			this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click_1);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = System.Drawing.Color.Firebrick;
			this.btnSiguiente.Location = new System.Drawing.Point(395, 25);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new System.Drawing.Size(40, 23);
			this.btnSiguiente.TabIndex = 14;
			this.btnSiguiente.Text = ">";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
			// 
			// btnAnterior
			// 
			this.btnAnterior.BackColor = System.Drawing.Color.Firebrick;
			this.btnAnterior.Location = new System.Drawing.Point(140, 25);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(40, 23);
			this.btnAnterior.TabIndex = 13;
			this.btnAnterior.Text = "<";
			this.btnAnterior.UseVisualStyleBackColor = false;
			this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click_1);
			// 
			// btnPrimero
			// 
			this.btnPrimero.BackColor = System.Drawing.Color.DarkRed;
			this.btnPrimero.Location = new System.Drawing.Point(19, 25);
			this.btnPrimero.Name = "btnPrimero";
			this.btnPrimero.Size = new System.Drawing.Size(40, 23);
			this.btnPrimero.TabIndex = 12;
			this.btnPrimero.Text = "|<";
			this.btnPrimero.UseVisualStyleBackColor = false;
			this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click_1);
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Conversor_A.Properties.Resources.WhatsApp_Image_2020_05_03_at_21_14_47;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(709, 365);
			this.Controls.Add(this.grbClientes);
			this.Controls.Add(this.grbNavegar);
			this.Controls.Add(this.grbEdicionClientes);
			this.DoubleBuffered = true;
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.Clientes_Load);
			this.grbNavegar.ResumeLayout(false);
			this.grbNavegar.PerformLayout();
			this.grbEdicionClientes.ResumeLayout(false);
			this.grbClientes.ResumeLayout(false);
			this.grbClientes.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbNavegar;
		private System.Windows.Forms.Label lblRegistros;
		private System.Windows.Forms.GroupBox grbEdicionClientes;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.GroupBox grbClientes;
		private System.Windows.Forms.TextBox txtDui;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblIdCliente;
		private System.Windows.Forms.Label lblDui;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnUltimo;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnPrimero;
	}
}