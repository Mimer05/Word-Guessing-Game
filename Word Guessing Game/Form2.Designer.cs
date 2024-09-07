namespace Word_Guessing_Game
{
    partial class Form2
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
            tbUserInput = new TextBox();
            txtGuessWord = new Label();
            btnGuess = new Button();
            txtWrongGuess = new Label();
            lbWrongGuess = new ListBox();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // tbUserInput
            // 
            tbUserInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUserInput.Location = new Point(152, 143);
            tbUserInput.Name = "tbUserInput";
            tbUserInput.Size = new Size(206, 23);
            tbUserInput.TabIndex = 0;
            // 
            // txtGuessWord
            // 
            txtGuessWord.BackColor = Color.MediumSeaGreen;
            txtGuessWord.Font = new Font("PMingLiU-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGuessWord.Location = new Point(99, 51);
            txtGuessWord.Name = "txtGuessWord";
            txtGuessWord.Size = new Size(302, 79);
            txtGuessWord.TabIndex = 1;
            txtGuessWord.Text = "Guess Word";
            txtGuessWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.MediumSeaGreen;
            btnGuess.FlatStyle = FlatStyle.Popup;
            btnGuess.Font = new Font("PMingLiU-ExtB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuess.Location = new Point(186, 188);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(134, 32);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click_1;
            // 
            // txtWrongGuess
            // 
            txtWrongGuess.BackColor = Color.MediumSeaGreen;
            txtWrongGuess.FlatStyle = FlatStyle.Popup;
            txtWrongGuess.Font = new Font("PMingLiU-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWrongGuess.ForeColor = Color.Black;
            txtWrongGuess.Location = new Point(433, 65);
            txtWrongGuess.Name = "txtWrongGuess";
            txtWrongGuess.Size = new Size(179, 33);
            txtWrongGuess.TabIndex = 3;
            txtWrongGuess.Text = "Wrong guess";
            txtWrongGuess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbWrongGuess
            // 
            lbWrongGuess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWrongGuess.ForeColor = SystemColors.InactiveCaptionText;
            lbWrongGuess.FormattingEnabled = true;
            lbWrongGuess.ItemHeight = 15;
            lbWrongGuess.Location = new Point(433, 101);
            lbWrongGuess.Name = "lbWrongGuess";
            lbWrongGuess.Size = new Size(179, 139);
            lbWrongGuess.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumSeaGreen;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(186, 226);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 30);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(650, 244);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 43);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 308);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(lbWrongGuess);
            Controls.Add(txtWrongGuess);
            Controls.Add(btnGuess);
            Controls.Add(txtGuessWord);
            Controls.Add(tbUserInput);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form2";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guessing Game";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUserInput;
        private Label txtGuessWord;
        private Button btnGuess;
        private Label txtWrongGuess;
        private ListBox lbWrongGuess;
        private Button btnClear;
        private Button btnBack;
    }
}