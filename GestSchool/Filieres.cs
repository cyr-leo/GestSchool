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
    public partial class Filieres : Form
    {
       
        public Filieres()
        {
            InitializeComponent();

            DatabaseUtility.GetConnection();
        }

        

        private void Filieres_Load(object sender, EventArgs e)
        {

        }

        

        
        

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string fil = Filiere.Text;
            string sigle = Sigle.Text;
            string quest;

            quest = $"Insert Into filieres(filiere , sigle ) Values('{fil}' , '{sigle}');";

            DatabaseUtility.ExecuterRequete(quest);

            quest = $"select * from filieres";
            DataTable dt = DatabaseUtility.RemplirDataGridView(quest);
            dataGridView6.DataSource = dt;

            MessageBox.Show($"Les informations ont été enregistrées avec succès");
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string pk = id_filiere.Text;
            string quest = $"select filiere , sigle from filieres where id_filiere={pk};";

            MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
            while (mreader.Read())
            {
                Filiere.Text = mreader.GetString(0);
                Sigle.Text = mreader.GetString(1);
                MessageBox.Show("Données chargées avec succès depuis le fichier.");
            }
            mreader.Close();
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            string fil = Filiere.Text;
            string sigle = Sigle.Text;
            string pk = id_filiere.Text;

            string quest = $"UPDATE filieres SET filiere='{fil}' , sigle = '{sigle}' WHERE id_filiere = {pk};";

            quest = $"select * from filieres";
            DataTable dt = DatabaseUtility.RemplirDataGridView(quest);
            dataGridView6.DataSource = dt;
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            string pk = id_filiere.Text;
            string quest = $"DELETE FROM filieres WHERE id_filiere={pk};";
            DatabaseUtility.ExecuterRequete(quest);

            quest = $"select * from filieres";
            DataTable dt = DatabaseUtility.RemplirDataGridView(quest);
            dataGridView6.DataSource = dt;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Filiere_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Sigle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_filiere_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
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
