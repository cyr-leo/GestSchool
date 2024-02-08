using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestSchool
{
    public partial class Matiere : Form
    {
        public Matiere()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void Matiere_Load(object sender, EventArgs e)
        {
            listView1.MouseClick += ListView1_MouseClick;
            Load_Data();

        }

        private static string id_matiere ;
        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Récupérer l'élément à l'emplacement du clic
            ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);

            // Vérifier si un élément a été cliqué
            if (clickedItem != null)
            {
                // Charger les informations dans les TextBox
                name.Text = clickedItem.SubItems[1].Text;
                id_matiere = clickedItem.SubItems[0].Text;
            }

      
            MessageBox.Show("Données chargées avec succès depuis le fichier.");
        }

        private void Load_Data()
        {
            listView1.Items.Clear();
            string quest = $"select * from matieres ORDER by matiere ASC";
            DataTable dataTable = DatabaseUtility.RemplirDataGridView(quest);
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id_matiere"].ToString());
                item.SubItems.Add(row["matiere"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string nom_matiere = name.Text;
            string quest = $"Insert Into matieres(matiere) Values('{nom_matiere}');";
            DatabaseUtility.ExecuterRequete(quest);
            Load_Data();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string nom_matiere = name.Text;

            string quest = $"Update matieres set matiere='{nom_matiere}' where id_matiere={id_matiere};";
            DatabaseUtility.ExecuterRequete(quest);
            Load_Data();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string nom_matiere = name.Text;

            string quest = $"Delete from matieres  where id_matiere={id_matiere};";
            DatabaseUtility.ExecuterRequete(quest);
            Load_Data();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            acceuil form = new acceuil();
            form.Show();
            this.Hide();
        }
    }
}
