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
    public partial class Annee : Form
    {
        public Annee()
        {
            InitializeComponent();
            comboBox2.Enabled = false;
            id_annee.Enabled = false;
            listView1.MouseClick += ListView1_MouseClick;
            listView1.HeaderStyle = ColumnHeaderStyle.Clickable; // ou ColumnHeaderStyle.Nonclickable selon vos besoins
        }
        private int val1, val2;

        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Récupérer l'élément à l'emplacement du clic
            ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);

            // Vérifier si un élément a été cliqué
            if (clickedItem != null)
            {
                // Charger les informations dans les TextBox
                string[] anneeArray = clickedItem.SubItems[1].Text.Split('-');
                comboBox1.Text = anneeArray[0];
                comboBox2.Text = anneeArray[1];
                id_annee.Text = clickedItem.SubItems[0].Text; 
            }
        }
        

        private void List_Load()
        {
            listView1.Items.Clear();

            string quest = $"select id_annee , annee_scolaire from annees_scolaires";
            DataTable dataTable = DatabaseUtility.RemplirDataGridView(quest);
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id_annee"].ToString());
                item.SubItems.Add(row["annee_scolaire"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void Annee_Load(object sender, EventArgs e)
        {
            List_Load();
            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
        private void Id_annee_TextChanged(object sender, EventArgs e)
        {
            string pk = id_annee.Text;
            string quest = $"select annee_scolaire from annees_scolaires where id_annee={pk};";
            if(pk!= null)
            {
                MySqlDataReader mreader = DatabaseUtility.ExecuterRequeteAvecLecteur(quest);
                while (mreader.Read())
                {
                    string anee = mreader.GetString(0);
                    string[] anneeArray = anee.Split('-');

                    comboBox1.Text = anneeArray[0];
                    comboBox2.Text = anneeArray[1];



                    MessageBox.Show("Données chargées avec succès depuis le fichier.");
                }
                mreader.Close();
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Update_Click_1(object sender, EventArgs e)
        {
            string quest = $"update annees_scolaires set annee_scolaire='{comboBox1.Text} - {comboBox2.Text}' where id_annee='{id_annee.Text}';";
            DatabaseUtility.ExecuterRequete(quest);
            List_Load();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            acceuil form = new acceuil();
            form.Show();
            this.Hide();
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem?.ToString(), out val1))
            {
                val2 = val1 + 1;
                comboBox2.Text = $"{val2}";
            }
            else
            {
                MessageBox.Show("Sélection invalide. Veuillez choisir une valeur numérique.");

            }
        }

        private void Enregistrer_annee_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string quest = $"Insert into annees_scolaires(annee_scolaire) Values('{val1}-{val2}')";
                DatabaseUtility.ExecuterRequete(quest);

                MessageBox.Show("Commande exécutée avec succès.");

                List_Load();
            }
        }

        private void Supprimer_Click_1(object sender, EventArgs e)
        {
            string quest = $"delete from annees_scolaires where id_annee={id_annee.Text};";
            DatabaseUtility.ExecuterRequete(quest);
            MessageBox.Show("Données supprimées avec succès");

            List_Load();

        }

       
    }
        
}
