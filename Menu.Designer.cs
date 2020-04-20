namespace Conversor_A
{
    partial class Menu
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
			this.btnAlumnos = new System.Windows.Forms.Button();
			this.btnResponsables = new System.Windows.Forms.Button();
			this.btnDocentes = new System.Windows.Forms.Button();
			this.btnMatriculas = new System.Windows.Forms.Button();
			this.btnTutor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAlumnos
			// 
			this.btnAlumnos.Location = new System.Drawing.Point(35, 72);
			this.btnAlumnos.Name = "btnAlumnos";
			this.btnAlumnos.Size = new System.Drawing.Size(124, 41);
			this.btnAlumnos.TabIndex = 0;
			this.btnAlumnos.Text = "Alumnos";
			this.btnAlumnos.UseVisualStyleBackColor = true;
			this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
			// 
			// btnResponsables
			// 
			this.btnResponsables.Location = new System.Drawing.Point(35, 119);
			this.btnResponsables.Name = "btnResponsables";
			this.btnResponsables.Size = new System.Drawing.Size(124, 51);
			this.btnResponsables.TabIndex = 1;
			this.btnResponsables.Text = "Responsables";
			this.btnResponsables.UseVisualStyleBackColor = true;
			this.btnResponsables.Click += new System.EventHandler(this.btnResponsables_Click);
			// 
			// btnDocentes
			// 
			this.btnDocentes.Location = new System.Drawing.Point(35, 176);
			this.btnDocentes.Name = "btnDocentes";
			this.btnDocentes.Size = new System.Drawing.Size(124, 51);
			this.btnDocentes.TabIndex = 2;
			this.btnDocentes.Text = "Docentes";
			this.btnDocentes.UseVisualStyleBackColor = true;
			this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
			// 
			// btnMatriculas
			// 
			this.btnMatriculas.Location = new System.Drawing.Point(274, 72);
			this.btnMatriculas.Name = "btnMatriculas";
			this.btnMatriculas.Size = new System.Drawing.Size(124, 41);
			this.btnMatriculas.TabIndex = 3;
			this.btnMatriculas.Text = "Matriculas";
			this.btnMatriculas.UseVisualStyleBackColor = true;
			this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
			// 
			// btnTutor
			// 
			this.btnTutor.Location = new System.Drawing.Point(274, 176);
			this.btnTutor.Name = "btnTutor";
			this.btnTutor.Size = new System.Drawing.Size(124, 51);
			this.btnTutor.TabIndex = 4;
			this.btnTutor.Text = "Tutor de Aula";
			this.btnTutor.UseVisualStyleBackColor = true;
			this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 400);
			this.Controls.Add(this.btnTutor);
			this.Controls.Add(this.btnMatriculas);
			this.Controls.Add(this.btnDocentes);
			this.Controls.Add(this.btnResponsables);
			this.Controls.Add(this.btnAlumnos);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnResponsables;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnMatriculas;
        private System.Windows.Forms.Button btnTutor;
    }
}