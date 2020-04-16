namespace Conversor_A
{
	partial class Buscar_Responsables
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
            this.grdBusquedaResponsables = new System.Windows.Forms.DataGridView();
            this.txtbuscarresponsable = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(493, 428);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 31);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // grdBusquedaResponsables
            // 
            this.grdBusquedaResponsables.AllowUserToAddRows = false;
            this.grdBusquedaResponsables.AllowUserToDeleteRows = false;
            this.grdBusquedaResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaResponsables.Location = new System.Drawing.Point(10, 65);
            this.grdBusquedaResponsables.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaResponsables.Name = "grdBusquedaResponsables";
            this.grdBusquedaResponsables.ReadOnly = true;
            this.grdBusquedaResponsables.RowHeadersWidth = 102;
            this.grdBusquedaResponsables.RowTemplate.Height = 40;
            this.grdBusquedaResponsables.Size = new System.Drawing.Size(960, 346);
            this.grdBusquedaResponsables.TabIndex = 14;
            // 
            // txtbuscarresponsable
            // 
            this.txtbuscarresponsable.Location = new System.Drawing.Point(75, 22);
            this.txtbuscarresponsable.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscarresponsable.Name = "txtbuscarresponsable";
            this.txtbuscarresponsable.Size = new System.Drawing.Size(295, 20);
            this.txtbuscarresponsable.TabIndex = 13;
            this.txtbuscarresponsable.TextChanged += new System.EventHandler(this.txtbuscarresponsable_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(10, 25);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 12;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(397, 428);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click_1);
            // 
            // Buscar_Responsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 483);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grdBusquedaResponsables);
            this.Controls.Add(this.txtbuscarresponsable);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "Buscar_Responsables";
            this.Text = "Buscar_Responsables";
            this.Load += new System.EventHandler(this.Buscar_Responsables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaResponsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView grdBusquedaResponsables;
		private System.Windows.Forms.TextBox txtbuscarresponsable;
		private System.Windows.Forms.Label lblbuscar;
		private System.Windows.Forms.Button btnSeleccionar;
	}
}