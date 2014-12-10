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
using MongoDB.Driver.Builders;

namespace Quiz_Animal
{
    // mongod --dbpath "
    public partial class QuizAnimal : Form
    {
        // Variable Global

        string NameRadioButtonSelect; // Nom du radio button qui est select.
        public int IndexLblReponse = 1; // Ou que la reponse est sur les labels du quiz.
        public int Point = 0; // Calcul des points 
        bool dejaclick = true; // Permet de savoir si on a déja clicker ou non.
        int indexprecedent = -1; // Permet de garder en mémoire le dernier élément choisi. 


        public class ImagesQuiz
        {

            public int Id { get; set; }
            public string Nom { get; set; }
            public string Details { get; set; }
            public string Path { get; set; }

        }


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

            var client = new MongoClient("mongodb://localhost");

            var serveur = client.GetServer();

            var database = serveur.GetDatabase("QuizAnimal");

            // A partir d'ici la fonctionnalité d'ajouter des series peut etre ajouter. Un jour ... 
            //( Commentaire Personnel ne pas prendre compte dans l'évaluation si se n'est pas neccesaire)

            // Pokemon 

            var pokemons = database.GetCollection<ImagesQuiz>("Pokemons");
            pokemons.RemoveAll();

            string[] files_pokemons1 = Directory.GetFiles(@"Images\Pokemon\");

            string[] files_pokemons2 = new string[files_pokemons1.Count()];

            for (int i = 0; i < files_pokemons1.Count(); ++i)
            {
                string[] Split1 = files_pokemons1[i].Split('\\');
                string[] Split2 = Split1[2].Split('-');

                pokemons.Insert(new ImagesQuiz { Id = i, Nom = Split2[0], Details = Split2[1], Path = files_pokemons1[i] });


            }


            // Chien 

            var chiens = database.GetCollection<ImagesQuiz>("Chiens");
            chiens.RemoveAll();

            string[] files_chiens1 = Directory.GetFiles(@"Images\Chien\");

            string[] files_chiens2 = new string[files_chiens1.Count()];

            for (int i = 0; i < files_chiens1.Count(); ++i)
            {
                string[] Split1 = files_chiens1[i].Split('\\');
                string[] Split2 = Split1[2].Split('-');

                chiens.Insert(new ImagesQuiz { Id = i, Nom = Split2[0], Details = Split2[1], Path = files_chiens1[i] });
            }

            // Chat

            var chats = database.GetCollection<ImagesQuiz>("Chats");
            chats.RemoveAll();

            string[] files_chats1 = Directory.GetFiles(@"Images\Chat\");

            string[] files_chats2 = new string[files_chats1.Count()];

            for (int i = 0; i < files_chats1.Count(); ++i)
            {
                string[] Split1 = files_chats1[i].Split('\\');
                string[] Split2 = Split1[2].Split('-');

                chats.Insert(new ImagesQuiz { Id = i, Nom = Split2[0], Details = Split2[1], Path = files_chats1[i] });
            }
            MessageBox.Show(pokemons.Count() + " ," + chiens.Count() + " ," + chats.Count());
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

                NameRadioButtonSelect = "Chiens";
            }
        }

        private void rbPokemon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPokemon.Checked)
            {
                pictureBox3.Image = Image.FromFile(@"Images\pokemon.jpg");
                comboBox1.Text = "Pokemon";

                NameRadioButtonSelect = "Pokemons";
            }
        }

        private void rbChat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChat.Checked)
            {
                pictureBox3.Image = Image.FromFile(@"Images\chat.jpg");
                comboBox1.Text = "Chat";

                NameRadioButtonSelect = "Chats";
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
            if (lblReponse1.BackColor == SystemColors.Control)        
            {
                if (IndexLblReponse == 1) // Reponse Bonne
                {
                    lblReponse1.BackColor = Color.PaleGreen;
                    Point++;
                    lblNumber.Text = Point.ToString();
                    dejaclick = false;
                }
                else // Reponse pas bonne
                {
                    if (dejaclick)
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
            }
        }

        private void lblReponse2_Click(object sender, EventArgs e)
        {
            if (lblReponse2.BackColor == SystemColors.Control)
            {
                if (IndexLblReponse == 2) // Reponse Bonne
                {
                    lblReponse2.BackColor = Color.PaleGreen;
                    Point++;
                    lblNumber.Text = Point.ToString();
                    dejaclick = false;
                }
                else // Reponse pas bonne
                {
                    if (dejaclick)
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
            }
        }

        private void lblReponse3_Click(object sender, EventArgs e)
        {
            if (lblReponse3.BackColor == SystemColors.Control)
            {
                if (IndexLblReponse == 3) // Reponse Bonne
                {
                    lblReponse3.BackColor = Color.PaleGreen;
                    Point++;
                    lblNumber.Text = Point.ToString();
                    dejaclick = false;
                }
                else // Reponse pas bonne
                {
                    if (dejaclick)
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
            }
        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            if (btnDemarrer.Text == "Demarrer")
            {
                lblReponse1.BackColor = SystemColors.Control;
                lblReponse2.BackColor = SystemColors.Control;
                lblReponse3.BackColor = SystemColors.Control;
                Point = 0;
                lblNumber.Text = "0";

                var client = new MongoClient("mongodb://localhost");

                var serveur = client.GetServer();

                var database = serveur.GetDatabase("QuizAnimal");

                var BD = database.GetCollection<ImagesQuiz>(NameRadioButtonSelect);

                if (BD.Count() >= 3)
                {
                    btnDemarrer.Text = "Arreter";

                    // Changer le texte des lbl par un la reponse aleatoirement ... Et deux autres reponses aleatoires dans la base de donnée;

                    Random random = new Random();

                    int[] MemoryId = new int[2] { -1, -1 }; // Initialise a -1 a cause que 0 peut etre un id valide.

                    int RandomLbl = random.Next(1, 4);

                    int RandomId = random.Next(Convert.ToInt32(BD.Count()));

                    indexprecedent = RandomId;


                    MemoryId[0] = RandomId;

                    IndexLblReponse = RandomLbl;

                    var query = Query<ImagesQuiz>.EQ(p => p.Id, RandomId);

                    ImagesQuiz IQ = BD.FindOne(query);
                    pictureBox1.Image = Image.FromFile(IQ.Path);
                    txtrichDetails.Text = IQ.Details;

                    for (int i = 0; i < 3; i++)
                    {
                        if (RandomLbl == 1)
                        {
                            lblReponse1.Text = IQ.Nom;
                            RandomLbl++;
                        }
                        else if (RandomLbl == 2)
                        {
                            lblReponse2.Text = IQ.Nom;
                            RandomLbl++;
                        }
                        else
                        {
                            lblReponse3.Text = IQ.Nom;
                            RandomLbl = 1;
                        }

                        do
                        {
                            RandomId = random.Next(Convert.ToInt32(BD.Count()));
                        } while (MemoryId[0] == RandomId || MemoryId[1] == RandomId);
                        MemoryId[1] = RandomId;

                        query = Query<ImagesQuiz>.EQ(p => p.Id, RandomId);
                        IQ = BD.FindOne(query);

                    }

                    lblReponse1.Visible = true;
                    lblReponse2.Visible = true;
                    lblReponse3.Visible = true;
                    btnSuivant.Visible = true;
                }
                else
                {
                    MessageBox.Show("Besoin de plus d'images !! ( Plus que 3 Veuillez ajouter des images)");
                }
            }
            else
            {
                btnDemarrer.Text = "Demarrer";
                btnSuivant.Visible = false;
                lblReponse1.Visible = false;
                lblReponse2.Visible = false;
                lblReponse3.Visible = false;
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");

            var serveur = client.GetServer();

            var database = serveur.GetDatabase("QuizAnimal");

            if (pictureBox2.Image != null && txtNom != null)
            {
                if (comboBox1.Text == "Chat")
                {
                    if (!(File.Exists(@"Images\Chat\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg")))
                    {

                        File.Copy(txtParcourrir.Text, @"Images\Chat\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg");
                        var chats = database.GetCollection<ImagesQuiz>("Chats");

                    }
                }else if (comboBox1.Text == "Chien")
                {
                    if (!(File.Exists(@"Images\Chien\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg")))
                    {

                        File.Copy(txtParcourrir.Text, @"Images\Chien\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg");
                        var chiens = database.GetCollection<ImagesQuiz>("Chiens");
                    }
                }else if (comboBox1.Text == "Pokemon")
                {
                    if (!(File.Exists(@"Images\Pokemon\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg")))
                    {

                        File.Copy(txtParcourrir.Text, @"Images\Pokemon\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg");
                        var pokemons = database.GetCollection<ImagesQuiz>("Pokemons");
                        pokemons.Insert(new ImagesQuiz { Id = Convert.ToInt32(pokemons.Count()), Nom = txtNom.Text, Details = txtDescriptions.Text, Path = @"Images\Pokemon\" + txtNom.Text + "-" + txtDescriptions.Text + "-.jpg" });
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

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            dejaclick = true;
            lblReponse1.BackColor = SystemColors.Control;
            lblReponse2.BackColor = SystemColors.Control;
            lblReponse3.BackColor = SystemColors.Control;

            var client = new MongoClient("mongodb://localhost");

            var serveur = client.GetServer();

            var database = serveur.GetDatabase("QuizAnimal");

            var BD = database.GetCollection<ImagesQuiz>(NameRadioButtonSelect);

            Random random = new Random();

            int[] MemoryId = new int[2] { -1, -1 }; // Initialise a -1 a cause que 0 peut etre un id valide.

            int RandomLbl = random.Next(1, 4);

            int RandomId = random.Next(Convert.ToInt32(BD.Count()));

            while (RandomId == indexprecedent)
                RandomId = random.Next(Convert.ToInt32(BD.Count()));

            indexprecedent = RandomId;

            MemoryId[0] = RandomId;

            IndexLblReponse = RandomLbl;

            var query = Query<ImagesQuiz>.EQ(p => p.Id, RandomId);

            ImagesQuiz IQ = BD.FindOne(query);
            pictureBox1.Image = Image.FromFile(IQ.Path);
            txtrichDetails.Text = IQ.Details;

            for (int i = 0; i < 3; i++)
            {
                if (RandomLbl == 1)
                {
                    lblReponse1.Text = IQ.Nom;
                    RandomLbl++;
                }
                else if (RandomLbl == 2)
                {
                    lblReponse2.Text = IQ.Nom;
                    RandomLbl++;
                }
                else
                {
                    lblReponse3.Text = IQ.Nom;
                    RandomLbl = 1;
                }

                do
                {
                    RandomId = random.Next(Convert.ToInt32(BD.Count()));
                } while (MemoryId[0] == RandomId || MemoryId[1] == RandomId);
                MemoryId[1] = RandomId;

                query = Query<ImagesQuiz>.EQ(p => p.Id, RandomId);
                IQ = BD.FindOne(query);

            }

        }
    }

}
