namespace GestSchool
{
    partial class acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceuil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gestion_note = new System.Windows.Forms.Button();
            this.gestion_filiere = new System.Windows.Forms.Button();
            this.gestion_annee = new System.Windows.Forms.Button();
            this.gestion_matiere = new System.Windows.Forms.Button();
            this.gestion_professeur = new System.Windows.Forms.Button();
            this.gestion_etudiant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(892, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 331);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // gestion_note
            // 
            this.gestion_note.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gestion_note.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_note.Location = new System.Drawing.Point(121, 297);
            this.gestion_note.Name = "gestion_note";
            this.gestion_note.Size = new System.Drawing.Size(221, 82);
            this.gestion_note.TabIndex = 14;
            this.gestion_note.Text = "Gestion Des Notes";
            this.gestion_note.UseVisualStyleBackColor = false;
            this.gestion_note.Click += new System.EventHandler(this.Gestion_note_Click);
            // 
            // gestion_filiere
            // 
            this.gestion_filiere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gestion_filiere.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_filiere.Location = new System.Drawing.Point(121, 457);
            this.gestion_filiere.Name = "gestion_filiere";
            this.gestion_filiere.Size = new System.Drawing.Size(221, 82);
            this.gestion_filiere.TabIndex = 13;
            this.gestion_filiere.Text = "Gestion Des Filières";
            this.gestion_filiere.UseVisualStyleBackColor = false;
            this.gestion_filiere.Click += new System.EventHandler(this.Gestion_filiere_Click_1);
            // 
            // gestion_annee
            // 
            this.gestion_annee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gestion_annee.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_annee.Location = new System.Drawing.Point(491, 297);
            this.gestion_annee.Name = "gestion_annee";
            this.gestion_annee.Size = new System.Drawing.Size(231, 82);
            this.gestion_annee.TabIndex = 12;
            this.gestion_annee.Text = "Gestion Des Années Scolaires";
            this.gestion_annee.UseVisualStyleBackColor = false;
            this.gestion_annee.Click += new System.EventHandler(this.Gestion_annee_Click);
            // 
            // gestion_matiere
            // 
            this.gestion_matiere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gestion_matiere.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_matiere.Location = new System.Drawing.Point(491, 457);
            this.gestion_matiere.Name = "gestion_matiere";
            this.gestion_matiere.Size = new System.Drawing.Size(231, 82);
            this.gestion_matiere.TabIndex = 11;
            this.gestion_matiere.Text = "Gestion Des Matières";
            this.gestion_matiere.UseVisualStyleBackColor = false;
            this.gestion_matiere.Click += new System.EventHandler(this.Gestion_matiere_Click);
            // 
            // gestion_professeur
            // 
            this.gestion_professeur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gestion_professeur.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_professeur.Location = new System.Drawing.Point(491, 138);
            this.gestion_professeur.Name = "gestion_professeur";
            this.gestion_professeur.Size = new System.Drawing.Size(231, 82);
            this.gestion_professeur.TabIndex = 10;
            this.gestion_professeur.Text = "Gestion Des Professeurs";
            this.gestion_professeur.UseVisualStyleBackColor = false;
            this.gestion_professeur.Click += new System.EventHandler(this.Gestion_professeur_Click);
            // 
            // gestion_etudiant
            // 
            this.gestion_etudiant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gestion_etudiant.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_etudiant.Location = new System.Drawing.Point(121, 138);
            this.gestion_etudiant.Name = "gestion_etudiant";
            this.gestion_etudiant.Size = new System.Drawing.Size(221, 82);
            this.gestion_etudiant.TabIndex = 9;
            this.gestion_etudiant.Text = "Gestion Des Etudiants";
            this.gestion_etudiant.UseVisualStyleBackColor = false;
            this.gestion_etudiant.Click += new System.EventHandler(this.Gestion_etudiant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(886, 138);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12);
            this.label1.Size = new System.Drawing.Size(258, 132);
            this.label1.TabIndex = 8;
            this.label1.Text = "GESTION DE \r\nLA \r\nSCOLARITE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gestion_note);
            this.Controls.Add(this.gestion_filiere);
            this.Controls.Add(this.gestion_annee);
            this.Controls.Add(this.gestion_matiere);
            this.Controls.Add(this.gestion_professeur);
            this.Controls.Add(this.gestion_etudiant);
            this.Controls.Add(this.label1);
            this.Name = "acceuil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gestion_note;
        private System.Windows.Forms.Button gestion_filiere;
        private System.Windows.Forms.Button gestion_annee;
        private System.Windows.Forms.Button gestion_matiere;
        private System.Windows.Forms.Button gestion_professeur;
        private System.Windows.Forms.Button gestion_etudiant;
        private System.Windows.Forms.Label label1;
    }
}

