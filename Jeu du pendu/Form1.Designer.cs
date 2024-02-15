namespace Jeu_du_pendu
{
    partial class Pendu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMotATrouver = new Label();
            txtProposition = new TextBox();
            lblProposition = new Label();
            grpCases = new GroupBox();
            btnRecommencer = new Button();
            lblErreurs = new Label();
            SuspendLayout();
            // 
            // lblMotATrouver
            // 
            lblMotATrouver.AutoSize = true;
            lblMotATrouver.Location = new Point(40, 43);
            lblMotATrouver.Name = "lblMotATrouver";
            lblMotATrouver.Size = new Size(191, 32);
            lblMotATrouver.TabIndex = 0;
            lblMotATrouver.Text = "Le mot a trouver";
            // 
            // txtProposition
            // 
            txtProposition.Location = new Point(922, 49);
            txtProposition.Name = "txtProposition";
            txtProposition.Size = new Size(200, 39);
            txtProposition.TabIndex = 1;
            txtProposition.KeyPress += txtProposition_KeyPress;
            // 
            // lblProposition
            // 
            lblProposition.AutoSize = true;
            lblProposition.Location = new Point(676, 56);
            lblProposition.Name = "lblProposition";
            lblProposition.Size = new Size(217, 32);
            lblProposition.TabIndex = 2;
            lblProposition.Text = "Votre proposition ?";
            // 
            // grpCases
            // 
            grpCases.Location = new Point(40, 139);
            grpCases.Name = "grpCases";
            grpCases.Size = new Size(1082, 157);
            grpCases.TabIndex = 3;
            grpCases.TabStop = false;
            // 
            // btnRecommencer
            // 
            btnRecommencer.Location = new Point(891, 577);
            btnRecommencer.Name = "btnRecommencer";
            btnRecommencer.Size = new Size(220, 46);
            btnRecommencer.TabIndex = 4;
            btnRecommencer.Text = "Recommencer";
            btnRecommencer.UseVisualStyleBackColor = true;
            btnRecommencer.Click += btnRecommencer_Click;
            // 
            // lblErreurs
            // 
            lblErreurs.AutoSize = true;
            lblErreurs.Location = new Point(45, 357);
            lblErreurs.Name = "lblErreurs";
            lblErreurs.Size = new Size(119, 32);
            lblErreurs.TabIndex = 5;
            lblErreurs.Text = "Erreurs : 0";
            // 
            // Pendu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 677);
            Controls.Add(lblErreurs);
            Controls.Add(btnRecommencer);
            Controls.Add(grpCases);
            Controls.Add(lblProposition);
            Controls.Add(txtProposition);
            Controls.Add(lblMotATrouver);
            Name = "Pendu";
            Text = "Pendu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMotATrouver;
        private TextBox txtProposition;
        private Label lblProposition;
        private GroupBox grpCases;
        private Button btnRecommencer;
        private Label lblErreurs;
    }
}