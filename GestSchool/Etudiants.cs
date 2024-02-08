using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GestSchool
{
    public partial class Etudiants : Form
    {
        


     

        public Etudiants()
        {
            InitializeComponent();
            listView1.MouseClick += ListView1_MouseClick;
            id_etud.Enabled = false;
            supprimer.Enabled = false;
            update.Enabled = false;

        }




        OpenFileDialog selectimage;
        bool opened;




  


        private void Supprimer_Click(object sender, EventArgs e)
        {
            string pk = id_etud.Text;
            string quest = $"DELETE FROM etudiant WHERE id_etudiant={pk};";
            DatabaseUtility.ExecuterRequete(quest);

            Load_Data();
        }
        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Récupérer l'élément à l'emplacement du clic
            ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);

            // Vérifier si un élément a été cliqué
            if (clickedItem != null)
            {
                update.Enabled = true;
                supprimer.Enabled = true;

                // Charger les informations dans les TextBox
                nom_etud.Text = clickedItem.SubItems[1].Text;
                prenom_etud.Text = clickedItem.SubItems[2].Text;
                date_nais_etud.Text = clickedItem.SubItems[3].Text;
                email.Text = clickedItem.SubItems[5].Text;
                tel_etud.Text = clickedItem.SubItems[6].Text;
                string sexe = clickedItem.SubItems[4].Text;
                id_etud.Text = clickedItem.SubItems[0].Text;
                pictureBox1.Image = null;
                if (sexe == "Masculin")
                {
                    sexe_m.Checked = true;
                }
                if (sexe == "Féminin")
                {
                    sexe_f.Checked = true;
                }
                
            }

            string quest = $"select photo from etudiant where id_etudiant={id_etud.Text};";
            MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            while(mreader.Read())
            {
                bool bitm;
                try
                {
                    new Bitmap(mreader.GetString(0));
                    bitm = true;
                }
                catch (Exception err)
                {
                    bitm = false;
                }
                if (bitm)
                {
                    pictureBox1.Image = new Bitmap(mreader.GetString(0));

                }

                string cheminDestination = mreader.GetString(0);
                opened = true;
            }
            mreader.Close();

            quest = $"SELECT * FROM `etudiant_filiere_annee_annee_scolaire` WHERE id_etudiant={id_etud.Text};";
            mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            while(mreader.Read())
            {
                annees.SelectedValue = mreader.GetInt32(2);
                filieres.SelectedValue = mreader.GetInt32(1);
                annee.Text = mreader.GetString(3);

            }
            mreader.Close();





            MessageBox.Show("Données chargées avec succès depuis le fichier.");
        }

        private void Load_Data()
        {
            listView1.Items.Clear();
            string quest = $"select * from etudiant ORDER by nom ASC";
            DataTable dataTable = DatabaseUtility.RemplirDataGridView(quest);
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id_etudiant"].ToString());
                item.SubItems.Add(row["nom"].ToString());
                item.SubItems.Add(row["prenom"].ToString());
                item.SubItems.Add(row["birthday"].ToString());
                item.SubItems.Add(row["sexe"].ToString());
                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["tele"].ToString());
                listView1.Items.Add(item);
            }
        }
        private void Etudiants_Load(object sender, EventArgs e)
        {
            string quest = "Select id_filiere,filiere from filieres";
            DataTable dt = DatabaseUtility.RemplirDataGridView(quest);
            filieres.DataSource = dt;
            filieres.DisplayMember = "filiere";
            filieres.ValueMember = "id_filiere";

            //

            quest = "Select id_annee,annee_scolaire from annees_scolaires";
            dt = DatabaseUtility.RemplirDataGridView(quest);
            annees.DataSource = dt;
            annees.DisplayMember = "annee_scolaire";
            annees.ValueMember = "id_annee";

            Load_Data();
        }

        private void Validation_Click(object sender, EventArgs e)
        {
            string nm = nom_etud.Text;
            string pm = prenom_etud.Text;
            string filiere = filieres.SelectedValue.ToString();
            string numeroTelephone = tel_etud.Text;
            string mail = email.Text;
            string quest;
            string cheminDestination = "";
            string an_sco = annees.SelectedValue.ToString();
            string sexe = " ";
            if (sexe_m.Checked)
            {
                sexe = "Masculin";
            }
            if (sexe_f.Checked)
            {
                sexe = "Féminin";
            }

            string an = annee.Text;

            DateTime dte = date_nais_etud.Value;

            if (opened)
            {
                if (selectimage != null)
                {
                    string cheminImage = selectimage.FileName;
                    string nomFichier = Path.GetFileName(cheminImage);
                    cheminDestination = @"C:\\Users\\Léo\\source\\repos\\GestSchool\\Students\\" +  nomFichier ;
                }


                quest = $"Insert Into etudiant(nom , prenom , birthday , sexe , email ,  tele , photo ) Values('{nm}' , '{pm}' , '{dte}' , '{sexe}' , '{mail}' , '{numeroTelephone}' , '{cheminDestination}' );";
            }
            else
            {
                quest = $"Insert Into etudiant(nom , prenom , birthday , sexe , email , tele ) Values('{nm}' , '{pm}' , '{dte}' , '{sexe}' , '{mail}' , '{numeroTelephone}' );";
            }

            DatabaseUtility.ExecuterRequete(quest);
            nom_etud.Text = cheminDestination;
            quest = $"select id_etudiant from etudiant";
            MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            int id_etudiant = 0;
            while (mreader.Read())
            {
               id_etudiant = mreader.GetInt32(0);
            }
            mreader.Close();
            quest = $"INSERT INTO `etudiant_filiere_annee_annee_scolaire`(`id_etudiant`, `id_filiere`, `id_annee_scolaire`, `annee`) VALUES ('{id_etudiant}','{filiere}','{an_sco}','{an}');";
            DatabaseUtility.ExecuterRequete(quest);

            Load_Data();

            MessageBox.Show($"Les informations ont été enregistrées avec succès");

        }

        private void Photo_etud_Click(object sender, EventArgs e)
        {
            string cheminDestination = "";
            selectimage = new OpenFileDialog();
            if (selectimage.ShowDialog() == DialogResult.OK)
            {
                opened = true;
                pictureBox1.Image = new Bitmap(selectimage.FileName);

                string cheminImage = selectimage.FileName;
                string nomFichier = Path.GetFileName(cheminImage);
                cheminDestination = Path.Combine(@"C:\Users\Léo\source\repos\GestSchool\Students", nomFichier);

                if (cheminImage != null)
                {
                    try
                    {
                        System.IO.File.Copy(cheminImage, cheminDestination, true);
                        MessageBox.Show($"L'image a été enregistré avec succès.", "Enregistrer");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'enregistrement de l'image: {ex.Message}", "Erreur");
                    }
                }


            }
        }

        //private void Check_Click_1(object sender, EventArgs e)
        //{
        //    string pk = id_etud.Text;
        //    string quest = $"select nom , prenom , birthday , sexe , email , tele , photo from etudiant where id_etudiant={pk};";
        //    MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
        //    while (mreader.Read())
        //    {
        //        nom_etud.Text = mreader.GetString(0);
        //        prenom_etud.Text = mreader.GetString(1);
        //        date_nais_etud.Text = mreader.GetString(2);
        //        email.Text = mreader.GetString(4);
        //        tel_etud.Text = mreader.GetString(5);
        //        string sexe = mreader.GetString(3);
        //        if (sexe == "Masculin")
        //        {
        //            sexe_m.Checked = true;
        //        }
        //        if (sexe == "Féminin")
        //        {
        //            sexe_f.Checked = true;
        //        }

        //        bool bitm;
        //        try
        //        {
        //            new Bitmap(mreader.GetString(6));
        //            bitm = true;
        //        }
        //        catch (Exception err)
        //        {
        //            bitm = false;
        //        }
        //        if (bitm)
        //        {
        //            pictureBox1.Image = new Bitmap(mreader.GetString(6));

        //        }

        //        string cheminDestination = mreader.GetString(6);
        //        opened = true;

        //        MessageBox.Show("Données chargées avec succès depuis le fichier.");
        //    }
        //    mreader.Close();
        //}

        private void Update_Click_1(object sender, EventArgs e)
        {
            string pk = id_etud.Text;
            string nm = nom_etud.Text;
            string pm = prenom_etud.Text;
            string filiere = filieres.SelectedValue.ToString();
            string numeroTelephone = tel_etud.Text;
            string mail = email.Text;
            string quest;
            string cheminDestination = "";
            string an_sco = annees.SelectedValue.ToString();
            string sexe = " ";
            if (sexe_m.Checked)
            {
                sexe = "Masculin";
            }
            if (sexe_f.Checked)
            {
                sexe = "Féminin";
            }

            string an = annee.Text;

            DateTime dte = date_nais_etud.Value;

            if (opened)
            {
                if (selectimage != null)
                {
                    string cheminImage = selectimage.FileName;
                    string nomFichier = Path.GetFileName(cheminImage);
                    cheminDestination = @"C:\\Users\\Léo\\source\\repos\\GestSchool\\Students\\" + nomFichier;
                }


                quest = $"UPDATE `etudiant` set `nom`='{nm}',`prenom`='{pm}',`birthday`='{dte}',`sexe`='{sexe}',`email`='{mail}',`tele`='{numeroTelephone}',`photo`='{cheminDestination}' WHERE id_etudiant={pk};";
            }
            else
            {
                quest = $"UPDATE `etudiant` set `nom`='{nm}',`prenom`='{pm}',`birthday`='{dte}',`sexe`='{sexe}',`email`='{mail}',`tele`='{numeroTelephone}' WHERE id_etudiant={pk};";
            }

            DatabaseUtility.ExecuterRequete(quest);
            
            quest = $"UPDATE `etudiant_filiere_annee_annee_scolaire` SET `id_filiere`='{filiere}',`id_annee_scolaire`='{annees.Text}',`annee`='{an}' WHERE id_etudiant = {pk};";
            DatabaseUtility.ExecuterRequete(quest);

            Load_Data();

            MessageBox.Show($"Les informations ont été enregistrées avec succès");



            Load_Data();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click_1(object sender, EventArgs e)
        {
            string quest = $"delete from etudiant where id_etudiant={id_etud.Text};";
            Load_Data();
            MessageBox.Show("Données supprimées avec succès");
        }

        private void Photo_etud_Click_1(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Annee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            acceuil form = new acceuil();
            form.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

