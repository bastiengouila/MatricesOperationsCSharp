namespace Matrice
{
    partial class CMatrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMatrice = new System.Windows.Forms.Label();
            this.labelDeterminant = new System.Windows.Forms.Label();
            this.ButtonInverse = new System.Windows.Forms.Button();
            this.ButtonTransposee = new System.Windows.Forms.Button();
            this.ButtonDeterminant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMatrice
            // 
            this.labelMatrice.AutoSize = true;
            this.labelMatrice.Location = new System.Drawing.Point(82, 129);
            this.labelMatrice.Name = "labelMatrice";
            this.labelMatrice.Size = new System.Drawing.Size(0, 13);
            this.labelMatrice.TabIndex = 0;
            // 
            // labelDeterminant
            // 
            this.labelDeterminant.AutoSize = true;
            this.labelDeterminant.Location = new System.Drawing.Point(12, 35);
            this.labelDeterminant.Name = "labelDeterminant";
            this.labelDeterminant.Size = new System.Drawing.Size(70, 13);
            this.labelDeterminant.TabIndex = 1;
            this.labelDeterminant.Text = "Determinant :";
            // 
            // ButtonInverse
            // 
            this.ButtonInverse.Location = new System.Drawing.Point(239, 9);
            this.ButtonInverse.Name = "ButtonInverse";
            this.ButtonInverse.Size = new System.Drawing.Size(85, 23);
            this.ButtonInverse.TabIndex = 5;
            this.ButtonInverse.Text = "Inverse";
            this.ButtonInverse.UseVisualStyleBackColor = true;
            this.ButtonInverse.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // ButtonTransposee
            // 
            this.ButtonTransposee.Location = new System.Drawing.Point(126, 9);
            this.ButtonTransposee.Name = "ButtonTransposee";
            this.ButtonTransposee.Size = new System.Drawing.Size(85, 23);
            this.ButtonTransposee.TabIndex = 6;
            this.ButtonTransposee.Text = "Transposée";
            this.ButtonTransposee.UseVisualStyleBackColor = true;
            this.ButtonTransposee.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // ButtonDeterminant
            // 
            this.ButtonDeterminant.Location = new System.Drawing.Point(15, 9);
            this.ButtonDeterminant.Name = "ButtonDeterminant";
            this.ButtonDeterminant.Size = new System.Drawing.Size(85, 23);
            this.ButtonDeterminant.TabIndex = 7;
            this.ButtonDeterminant.Text = "Determinant";
            this.ButtonDeterminant.UseVisualStyleBackColor = true;
            this.ButtonDeterminant.Click += new System.EventHandler(this.On_ClickButton);
            // 
            // CMatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 304);
            this.Controls.Add(this.ButtonDeterminant);
            this.Controls.Add(this.ButtonTransposee);
            this.Controls.Add(this.ButtonInverse);
            this.Controls.Add(this.labelDeterminant);
            this.Controls.Add(this.labelMatrice);
            this.Name = "CMatrice";
            this.Text = "CMatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatrice;
        private System.Windows.Forms.Label labelDeterminant;
        private System.Windows.Forms.Button ButtonInverse;
        private System.Windows.Forms.Button ButtonTransposee;
        private System.Windows.Forms.Button ButtonDeterminant;

    }
}