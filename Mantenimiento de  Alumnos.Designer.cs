namespace Conversor_A
{
	partial class Mantenimiento_de__Alumnos
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblCódigo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblCódigo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(553, 376);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mantenimiento Alumnos ";
			// 
			// lblCódigo
			// 
			this.lblCódigo.AutoSize = true;
			this.lblCódigo.Location = new System.Drawing.Point(20, 48);
			this.lblCódigo.Name = "lblCódigo";
			this.lblCódigo.Size = new System.Drawing.Size(40, 13);
			this.lblCódigo.TabIndex = 0;
			this.lblCódigo.Text = "Código";
			this.lblCódigo.Click += new System.EventHandler(this.label1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(66, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// Mantenimiento_de__Alumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 509);
			this.Controls.Add(this.groupBox1);
			this.Name = "Mantenimiento_de__Alumnos";
			this.Text = "Mantenimiento_de__Alumnos";
			this.Load += new System.EventHandler(this.Mantenimiento_de__Alumnos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblCódigo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}