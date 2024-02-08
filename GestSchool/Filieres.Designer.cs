namespace GestSchool
{
    partial class Filieres
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
            this.supprimer = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.id_filiere = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.Filiere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sigle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(386, 620);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(127, 46);
            this.supprimer.TabIndex = 81;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Orange;
            this.update.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(752, 620);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(127, 46);
            this.update.TabIndex = 80;
            this.update.Text = "Modifier";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.check.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(241, 685);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(124, 42);
            this.check.TabIndex = 79;
            this.check.Text = "Vérification";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.Check_Click);
            // 
            // id_filiere
            // 
            this.id_filiere.Location = new System.Drawing.Point(87, 693);
            this.id_filiere.Name = "id_filiere";
            this.id_filiere.Size = new System.Drawing.Size(127, 22);
            this.id_filiere.TabIndex = 78;
            this.id_filiere.TextChanged += new System.EventHandler(this.Id_filiere_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(30, 696);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(34, 20);
            this.id.TabIndex = 77;
            this.id.Text = "ID:";
            this.id.Click += new System.EventHandler(this.Id_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(34, 57);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(1251, 390);
            this.dataGridView6.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 33);
            this.label3.TabIndex = 75;
            this.label3.Text = "ENREGISTREMENT DES FILIERES";
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.SpringGreen;
            this.enregistrer.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.Location = new System.Drawing.Point(542, 580);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(186, 53);
            this.enregistrer.TabIndex = 74;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Filiere
            // 
            this.Filiere.Location = new System.Drawing.Point(161, 529);
            this.Filiere.Multiline = true;
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(369, 32);
            this.Filiere.TabIndex = 73;
            this.Filiere.TextChanged += new System.EventHandler(this.Filiere_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Filière:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Sigle
            // 
            this.Sigle.Location = new System.Drawing.Point(738, 529);
            this.Sigle.Name = "Sigle";
            this.Sigle.Size = new System.Drawing.Size(171, 22);
            this.Sigle.TabIndex = 83;
            this.Sigle.TextChanged += new System.EventHandler(this.Sigle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(805, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Sigle";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Retour
            // 
            this.Retour.BackColor = System.Drawing.Color.Aqua;
            this.Retour.Location = new System.Drawing.Point(12, 19);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 138;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = false;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Filieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 740);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Sigle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.update);
            this.Controls.Add(this.check);
            this.Controls.Add(this.id_filiere);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.label1);
            this.Name = "Filieres";
            this.Text = "Filieres";
            this.Load += new System.EventHandler(this.Filieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox id_filiere;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.TextBox Filiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sigle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Retour;
    }
}