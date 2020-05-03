namespace Conversor_A
{
    partial class BuscarAlquiler
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
            this.txtbuscarCliente = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.grdBusquedaAlquiler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(572, 24);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 31);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(458, 24);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(106, 31);
            this.btnSeleccionar.TabIndex = 38;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtbuscarCliente
            // 
            this.txtbuscarCliente.Location = new System.Drawing.Point(130, 30);
            this.txtbuscarCliente.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscarCliente.Name = "txtbuscarCliente";
            this.txtbuscarCliente.Size = new System.Drawing.Size(307, 20);
            this.txtbuscarCliente.TabIndex = 37;
            this.txtbuscarCliente.TextChanged += new System.EventHandler(this.txtbuscarCliente_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(65, 33);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 36;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // grdBusquedaAlquiler
            // 
            this.grdBusquedaAlquiler.AllowUserToAddRows = false;
            this.grdBusquedaAlquiler.AllowUserToDeleteRows = false;
            this.grdBusquedaAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaAlquiler.Location = new System.Drawing.Point(10, 79);
            this.grdBusquedaAlquiler.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaAlquiler.Name = "grdBusquedaAlquiler";
            this.grdBusquedaAlquiler.ReadOnly = true;
            this.grdBusquedaAlquiler.RowHeadersWidth = 102;
            this.grdBusquedaAlquiler.RowTemplate.Height = 40;
            this.grdBusquedaAlquiler.Size = new System.Drawing.Size(780, 348);
            this.grdBusquedaAlquiler.TabIndex = 35;
            // 
            // BuscarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtbuscarCliente);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.grdBusquedaAlquiler);
            this.Name = "BuscarAlquiler";
            this.Text = "BuscarAlquiler";
            this.Load += new System.EventHandler(this.BuscarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtbuscarCliente;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridView grdBusquedaAlquiler;
    }
}