namespace Conversor_A
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cbxde = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxa = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtconvertir = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxtipo = new System.Windows.Forms.ComboBox();
			this.btnaconvertir = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbxde
			// 
			this.cbxde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.cbxde.FormattingEnabled = true;
			this.cbxde.Location = new System.Drawing.Point(135, 239);
			this.cbxde.Name = "cbxde";
			this.cbxde.Size = new System.Drawing.Size(140, 24);
			this.cbxde.TabIndex = 0;
			this.cbxde.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(253, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Convertir";
			// 
			// cbxa
			// 
			this.cbxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.cbxa.FormattingEnabled = true;
			this.cbxa.Location = new System.Drawing.Point(352, 239);
			this.cbxa.Name = "cbxa";
			this.cbxa.Size = new System.Drawing.Size(140, 24);
			this.cbxa.TabIndex = 2;
			this.cbxa.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(86, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "&De:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(301, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "&A:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtconvertir
			// 
			this.txtconvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtconvertir.Location = new System.Drawing.Point(227, 169);
			this.txtconvertir.Name = "txtconvertir";
			this.txtconvertir.Size = new System.Drawing.Size(101, 24);
			this.txtconvertir.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(187, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Que quieres convertir?";
			// 
			// cbxtipo
			// 
			this.cbxtipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.cbxtipo.FormattingEnabled = true;
			this.cbxtipo.Location = new System.Drawing.Point(305, 91);
			this.cbxtipo.Name = "cbxtipo";
			this.cbxtipo.Size = new System.Drawing.Size(140, 24);
			this.cbxtipo.TabIndex = 7;
			this.cbxtipo.SelectedIndexChanged += new System.EventHandler(this.cbxtipo_SelectedIndexChanged);
			// 
			// btnaconvertir
			// 
			this.btnaconvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnaconvertir.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnaconvertir.Location = new System.Drawing.Point(214, 317);
			this.btnaconvertir.Name = "btnaconvertir";
			this.btnaconvertir.Size = new System.Drawing.Size(118, 42);
			this.btnaconvertir.TabIndex = 8;
			this.btnaconvertir.Text = "&Convertir";
			this.btnaconvertir.UseVisualStyleBackColor = false;
			this.btnaconvertir.Click += new System.EventHandler(this.btnaconvertir_Click);
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Location = new System.Drawing.Point(255, 298);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(43, 16);
			this.lblresultado.TabIndex = 9;
			this.lblresultado.Text = "Valor:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(596, 434);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btnaconvertir);
			this.Controls.Add(this.cbxtipo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtconvertir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxde);
			this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Conversor ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxde;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtconvertir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxtipo;
		private System.Windows.Forms.Button btnaconvertir;
		private System.Windows.Forms.Label lblresultado;
	}
}

