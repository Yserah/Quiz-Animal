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
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Quiz_Animal
{

    public partial class QuizAnimal : Form
    {
        public class ImagesQuiz
        {
            public ObjectId Id { get; set; }
            public string Nom { get; set; }
            public string Details { get; set; }
            public string Path { get; set; }

        }
        public int IndexLblReponse = 1; // Ou que la reponse est sur les labels du quiz.

        public QuizAnimal()
        {
            InitializeComponent();
        }

        private void parcourrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtParcourrir.Text = dialog.FileName;
                pictureBox2.Image = Image.FromFile(dialog.FileName);
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void QuizAnimal_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Images\t1.jpg");

            // The mongodb 




        }
        private void Onglet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void rbChien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChien.Checked)
            {
                pictureBox3.Image = Image.FromFile(@"Images\chien.jpg");
                comboBox1.Text = "Chien";
            }
        }

        private void rbPokemon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPokemon.Checked)
            {
                pictureBox3.Image = Image.FromFile(@"Images\pokemon.jpg");
                comboBox1.Text = "Pokemon";
            }
        }

        private void rbChat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChat.Checked)
            {
                pictureBox3.Image = Image.FromFile(@"Images\chat.jpg");
                comboBox1.Text = "Chat";
            }
        }

        private void Onglet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Onglet.SelectedIndex != 0)
            {
                if (rbChat.Checked == true || rbChien.Checked == true || rbPokemon.Checked == true)
                {

                }
                else
                {
                    Onglet.SelectedIndex = 0;
                    MessageBox.Show("Veuiller choisir un questionnaire !", "QUESTIONNAIRE !");
                }
            }
        }

        private void lblReponse1_Click(object sender, EventArgs e)
        {
            if (IndexLblReponse == 1) // Reponse Bonne
            {
                lblReponse1.BackColor = Color.PaleGreen;
            }
            else // Reponse pas bonne
            {
                lblReponse1.BackColor = Color.IndianRed;

                if (IndexLblReponse == 2)
                {
                    lblReponse2.BackColor = Color.PaleGreen;
                }
                if (IndexLblReponse == 3)
                {
                    lblReponse3.BackColor = Color.PaleGreen;
                }
            }
        }

        private void lblReponse2_Click(object sender, EventArgs e)
        {
            if (IndexLblReponse == 2) // Reponse Bonne
            {
                lblReponse2.BackColor = Color.PaleGreen;
            }
            else // Reponse pas bonne
            {
                lblReponse2.BackColor = Color.IndianRed;

                if (IndexLblReponse == 1)
                {
                    lblReponse1.BackColor = Color.PaleGreen;
                }
                if (IndexLblReponse == 3)
                {
                    lblReponse3.BackColor = Color.PaleGreen;
                }
            }
        }

        private void lblReponse3_Click(object sender, EventArgs e)
        {
            if (IndexLblReponse == 3) // Reponse Bonne
            {
                lblReponse3.BackColor = Color.PaleGreen;
            }
            else // Reponse pas bonne
            {
                lblReponse3.BackColor = Color.IndianRed;

                if (IndexLblReponse == 1)
                {
                    lblReponse1.BackColor = Color.PaleGreen;
                }
                if (IndexLblReponse == 2)
                {
                    lblReponse2.BackColor = Color.PaleGreen;
                }
            }
        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            btnDemarrer.Text = "Arreter";

            // Changer le texte des lbl par un la reponse aleatoirement ... Et deux autres reponses aleatoires dans la base de donnée;



            lblReponse1.Visible = true;
            lblReponse2.Visible = true;
            lblReponse3.Visible = true;

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image != null && txtNom != null)
            {
                if (!(File.Exists(@"Images\Chat\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg")))
                {
                    if (comboBox1.Text == "Chat")
                    {
                        File.Copy(txtParcourrir.Text, @"Images\Chat\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg");
                    }
                }
                if (!(File.Exists(@"Images\Chat\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg")))
                {
                    if (comboBox1.Text == "Chien")
                    {
                        File.Copy(txtParcourrir.Text, @"Images\Chien\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg");
                    }
                }
                if (!(File.Exists(@"Images\Chat\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg")))
                {
                    if (comboBox1.Text == "Pokemon")
                    {
                        File.Copy(txtParcourrir.Text, @"Images\Pokemon\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg");
                    }
                }
            }
            else
            {
                if (txtNom == null)
                {
                    MessageBox.Show("Entrez un nom");
                }

                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("Pas d'image");
                }
            }
        }
    }

}
