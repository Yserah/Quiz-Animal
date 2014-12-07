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
            this.txtrichDetails = new System.Windows.Forms.RichTextBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblReponse3 = new System.Windows.Forms.Label();
            this.lblReponse2 = new System.Windows.Forms.Label();
            this.lblReponse1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.Parcourir = new System.Windows.Forms.TabPage();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtDescriptions = new System.Windows.Forms.RichTextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
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
            this.Onglet.Size = new System.Drawing.Size(634, 512);
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
            this.tabPage1.Size = new System.Drawing.Size(626, 486);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Choix questionnaire !";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(10, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(525, 313);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // rbChat
            // 
            this.rbChat.AccessibleName = "Chats";
            this.rbChat.AutoSize = true;
            this.rbChat.Location = new System.Drawing.Point(151, 8);
            this.rbChat.Name = "rbChat";
            this.rbChat.Size = new System.Drawing.Size(121, 17);
            this.rbChat.TabIndex = 2;
            this.rbChat.Text = "Questionnaire Chat !";
            this.rbChat.UseVisualStyleBackColor = true;
            this.rbChat.CheckedChanged += new System.EventHandler(this.rbChat_CheckedChanged);
            // 
            // rbPokemon
            // 
            this.rbPokemon.AccessibleName = "Pokemons";
            this.rbPokemon.AutoSize = true;
            this.rbPokemon.Location = new System.Drawing.Point(289, 8);
            this.rbPokemon.Name = "rbPokemon";
            this.rbPokemon.Size = new System.Drawing.Size(144, 17);
            this.rbPokemon.TabIndex = 1;
            this.rbPokemon.Text = "Questionnaire Pokémon !";
            this.rbPokemon.UseVisualStyleBackColor = true;
            this.rbPokemon.CheckedChanged += new System.EventHandler(this.rbPokemon_CheckedChanged);
            // 
            // rbChien
            // 
            this.rbChien.AccessibleName = "Chiens";
            this.rbChien.AutoSize = true;
            this.rbChien.Location = new System.Drawing.Point(7, 7);
            this.rbChien.Name = "rbChien";
            this.rbChien.Size = new System.Drawing.Size(126, 17);
            this.rbChien.TabIndex = 0;
            this.rbChien.Text = "Questionnaire Chien !";
            this.rbChien.UseVisualStyleBackColor = true;
            this.rbChien.CheckedChanged += new System.EventHandler(this.rbChien_CheckedChanged);
            // 
            // QuizTab
            // 
            this.QuizTab.Controls.Add(this.txtrichDetails);
            this.QuizTab.Controls.Add(this.btnSuivant);
            this.QuizTab.Controls.Add(this.lblNumber);
            this.QuizTab.Controls.Add(this.lblPoint);
            this.QuizTab.Controls.Add(this.lblReponse3);
            this.QuizTab.Controls.Add(this.lblReponse2);
            this.QuizTab.Controls.Add(this.lblReponse1);
            this.QuizTab.Controls.Add(this.pictureBox1);
            this.QuizTab.Controls.Add(this.btnDemarrer);
            this.QuizTab.Location = new System.Drawing.Point(4, 22);
            this.QuizTab.Name = "QuizTab";
            this.QuizTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuizTab.Size = new System.Drawing.Size(626, 486);
            this.QuizTab.TabIndex = 0;
            this.QuizTab.Text = "Quiz !";
            // 
            // txtrichDetails
            // 
            this.txtrichDetails.Location = new System.Drawing.Point(424, 253);
            this.txtrichDetails.Name = "txtrichDetails";
            this.txtrichDetails.ReadOnly = true;
            this.txtrichDetails.Size = new System.Drawing.Size(196, 227);
            this.txtrichDetails.TabIndex = 13;
            this.txtrichDetails.Text = "";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(6, 415);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 42);
            this.btnSuivant.TabIndex = 12;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(17, 361);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(20, 22);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "0";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(17, 331);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(49, 20);
            this.lblPoint.TabIndex = 9;
            this.lblPoint.Text = "Point:";
            // 
            // lblReponse3
            // 
            this.lblReponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse3.Location = new System.Drawing.Point(135, 403);
            this.lblReponse3.Name = "lblReponse3";
            this.lblReponse3.Size = new System.Drawing.Size(283, 77);
            this.lblReponse3.TabIndex = 8;
            this.lblReponse3.Text = "label3";
            this.lblReponse3.Visible = false;
            this.lblReponse3.Click += new System.EventHandler(this.lblReponse3_Click);
            // 
            // lblReponse2
            // 
            this.lblReponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse2.Location = new System.Drawing.Point(135, 326);
            this.lblReponse2.Name = "lblReponse2";
            this.lblReponse2.Size = new System.Drawing.Size(283, 77);
            this.lblReponse2.TabIndex = 7;
            this.lblReponse2.Text = "label2";
            this.lblReponse2.Visible = false;
            this.lblReponse2.Click += new System.EventHandler(this.lblReponse2_Click);
            // 
            // lblReponse1
            // 
            this.lblReponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse1.Location = new System.Drawing.Point(135, 253);
            this.lblReponse1.Name = "lblReponse1";
            this.lblReponse1.Size = new System.Drawing.Size(283, 73);
            this.lblReponse1.TabIndex = 6;
            this.lblReponse1.Text = "label1";
            this.lblReponse1.Visible = false;
            this.lblReponse1.Click += new System.EventHandler(this.lblReponse1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrer.Location = new System.Drawing.Point(6, 253);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(111, 61);
            this.btnDemarrer.TabIndex = 5;
            this.btnDemarrer.Text = "Demarrer";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // Parcourir
            // 
            this.Parcourir.Controls.Add(this.txtNom);
            this.Parcourir.Controls.Add(this.lblNom);
            this.Parcourir.Controls.Add(this.txtDescriptions);
            this.Parcourir.Controls.Add(this.lblDetails);
            this.Parcourir.Controls.Add(this.lblSerie);
            this.Parcourir.Controls.Add(this.comboBox1);
            this.Parcourir.Controls.Add(this.btnAjouter);
            this.Parcourir.Controls.Add(this.txtParcourrir);
            this.Parcourir.Controls.Add(this.parcourrir);
            this.Parcourir.Controls.Add(this.pictureBox2);
            this.Parcourir.Location = new System.Drawing.Point(4, 22);
            this.Parcourir.Name = "Parcourir";
            this.Parcourir.Padding = new System.Windows.Forms.Padding(3);
            this.Parcourir.Size = new System.Drawing.Size(626, 486);
            this.Parcourir.TabIndex = 1;
            this.Parcourir.Text = "Ajouter une nouvelle image !";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(437, 32);
            this.txtNom.MaxLength = 25;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 11;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(434, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom:";
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Location = new System.Drawing.Point(437, 130);
            this.txtDescriptions.MaxLength = 150;
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(161, 69);
            this.txtDescriptions.TabIndex = 9;
            this.txtDescriptions.Text = "";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(439, 114);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(42, 13);
            this.lblDetails.TabIndex = 8;
            this.lblDetails.Text = "Details:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(439, 55);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(37, 13);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Serie :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chat",
            "Chien",
            "Pokemon"});
            this.comboBox1.Location = new System.Drawing.Point(437, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(484, 219);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtParcourrir
            // 
            this.txtParcourrir.Location = new System.Drawing.Point(16, 422);
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
            this.pictureBox2.Size = new System.Drawing.Size(422, 391);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // QuizAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 536);
            this.Controls.Add(this.Onglet);
            this.Name = "QuizAnimal";
            this.Text = "Quiz Animal!!";
            this.Load += new System.EventHandler(this.QuizAnimal_Load);
            this.Onglet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.QuizTab.ResumeLayout(false);
            this.QuizTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Parcourir.ResumeLayout(false);
            this.Parcourir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Parcourir;
        private System.Windows.Forms.TabControl Onglet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button parcourrir;
        private System.Windows.Forms.TextBox txtParcourrir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbChat;
        private System.Windows.Forms.RadioButton rbPokemon;
        private System.Windows.Forms.RadioButton rbChien;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TabPage QuizTab;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblReponse3;
        private System.Windows.Forms.Label lblReponse2;
        private System.Windows.Forms.Label lblReponse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.RichTextBox txtrichDetails;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.RichTextBox txtDescriptions;
    }
}

