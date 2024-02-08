namespace GestSchool
{
    partial class Professeur
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
            this.annees = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.sexe_f = new System.Windows.Forms.RadioButton();
            this.sexe_m = new System.Windows.Forms.RadioButton();
            this.id_etud = new System.Windows.Forms.TextBox();
            this.tel_etud = new System.Windows.Forms.TextBox();
            this.photo_etud = new System.Windows.Forms.Button();
            this.prenom_prof = new System.Windows.Forms.TextBox();
            this.nom_prof = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.validation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matieres = new System.Windows.Forms.CheckedListBox();
            this.filières = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // annees
            // 
            this.annees.FormattingEnabled = true;
            this.annees.Location = new System.Drawing.Point(1042, 566);
            this.annees.Name = "annees";
            this.annees.Size = new System.Drawing.Size(164, 24);
            this.annees.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(887, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 117;
            this.label10.Text = "Année Scolaire:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(579, 541);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(274, 22);
            this.email.TabIndex = 116;
            // 
            // sexe_f
            // 
            this.sexe_f.AutoSize = true;
            this.sexe_f.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe_f.Location = new System.Drawing.Point(231, 596);
            this.sexe_f.Name = "sexe_f";
            this.sexe_f.Size = new System.Drawing.Size(86, 23);
            this.sexe_f.TabIndex = 114;
            this.sexe_f.TabStop = true;
            this.sexe_f.Text = "Féminin";
            this.sexe_f.UseVisualStyleBackColor = true;
            // 
            // sexe_m
            // 
            this.sexe_m.AutoSize = true;
            this.sexe_m.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe_m.Location = new System.Drawing.Point(107, 595);
            this.sexe_m.Name = "sexe_m";
            this.sexe_m.Size = new System.Drawing.Size(95, 23);
            this.sexe_m.TabIndex = 113;
            this.sexe_m.TabStop = true;
            this.sexe_m.Text = "Masculin";
            this.sexe_m.UseVisualStyleBackColor = true;
            // 
            // id_etud
            // 
            this.id_etud.Location = new System.Drawing.Point(85, 743);
            this.id_etud.Name = "id_etud";
            this.id_etud.Size = new System.Drawing.Size(127, 22);
            this.id_etud.TabIndex = 111;
            // 
            // tel_etud
            // 
            this.tel_etud.Location = new System.Drawing.Point(579, 471);
            this.tel_etud.Name = "tel_etud";
            this.tel_etud.Size = new System.Drawing.Size(274, 22);
            this.tel_etud.TabIndex = 110;
            // 
            // photo_etud
            // 
            this.photo_etud.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo_etud.Location = new System.Drawing.Point(536, 609);
            this.photo_etud.Name = "photo_etud";
            this.photo_etud.Size = new System.Drawing.Size(283, 37);
            this.photo_etud.TabIndex = 108;
            this.photo_etud.Text = "Choisir une photo";
            this.photo_etud.UseVisualStyleBackColor = true;
            this.photo_etud.Click += new System.EventHandler(this.Photo_etud_Click);
            // 
            // prenom_prof
            // 
            this.prenom_prof.Location = new System.Drawing.Point(108, 541);
            this.prenom_prof.Name = "prenom_prof";
            this.prenom_prof.Size = new System.Drawing.Size(312, 22);
            this.prenom_prof.TabIndex = 107;
            // 
            // nom_prof
            // 
            this.nom_prof.Location = new System.Drawing.Point(105, 473);
            this.nom_prof.Name = "nom_prof";
            this.nom_prof.Size = new System.Drawing.Size(315, 22);
            this.nom_prof.TabIndex = 106;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1346, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 257);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 103;
            this.label7.Text = "Prénoms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(958, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 102;
            this.label6.Text = "Filière:";
            // 
            // validation
            // 
            this.validation.BackColor = System.Drawing.Color.SpringGreen;
            this.validation.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validation.Location = new System.Drawing.Point(657, 707);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(186, 53);
            this.validation.TabIndex = 100;
            this.validation.Text = "Valider";
            this.validation.UseVisualStyleBackColor = false;
            this.validation.Click += new System.EventHandler(this.Validation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(942, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 122;
            this.label1.Text = "Matières";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // matieres
            // 
            this.matieres.FormattingEnabled = true;
            this.matieres.Location = new System.Drawing.Point(1035, 609);
            this.matieres.Name = "matieres";
            this.matieres.Size = new System.Drawing.Size(181, 89);
            this.matieres.TabIndex = 124;
            this.matieres.SelectedIndexChanged += new System.EventHandler(this.Matieres_SelectedIndexChanged);
            // 
            // filières
            // 
            this.filières.FormattingEnabled = true;
            this.filières.Location = new System.Drawing.Point(1035, 457);
            this.filières.Name = "filières";
            this.filières.Size = new System.Drawing.Size(181, 89);
            this.filières.TabIndex = 125;
            this.filières.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 743);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "ID:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(85, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1633, 254);
            this.listView1.TabIndex = 130;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prenom";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sexe";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Numero de telephone";
            this.columnHeader7.Width = 147;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1474, 370);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 26);
            this.label19.TabIndex = 133;
            this.label19.Text = "Photo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(990, 370);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(280, 26);
            this.label18.TabIndex = 132;
            this.label18.Text = "Données Académiques";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label17.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(354, 370);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(287, 26);
            this.label17.TabIndex = 131;
            this.label17.Text = "Données Personnelles";
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(913, 715);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(127, 42);
            this.supprimer.TabIndex = 135;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Orange;
            this.update.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(480, 715);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(127, 42);
            this.update.TabIndex = 134;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 598);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 136;
            this.label13.Text = "Sexe:";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // Retour
            // 
            this.Retour.BackColor = System.Drawing.Color.Aqua;
            this.Retour.Location = new System.Drawing.Point(12, 22);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 137;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = false;
            this.Retour.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Professeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 777);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filières);
            this.Controls.Add(this.matieres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annees);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sexe_f);
            this.Controls.Add(this.sexe_m);
            this.Controls.Add(this.id_etud);
            this.Controls.Add(this.tel_etud);
            this.Controls.Add(this.photo_etud);
            this.Controls.Add(this.prenom_prof);
            this.Controls.Add(this.nom_prof);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.validation);
            this.Name = "Professeur";
            this.Text = "Professeur";
            this.Load += new System.EventHandler(this.Professeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox annees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.RadioButton sexe_f;
        private System.Windows.Forms.RadioButton sexe_m;
        private System.Windows.Forms.TextBox id_etud;
        private System.Windows.Forms.TextBox tel_etud;
        private System.Windows.Forms.Button photo_etud;
        private System.Windows.Forms.TextBox prenom_prof;
        private System.Windows.Forms.TextBox nom_prof;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button validation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox matieres;
        private System.Windows.Forms.CheckedListBox filières;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Retour;
    }
}