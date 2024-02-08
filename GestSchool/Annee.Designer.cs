namespace GestSchool
{
    partial class Annee
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.id_annee = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.enregistrer_annee = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 33);
            this.label2.TabIndex = 81;
            this.label2.Text = "ENREGISTREMENT DES ANNEES SCOLAIRES";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1159, 252);
            this.listView1.TabIndex = 91;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Label";
            this.columnHeader2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "Année Scolaire";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.comboBox1.Location = new System.Drawing.Point(451, 410);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 24);
            this.comboBox1.TabIndex = 100;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 32);
            this.label3.TabIndex = 98;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(649, 410);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 24);
            this.comboBox2.TabIndex = 99;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(726, 519);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(161, 53);
            this.supprimer.TabIndex = 97;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.Supprimer_Click_1);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Orange;
            this.update.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(551, 519);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(142, 53);
            this.update.TabIndex = 96;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // id_annee
            // 
            this.id_annee.Location = new System.Drawing.Point(84, 611);
            this.id_annee.Name = "id_annee";
            this.id_annee.Size = new System.Drawing.Size(127, 22);
            this.id_annee.TabIndex = 95;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(27, 614);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(34, 20);
            this.id.TabIndex = 94;
            this.id.Text = "ID:";
            // 
            // enregistrer_annee
            // 
            this.enregistrer_annee.BackColor = System.Drawing.Color.SpringGreen;
            this.enregistrer_annee.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer_annee.Location = new System.Drawing.Point(334, 519);
            this.enregistrer_annee.Name = "enregistrer_annee";
            this.enregistrer_annee.Size = new System.Drawing.Size(186, 53);
            this.enregistrer_annee.TabIndex = 93;
            this.enregistrer_annee.Text = "Enregistrer";
            this.enregistrer_annee.UseVisualStyleBackColor = false;
            this.enregistrer_annee.Click += new System.EventHandler(this.Enregistrer_annee_Click_1);
            // 
            // Retour
            // 
            this.Retour.BackColor = System.Drawing.Color.Aqua;
            this.Retour.Location = new System.Drawing.Point(31, 19);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 138;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = false;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Annee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 654);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.update);
            this.Controls.Add(this.id_annee);
            this.Controls.Add(this.id);
            this.Controls.Add(this.enregistrer_annee);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Name = "Annee";
            this.Text = "Annee";
            this.Load += new System.EventHandler(this.Annee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox id_annee;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button enregistrer_annee;
        private System.Windows.Forms.Button Retour;
    }
}