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
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    


        private void Gestion_filiere_Click_1(object sender, EventArgs e)
        {
            Filieres formulaire = new Filieres();
            formulaire.Show();
            this.Hide();


        }

        private void Gestion_annee_Click(object sender, EventArgs e)
        {
            Annee formulaire = new Annee();

            formulaire.Show();
            this.Hide();

        }

        private void Gestion_professeur_Click(object sender, EventArgs e)
        {
            Professeur formulaire = new Professeur();
            formulaire.Show();
            this.Hide();

        }

        private void Gestion_etudiant_Click(object sender, EventArgs e)
        {
            Etudiants formulaire = new Etudiants();

            formulaire.Show();
            this.Hide();
        }

        private void Gestion_matiere_Click(object sender, EventArgs e)
        {
            Matiere form = new Matiere();

            form.Show();
            this.Hide();

        }

        private void Gestion_note_Click(object sender, EventArgs e)
        {
            Notes formulaire = new Notes();
            formulaire.Show();
            this.Hide();

        }
    }
}
