namespace Quiz_Animal
{
    partial class QuizAnimal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Onglet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbChat = new System.Windows.Forms.RadioButton();
            this.rbPokemon = new System.Windows.Forms.RadioButton();
            this.rbChien = new System.Windows.Forms.RadioButton();
            this.QuizTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Parcourir = new System.Windows.Forms.TabPage();
            this.txtParcourrir = new System.Windows.Forms.TextBox();
            this.parcourrir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Onglet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.QuizTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Parcourir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Onglet
            // 
            this.Onglet.Controls.Add(this.tabPage1);
            this.Onglet.Controls.Add(this.QuizTab);
            this.Onglet.Controls.Add(this.Parcourir);
            this.Onglet.Location = new System.Drawing.Point(12, 12);
            this.Onglet.Name = "Onglet";
            this.Onglet.SelectedIndex = 0;
            this.Onglet.Size = new System.Drawing.Size(546, 482);
            this.Onglet.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Onglet.TabIndex = 0;
            this.Onglet.SelectedIndexChanged += new System.EventHandler(this.Onglet_SelectedIndexChanged);
            this.Onglet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onglet_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.rbChat);
            this.tabPage1.Controls.Add(this.rbPokemon);
            this.tabPage1.Controls.Add(this.rbChien);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 456);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Choix questionnaire !";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(7, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(525, 371);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // rbChat
            // 
            this.rbChat.AutoSize = true;
            this.rbChat.Location = new System.Drawing.Point(7, 55);
            this.rbChat.Name = "rbChat";
            this.rbChat.Size = new System.Drawing.Size(121, 17);
            this.rbChat.TabIndex = 2;
            this.rbChat.TabStop = true;
            this.rbChat.Text = "Questionnaire Chat !";
            this.rbChat.UseVisualStyleBackColor = true;
            this.rbChat.CheckedChanged += new System.EventHandler(this.rbChat_CheckedChanged);
            // 
            // rbPokemon
            // 
            this.rbPokemon.AutoSize = true;
            this.rbPokemon.Location = new System.Drawing.Point(7, 31);
            this.rbPokemon.Name = "rbPokemon";
            this.rbPokemon.Size = new System.Drawing.Size(144, 17);
            this.rbPokemon.TabIndex = 1;
            this.rbPokemon.TabStop = true;
            this.rbPokemon.Text = "Questionnaire Pokémon !";
            this.rbPokemon.UseVisualStyleBackColor = true;
            this.rbPokemon.CheckedChanged += new System.EventHandler(this.rbPokemon_CheckedChanged);
            // 
            // rbChien
            // 
            this.rbChien.AutoSize = true;
            this.rbChien.Location = new System.Drawing.Point(7, 7);
            this.rbChien.Name = "rbChien";
            this.rbChien.Size = new System.Drawing.Size(126, 17);
            this.rbChien.TabIndex = 0;
            this.rbChien.TabStop = true;
            this.rbChien.Text = "Questionnaire Chien !";
            this.rbChien.UseVisualStyleBackColor = true;
            this.rbChien.CheckedChanged += new System.EventHandler(this.rbChien_CheckedChanged);
            // 
            // QuizTab
            // 
            this.QuizTab.Controls.Add(this.pictureBox1);
            this.QuizTab.Location = new System.Drawing.Point(4, 22);
            this.QuizTab.Name = "QuizTab";
            this.QuizTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuizTab.Size = new System.Drawing.Size(538, 456);
            this.QuizTab.TabIndex = 0;
            this.QuizTab.Text = "Quiz !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Parcourir
            // 
            this.Parcourir.Controls.Add(this.txtParcourrir);
            this.Parcourir.Controls.Add(this.parcourrir);
            this.Parcourir.Controls.Add(this.pictureBox2);
            this.Parcourir.Location = new System.Drawing.Point(4, 22);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Padding = new System.Windows.Forms.Padding(3);
            this.Parcourir.Size = new System.Drawing.Size(538, 456);
            this.Parcourir.TabIndex = 1;
            this.Parcourir.Text = "Ajouter une nouvelle image !";
            // 
            // txtParcourrir
            // 
            this.txtParcourrir.Location = new System.Drawing.Point(16, 419);
            this.txtParcourrir.Name = "txtParcourrir";
            this.txtParcourrir.Size = new System.Drawing.Size(426, 20);
            this.txtParcourrir.TabIndex = 2;
            // 
            // parcourrir
            // 
            this.parcourrir.Location = new System.Drawing.Point(448, 419);
            this.parcourrir.Name = "parcourrir";
            this.parcourrir.Size = new System.Drawing.Size(75, 23);
            this.parcourrir.TabIndex = 1;
            this.parcourrir.Text = "Parcourrir";
            this.parcourrir.UseVisualStyleBackColor = true;
            this.parcourrir.Click += new System.EventHandler(this.parcourrir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(6, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(333, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // QuizAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 506);
            this.Controls.Add(this.Onglet);
            this.Name = "QuizAnimal";
            this.Text = "Quiz Animal!!";
            this.Load += new System.EventHandler(this.QuizAnimal_Load);
            this.Onglet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.QuizTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Parcourir.ResumeLayout(false);
            this.Parcourir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage QuizTab;
        private System.Windows.Forms.TabPage Parcourir;
        private System.Windows.Forms.TabControl Onglet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button parcourrir;
        private System.Windows.Forms.TextBox txtParcourrir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbChat;
        private System.Windows.Forms.RadioButton rbPokemon;
        private System.Windows.Forms.RadioButton rbChien;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

