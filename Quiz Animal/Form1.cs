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

        private void Ok_Click(object sender, EventArgs e)
        {

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
            pictureBox1.Image = Image.FromFile(@"C:\Users\YserahScythe\Pictures\21677_10200149630331545_910023648_n.jpg");
        }
        private void Onglet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                QuizAnimal.ActiveForm.Close();
            }
        }

        

        
        
    }
}
