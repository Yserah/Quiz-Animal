using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Animal
{
    public partial class QuizAnimal : Form
    {
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
            pictureBox1.Image = Image.FromFile(@"test\t1.jpg");
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
                pictureBox3.Image = Image.FromFile(@"test\chien.jpg");
        }

        private void rbPokemon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPokemon.Checked)
                pictureBox3.Image = Image.FromFile(@"test\pokemon.jpg");
        }

        private void rbChat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChat.Checked)
                pictureBox3.Image = Image.FromFile(@"test\chat.jpg");
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

    }
}
