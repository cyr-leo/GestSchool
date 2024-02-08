using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GestSchool
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            listView1.MouseClick += ListView1_MouseClick;
            id_etud.Enabled = false;
            moy.Enabled = false;
            note1.Enabled = false;
            note2.Enabled = false;
            note3.Enabled = false;
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            string quest = "Select id_matiere,matiere from matieres";
            DataTable dt = DatabaseUtility.RemplirDataGridView(quest);
            matieres.DataSource = dt;
            matieres.DisplayMember = "matiere";
            matieres.ValueMember = "id_matiere";

            Load_Data();
        }

        private static string id_etudiant;
        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Récupérer l'élément à l'emplacement du clic
            ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);

            // Vérifier si un élément a été cliqué
            if (clickedItem != null)
            {
               id_etudiant = clickedItem.SubItems[0].Text;
                id_etud.Text = id_etudiant;
            }

            string quest = $"select * from etudiants_notes_moyenne where id_etudiant = {id_etudiant};";
            MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            while(mreader.Read())
            {
                matieres.SelectedValue = mreader.GetInt32(1);
                note1.Text = mreader.GetDouble(2).ToString();
                note2.Text = mreader.GetDouble(3).ToString();
                note3.Text = mreader.GetDouble(4).ToString();
                moy.Text = mreader.GetDouble(5).ToString();
            }
            mreader.Close();

            note1.Enabled = true;
            note2.Enabled = true;
            note3.Enabled = true;

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
                listView1.Items.Add(item);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(note1.Text);
            double n2 = Convert.ToDouble(note2.Text);
            double n3 = Convert.ToDouble(note3.Text);
            moy.Text = ((n1 + n2 + n3) / 3).ToString();

            string quest = $"INSERT INTO `etudiants_notes_moyenne`(`id_etudiant`, `id_matiere`, `note1`, `note2`, `note3`, `Moyenne`) VALUES ('{id_etudiant}','{matieres.SelectedValue}','{n1}','{n2}','{n3}','{moy.Text}');";
            DatabaseUtility.ExecuterRequete(quest);


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            acceuil form = new acceuil();
            form.Show();
            this.Hide();
        }
    }
}
