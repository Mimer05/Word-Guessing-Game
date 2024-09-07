namespace Word_Guessing_Game
{
    partial class Form1
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
            txtIntro = new Label();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // txtIntro
            // 
            txtIntro.AutoSize = true;
            txtIntro.BackColor = Color.MediumSeaGreen;
            txtIntro.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIntro.ForeColor = Color.Snow;
            txtIntro.Location = new Point(130, 88);
            txtIntro.Name = "txtIntro";
            txtIntro.Size = new Size(361, 37);
            txtIntro.TabIndex = 0;
            txtIntro.Text = "Word Guessing Game";
            txtIntro.Click += txtIntro_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Lime;
            btnPlay.FlatStyle = FlatStyle.System;
            btnPlay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.Lime;
            btnPlay.Location = new Point(194, 167);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(220, 41);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            btnPlay.KeyPress += btnPlay_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(622, 339);
            Controls.Add(btnPlay);
            Controls.Add(txtIntro);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Guessing Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIntro;
        private Button btnPlay;
    }
}
