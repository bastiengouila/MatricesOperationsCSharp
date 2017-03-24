namespace Matrice
{
    partial class CInterface
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
            this.Addition = new System.Windows.Forms.Button();
            this.Soustraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Matrice1 = new System.Windows.Forms.Label();
            this.Matrice2 = new System.Windows.Forms.Label();
            this.textBoxMat2 = new System.Windows.Forms.TextBox();
            this.textBoxMat1 = new System.Windows.Forms.TextBox();
            this.ValidationMat2 = new System.Windows.Forms.Button();
            this.ValidationMat1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLigneMat1 = new System.Windows.Forms.TextBox();
            this.textBoxColonneMat1 = new System.Windows.Forms.TextBox();
            this.textBoxColonneMat2 = new System.Windows.Forms.TextBox();
            this.textBoxLigneMat2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ValidationParametreMat1 = new System.Windows.Forms.Button();
            this.ValidationParametreMat2 = new System.Windows.Forms.Button();
            this.labelNewItemMat1 = new System.Windows.Forms.Label();
            this.labelNewItemMat2 = new System.Windows.Forms.Label();
            this.MultiplicationReel = new System.Windows.Forms.Button();
            this.textBoxCoeff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(228, 38);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(85, 23);
            this.Addition.TabIndex = 0;
            this.Addition.Text = "Mat1+ Mat2";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // Soustraction
            // 
            this.Soustraction.Location = new System.Drawing.Point(228, 67);
            this.Soustraction.Name = "Soustraction";
            this.Soustraction.Size = new System.Drawing.Size(85, 23);
            this.Soustraction.TabIndex = 1;
            this.Soustraction.Text = "Mat1 - Mat2";
            this.Soustraction.UseVisualStyleBackColor = true;
            this.Soustraction.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(228, 96);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(85, 23);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.Text = "Mat1 x Mat2";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // Matrice1
            // 
            this.Matrice1.AutoSize = true;
            this.Matrice1.Location = new System.Drawing.Point(33, 22);
            this.Matrice1.Name = "Matrice1";
            this.Matrice1.Size = new System.Drawing.Size(138, 13);
            this.Matrice1.TabIndex = 5;
            this.Matrice1.Text = "Matrice 1 (Remplir par ligne)";
            // 
            // Matrice2
            // 
            this.Matrice2.AutoSize = true;
            this.Matrice2.Location = new System.Drawing.Point(365, 22);
            this.Matrice2.Name = "Matrice2";
            this.Matrice2.Size = new System.Drawing.Size(138, 13);
            this.Matrice2.TabIndex = 6;
            this.Matrice2.Text = "Matrice 2 (Remplir par ligne)";
            // 
            // textBoxMat2
            // 
            this.textBoxMat2.Location = new System.Drawing.Point(338, 38);
            this.textBoxMat2.Multiline = true;
            this.textBoxMat2.Name = "textBoxMat2";
            this.textBoxMat2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMat2.Size = new System.Drawing.Size(189, 23);
            this.textBoxMat2.TabIndex = 7;
            // 
            // textBoxMat1
            // 
            this.textBoxMat1.Location = new System.Drawing.Point(12, 38);
            this.textBoxMat1.Multiline = true;
            this.textBoxMat1.Name = "textBoxMat1";
            this.textBoxMat1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMat1.Size = new System.Drawing.Size(180, 23);
            this.textBoxMat1.TabIndex = 8;
            // 
            // ValidationMat2
            // 
            this.ValidationMat2.Location = new System.Drawing.Point(338, 67);
            this.ValidationMat2.Name = "ValidationMat2";
            this.ValidationMat2.Size = new System.Drawing.Size(189, 23);
            this.ValidationMat2.TabIndex = 9;
            this.ValidationMat2.Text = "Validation Matrice 2";
            this.ValidationMat2.UseVisualStyleBackColor = true;
            this.ValidationMat2.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // ValidationMat1
            // 
            this.ValidationMat1.Location = new System.Drawing.Point(12, 67);
            this.ValidationMat1.Name = "ValidationMat1";
            this.ValidationMat1.Size = new System.Drawing.Size(178, 23);
            this.ValidationMat1.TabIndex = 10;
            this.ValidationMat1.Text = "Validation Matrice 1";
            this.ValidationMat1.UseVisualStyleBackColor = true;
            this.ValidationMat1.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nbr de lignes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nbr de colonnes";
            // 
            // textBoxLigneMat1
            // 
            this.textBoxLigneMat1.Location = new System.Drawing.Point(107, 143);
            this.textBoxLigneMat1.Name = "textBoxLigneMat1";
            this.textBoxLigneMat1.Size = new System.Drawing.Size(85, 20);
            this.textBoxLigneMat1.TabIndex = 14;
            // 
            // textBoxColonneMat1
            // 
            this.textBoxColonneMat1.Location = new System.Drawing.Point(107, 169);
            this.textBoxColonneMat1.Name = "textBoxColonneMat1";
            this.textBoxColonneMat1.Size = new System.Drawing.Size(85, 20);
            this.textBoxColonneMat1.TabIndex = 15;
            // 
            // textBoxColonneMat2
            // 
            this.textBoxColonneMat2.Location = new System.Drawing.Point(440, 167);
            this.textBoxColonneMat2.Name = "textBoxColonneMat2";
            this.textBoxColonneMat2.Size = new System.Drawing.Size(85, 20);
            this.textBoxColonneMat2.TabIndex = 19;
            // 
            // textBoxLigneMat2
            // 
            this.textBoxLigneMat2.Location = new System.Drawing.Point(440, 141);
            this.textBoxLigneMat2.Name = "textBoxLigneMat2";
            this.textBoxLigneMat2.Size = new System.Drawing.Size(85, 20);
            this.textBoxLigneMat2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nbr de colonnes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nbr de lignes";
            // 
            // ValidationParametreMat1
            // 
            this.ValidationParametreMat1.Location = new System.Drawing.Point(19, 200);
            this.ValidationParametreMat1.Name = "ValidationParametreMat1";
            this.ValidationParametreMat1.Size = new System.Drawing.Size(173, 23);
            this.ValidationParametreMat1.TabIndex = 20;
            this.ValidationParametreMat1.Text = "Validation Parametres Matrice 1";
            this.ValidationParametreMat1.UseVisualStyleBackColor = true;
            this.ValidationParametreMat1.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // ValidationParametreMat2
            // 
            this.ValidationParametreMat2.Location = new System.Drawing.Point(338, 200);
            this.ValidationParametreMat2.Name = "ValidationParametreMat2";
            this.ValidationParametreMat2.Size = new System.Drawing.Size(189, 23);
            this.ValidationParametreMat2.TabIndex = 21;
            this.ValidationParametreMat2.Text = "Validation Parametres Matrice 2";
            this.ValidationParametreMat2.UseVisualStyleBackColor = true;
            this.ValidationParametreMat2.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // labelNewItemMat1
            // 
            this.labelNewItemMat1.AutoSize = true;
            this.labelNewItemMat1.Location = new System.Drawing.Point(12, 93);
            this.labelNewItemMat1.Name = "labelNewItemMat1";
            this.labelNewItemMat1.Size = new System.Drawing.Size(119, 13);
            this.labelNewItemMat1.TabIndex = 22;
            this.labelNewItemMat1.Text = "Nouvel élément ajouté :";
            // 
            // labelNewItemMat2
            // 
            this.labelNewItemMat2.AutoSize = true;
            this.labelNewItemMat2.Location = new System.Drawing.Point(335, 93);
            this.labelNewItemMat2.Name = "labelNewItemMat2";
            this.labelNewItemMat2.Size = new System.Drawing.Size(119, 13);
            this.labelNewItemMat2.TabIndex = 23;
            this.labelNewItemMat2.Text = "Nouvel élément ajouté :";
            // 
            // MultiplicationReel
            // 
            this.MultiplicationReel.Location = new System.Drawing.Point(228, 136);
            this.MultiplicationReel.Name = "MultiplicationReel";
            this.MultiplicationReel.Size = new System.Drawing.Size(85, 23);
            this.MultiplicationReel.TabIndex = 24;
            this.MultiplicationReel.Text = "Mat1 x k";
            this.MultiplicationReel.UseVisualStyleBackColor = true;
            this.MultiplicationReel.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // textBoxCoeff
            // 
            this.textBoxCoeff.Location = new System.Drawing.Point(228, 165);
            this.textBoxCoeff.Name = "textBoxCoeff";
            this.textBoxCoeff.Size = new System.Drawing.Size(85, 20);
            this.textBoxCoeff.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 279);
            this.Controls.Add(this.textBoxCoeff);
            this.Controls.Add(this.MultiplicationReel);
            this.Controls.Add(this.labelNewItemMat2);
            this.Controls.Add(this.labelNewItemMat1);
            this.Controls.Add(this.ValidationParametreMat2);
            this.Controls.Add(this.ValidationParametreMat1);
            this.Controls.Add(this.textBoxColonneMat2);
            this.Controls.Add(this.textBoxLigneMat2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxColonneMat1);
            this.Controls.Add(this.textBoxLigneMat1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidationMat1);
            this.Controls.Add(this.ValidationMat2);
            this.Controls.Add(this.textBoxMat1);
            this.Controls.Add(this.textBoxMat2);
            this.Controls.Add(this.Matrice2);
            this.Controls.Add(this.Matrice1);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Soustraction);
            this.Controls.Add(this.Addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Soustraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Label Matrice1;
        private System.Windows.Forms.Label Matrice2;
        private System.Windows.Forms.TextBox textBoxMat2;
        private System.Windows.Forms.TextBox textBoxMat1;
        private System.Windows.Forms.Button ValidationMat2;
        private System.Windows.Forms.Button ValidationMat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLigneMat1;
        private System.Windows.Forms.TextBox textBoxColonneMat1;
        private System.Windows.Forms.TextBox textBoxColonneMat2;
        private System.Windows.Forms.TextBox textBoxLigneMat2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ValidationParametreMat1;
        private System.Windows.Forms.Button ValidationParametreMat2;
        private System.Windows.Forms.Label labelNewItemMat1;
        private System.Windows.Forms.Label labelNewItemMat2;
        private System.Windows.Forms.Button MultiplicationReel;
        private System.Windows.Forms.TextBox textBoxCoeff;
    }
}

