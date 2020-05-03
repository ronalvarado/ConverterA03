namespace Conversor_A
{
	partial class BuscarPeliculas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtbuscarPeliculas = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.grdBuscarPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscarPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(526, 31);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 31);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(430, 31);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnSeleccionar.TabIndex = 38;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtbuscarPeliculas
            // 
            this.txtbuscarPeliculas.Location = new System.Drawing.Point(102, 37);
            this.txtbuscarPeliculas.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscarPeliculas.Name = "txtbuscarPeliculas";
            this.txtbuscarPeliculas.Size = new System.Drawing.Size(295, 20);
            this.txtbuscarPeliculas.TabIndex = 37;
            this.txtbuscarPeliculas.TextChanged += new System.EventHandler(this.txtbuscarPeliculas_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(37, 40);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 36;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // grdBuscarPeliculas
            // 
            this.grdBuscarPeliculas.AllowUserToAddRows = false;
            this.grdBuscarPeliculas.AllowUserToDeleteRows = false;
            this.grdBuscarPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscarPeliculas.Location = new System.Drawing.Point(11, 73);
            this.grdBuscarPeliculas.Margin = new System.Windows.Forms.Padding(1);
            this.grdBuscarPeliculas.Name = "grdBuscarPeliculas";
            this.grdBuscarPeliculas.ReadOnly = true;
            this.grdBuscarPeliculas.RowHeadersWidth = 102;
            this.grdBuscarPeliculas.RowTemplate.Height = 40;
            this.grdBuscarPeliculas.Size = new System.Drawing.Size(779, 346);
            this.grdBuscarPeliculas.TabIndex = 35;
            this.grdBuscarPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuscarPeliculas_CellContentClick);
            // 
            // BuscarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 456);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtbuscarPeliculas);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.grdBuscarPeliculas);
            this.Name = "BuscarPeliculas";
            this.Text = "BuscarPeliculas";
            this.Load += new System.EventHandler(this.BuscarPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscarPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.TextBox txtbuscarPeliculas;
		private System.Windows.Forms.Label lblbuscar;
		private System.Windows.Forms.DataGridView grdBuscarPeliculas;
	}
}