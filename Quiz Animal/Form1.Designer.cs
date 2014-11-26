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
            this.QuizTab = new System.Windows.Forms.TabPage();
            this.Ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Parcourir = new System.Windows.Forms.TabPage();
            this.txtParcourrir = new System.Windows.Forms.TextBox();
            this.parcourrir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Onglet.SuspendLayout();
            this.QuizTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Parcourir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Onglet
            // 
            this.Onglet.Controls.Add(this.QuizTab);
            this.Onglet.Controls.Add(this.Parcourir);
            this.Onglet.Location = new System.Drawing.Point(12, 12);
            this.Onglet.Name = "Onglet";
            this.Onglet.SelectedIndex = 0;
            this.Onglet.Size = new System.Drawing.Size(546, 482);
            this.Onglet.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Onglet.TabIndex = 0;
            this.Onglet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onglet_KeyDown);
            // 
            // QuizTab
            // 
            this.QuizTab.Controls.Add(this.Ok);
            this.QuizTab.Controls.Add(this.textBox1);
            this.QuizTab.Controls.Add(this.pictureBox1);
            this.QuizTab.Location = new System.Drawing.Point(4, 22);
            this.QuizTab.Name = "QuizTab";
            this.QuizTab.Padding = new System.Windows.Forms.Padding(3);
            this.QuizTab.Size = new System.Drawing.Size(538, 456);
            this.QuizTab.TabIndex = 0;
            this.QuizTab.Text = "Quiz !";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(386, 400);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 400);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 354);
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
            this.QuizTab.ResumeLayout(false);
            this.QuizTab.PerformLayout();
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
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button parcourrir;
        private System.Windows.Forms.TextBox txtParcourrir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

