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
    public partial class Professeur : Form
    {
        OpenFileDialog selectimage;
        bool opened;
        private static string quest;
        private static string matieres_ids = "";
        private static string filieres_ids = "";
        DataTable dt;
        public Professeur()
        {
            InitializeComponent();
            listView1.MouseClick += ListView1_MouseClick;
            id_etud.Enabled = false;
            supprimer.Enabled = false;
            update.Enabled = false;

        }

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Récupérer l'élément à l'emplacement du clic
            ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);

            // Vérifier si un élément a été cliqué
            if (clickedItem != null)
            {
                supprimer.Enabled = true;
                update.Enabled = true;


                // Charger les informations dans les TextBox
                nom_prof.Text = clickedItem.SubItems[1].Text;
                prenom_prof.Text = clickedItem.SubItems[2].Text;
                email.Text = clickedItem.SubItems[4].Text;
                tel_etud.Text = clickedItem.SubItems[5].Text;
                string sexe = clickedItem.SubItems[3].Text;
                id_etud.Text = clickedItem.SubItems[0].Text;
                sexe_f.Checked = false;
                sexe_m.Checked = false;
                matieres.ClearSelected();
                filières.ClearSelected();
                pictureBox1.Image = null;
                if (sexe == "Masculin")
                {
                    sexe_m.Checked = true;
                }
                if (sexe == "Féminin")
                {
                    sexe_f.Checked = true;
                }
                string[] matieres_array = matieres_ids.Split(' ');
                if (matieres_array != null)
                {
                    foreach (string i in matieres_array)
                    {
                        if (i != "" && i != " ")
                        {
                            matieres.FindString(i);
                            int index = matieres.FindString(i);
                            if (index != 0 && index != -1)
                            {
                                matieres.SetItemChecked(index, true);
                            }
                        }

                        

                    }

                }
                string[] filieres_array = filieres_ids.Split(' ');
                if (filieres_array != null)
                {
                    foreach (string i in matieres_array)
                    {
                        if(i != "" && i != " ")
                        {
                            int index = filières.FindString(i);
                            if (index != 0 && index != -1)
                            {
                                filières.SetItemChecked(index, true);
                            }
                        }
                        

                    }

                }


            }

            string quest = $"select photo from professeur where id_prof={id_etud.Text};";
            MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            while (mreader.Read())
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
           

            quest = $"SELECT * FROM `professeur_matieres` WHERE id_prof={id_etud.Text};";
            mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            while (mreader.Read())
            {
                annees.SelectedValue = mreader.GetInt32(3);
                matieres_ids = mreader.GetString(1);
                filieres_ids = mreader.GetString(2);

            }
            mreader.Close();





            MessageBox.Show("Données chargées avec succès depuis le fichier.");
        }

        private void Load_Data()
        {
            listView1.Items.Clear();
            string quest = $"select * from professeur ORDER by nom ASC";
            DataTable dataTable = DatabaseUtility.RemplirDataGridView(quest);
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id_prof"].ToString());
                item.SubItems.Add(row["nom"].ToString());
                item.SubItems.Add(row["prenom"].ToString());
                item.SubItems.Add(row["sexe"].ToString());
                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["tele"].ToString());
                listView1.Items.Add(item);
            }
        }
        public List<string> GetSubjects()
        {
            List<string> subjects = new List<string>();

            try
            {

                string query = "SELECT id_matiere , matiere  FROM matieres";

                MySqlDataReader reader = DatabaseUtility.ExecuterRequeteAvecLecteur(query);

                while (reader.Read())
                {
                    string subjectName = (reader["id_matiere"] + " " + reader["matiere"]).ToString();
                    subjects.Add(subjectName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des matières : " + ex.Message);
            }


            return subjects;
        }
        public List<string> GetSubjectsFilieres()
        {
            List<string> subjects = new List<string>();

            try
            {

                string query = "SELECT id_filiere , sigle  FROM filieres";

                MySqlDataReader reader = DatabaseUtility.ExecuterRequeteAvecLecteur(query);

                while (reader.Read())
                {
                    string subjectName = (reader["id_filiere"] + " " + reader["sigle"]).ToString();
                    subjects.Add(subjectName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des matières : " + ex.Message);
            }


            return subjects;
        }

        // Charger les matières dans le ComboBox du formulaire du professeur
        private void LoadSubjectsComboBox()
        {
            List<string> subjects = GetSubjects();
            matieres.Items.Clear(); // Vider le ComboBox

            foreach (string subject in subjects)
            {
                matieres.Items.Add(subject); // Ajouter chaque matière au ComboBox
            }

            subjects = GetSubjectsFilieres();
            filières.Items.Clear(); // Vider le ComboBox

            foreach (string subject in subjects)
            {
                filières.Items.Add(subject); // Ajouter chaque matière au ComboBox
            }
        }

        private void Professeur_Load(object sender, EventArgs e)
        {
            LoadSubjectsComboBox();
            quest = "Select id_annee,annee_scolaire from annees_scolaires";
            dt = DatabaseUtility.RemplirDataGridView(quest);
            annees.DataSource = dt;
            annees.DisplayMember = "annee_scolaire";
            annees.ValueMember = "id_annee";

            Load_Data();


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

        private void Update_Click(object sender, EventArgs e)
        {
            string pk = id_etud.Text;
            string nm = nom_prof.Text;
            string pm = prenom_prof.Text;
            string numeroTelephone = tel_etud.Text;
            string mail = email.Text;
            string quest;
            string cheminDestination = "";
            string an_sco = annees.SelectedValue.ToString();
            string sexe = " ";
            string ids_matieres = " ";
            string ids_filieres = " ";
            if (sexe_m.Checked)
            {
                sexe = "Masculin";
            }
            if (sexe_f.Checked)
            {
                sexe = "Féminin";
            }
            if (matieres.CheckedItems.Count > 0)
            {
                foreach (string i in matieres.CheckedItems)
                {
                    string[] id_nom = i.ToString().Split(' ');
                    ids_matieres += id_nom[0] + "";
                }
            }
            if (filières.CheckedItems.Count > 0)
            {
                foreach (string i in filières.CheckedItems)
                {
                    string[] id_nom = i.ToString().Split(' ');
                    ids_filieres += id_nom[0] + "";
                }

            }


            if (opened)
            {
                if (selectimage != null)
                {
                    string cheminImage = selectimage.FileName;
                    string nomFichier = Path.GetFileName(cheminImage);
                    cheminDestination = @"C:\\Users\\Léo\\source\\repos\\GestSchool\\Students\\" + nomFichier;
                }


                quest = $"UPDATE `professeur` set `nom`='{nm}',`prenom`='{pm}',`sexe`='{sexe}',`email`='{mail}',`tele`='{numeroTelephone}',`photo`='{cheminDestination}' WHERE id_prof={pk};";
            }
            else
            {
                quest = $"UPDATE `professeur` set `nom`='{nm}',`prenom`='{pm}',`sexe`='{sexe}',`email`='{mail}',`tele`='{numeroTelephone}' WHERE id_prof={pk};";
            }

            DatabaseUtility.ExecuterRequete(quest);

            quest = $"UPDATE `professeur_matieres` SET `ids_matieres`='{ids_matieres}' , `ids_filieres`='{ids_filieres}',`id_annee_scolaire`='{annees.Text}' WHERE id_prof = {pk};";
            DatabaseUtility.ExecuterRequete(quest);

            Load_Data();

            MessageBox.Show($"Les informations ont été enregistrées avec succès");



            Load_Data();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Validation_Click(object sender, EventArgs e)
        {
            string nm = nom_prof.Text;
            string pm = prenom_prof.Text;
            string numeroTelephone = tel_etud.Text;
            string mail = email.Text;
            string quest;
            string cheminDestination = "";
            string an_sco = annees.SelectedValue.ToString();
            string sexe = " ";
            string ids_matieres = "";
            string ids_filieres = "";

            if (matieres.CheckedItems.Count > 0)
            {
                foreach (string i in matieres.CheckedItems)
                {
                    string[] id_nom = i.ToString().Split(' ');
                    ids_matieres += " " + id_nom[0];
                }

            }
            if (filières.CheckedItems.Count > 0)
            {
                foreach (string i in filières.CheckedItems)
                {
                    string[] id_nom = i.ToString().Split(' ');
                    ids_filieres += " " + id_nom[0];
                }

            }

            if (sexe_m.Checked)
            {
                sexe = "Masculin";
            }
            if (sexe_f.Checked)
            {
                sexe = "Féminin";
            }



            if (opened)
            {
                if (selectimage != null)
                {
                    string cheminImage = selectimage.FileName;
                    string nomFichier = Path.GetFileName(cheminImage);
                    cheminDestination = @"C:\\Users\\Léo\\source\\repos\\GestSchool\\Students\\" + nomFichier;
                }


                quest = $"Insert Into professeur(nom , prenom  , sexe , email ,  tele , photo ) Values('{nm}' , '{pm}'  , '{sexe}' , '{mail}' , '{numeroTelephone}' , '{cheminDestination}' );";
            }
            else
            {
                quest = $"Insert Into professeur(nom , prenom  , sexe , email , tele ) Values('{nm}' , '{pm}' , '{sexe}' , '{mail}' , '{numeroTelephone}' );";
            }

            DatabaseUtility.ExecuterRequete(quest);
            nom_prof.Text = cheminDestination;
            quest = $"select id_prof from professeur";
            MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            int id_prof = 0;
            while (mreader.Read())
            {
                id_prof = mreader.GetInt32(0);
            }
            mreader.Close();
            quest = $"INSERT INTO `professeur_matieres`(`id_prof`, `ids_matieres`, `ids_filieres`, `id_annee_scolaire` ) VALUES ('{id_prof}','{ids_matieres}','{ids_filieres}','{an_sco}');";
            DatabaseUtility.ExecuterRequete(quest);

            Load_Data();

            MessageBox.Show($"Les informations ont été enregistrées avec succès");

        }

        private void Matieres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            string quest = $"delete from professeur where id_prof={id_etud.Text};";
            DatabaseUtility.ExecuterRequete(quest);
            Load_Data();
            MessageBox.Show("Données supprimées avec succès");
        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            acceuil form = new acceuil();
            form.Show();
            this.Hide();
        }
    }
}
