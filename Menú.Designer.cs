namespace Conversor_A
{
	partial class Menú
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
			this.btnAlumno = new System.Windows.Forms.Button();
			this.btnResponsable = new System.Windows.Forms.Button();
			this.btnDocente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAlumno
			// 
			this.btnAlumno.Location = new System.Drawing.Point(25, 60);
			this.btnAlumno.Name = "btnAlumno";
			this.btnAlumno.Size = new System.Drawing.Size(75, 23);
			this.btnAlumno.TabIndex = 0;
			this.btnAlumno.Text = "Alumnos";
			this.btnAlumno.UseVisualStyleBackColor = true;
			this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
			// 
			// btnResponsable
			// 
			this.btnResponsable.Location = new System.Drawing.Point(25, 99);
			this.btnResponsable.Name = "btnResponsable";
			this.btnResponsable.Size = new System.Drawing.Size(87, 23);
			this.btnResponsable.TabIndex = 1;
			this.btnResponsable.Text = "Responsables";
			this.btnResponsable.UseVisualStyleBackColor = true;
			this.btnResponsable.Click += new System.EventHandler(this.btnResponsable_Click);
			// 
			// btnDocente
			// 
			this.btnDocente.Location = new System.Drawing.Point(25, 141);
			this.btnDocente.Name = "btnDocente";
			this.btnDocente.Size = new System.Drawing.Size(87, 23);
			this.btnDocente.TabIndex = 2;
			this.btnDocente.Text = "Docentes";
			this.btnDocente.UseVisualStyleBackColor = true;
			this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
			// 
			// Menú
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDocente);
			this.Controls.Add(this.btnResponsable);
			this.Controls.Add(this.btnAlumno);
			this.Name = "Menú";
			this.Text = "Menú";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAlumno;
		private System.Windows.Forms.Button btnResponsable;
		private System.Windows.Forms.Button btnDocente;
	}
}