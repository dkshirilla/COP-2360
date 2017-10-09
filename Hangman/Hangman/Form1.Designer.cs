namespace Hangman
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.LetterEnterLabel = new System.Windows.Forms.Label();
            this.letterGuessBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prevGuessDisplay = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guessesLeftLab = new System.Windows.Forms.Label();
            this.guessNumLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(150, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(195, 43);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "HANGMAN";
            // 
            // LetterEnterLabel
            // 
            this.LetterEnterLabel.AutoSize = true;
            this.LetterEnterLabel.Location = new System.Drawing.Point(31, 105);
            this.LetterEnterLabel.Name = "LetterEnterLabel";
            this.LetterEnterLabel.Size = new System.Drawing.Size(78, 13);
            this.LetterEnterLabel.TabIndex = 1;
            this.LetterEnterLabel.Text = "Guess a letter: ";
            // 
            // letterGuessBox
            // 
            this.letterGuessBox.Location = new System.Drawing.Point(115, 102);
            this.letterGuessBox.MaxLength = 1;
            this.letterGuessBox.Name = "letterGuessBox";
            this.letterGuessBox.Size = new System.Drawing.Size(100, 20);
            this.letterGuessBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Previous guesses:";
            // 
            // prevGuessDisplay
            // 
            this.prevGuessDisplay.AutoSize = true;
            this.prevGuessDisplay.Location = new System.Drawing.Point(34, 153);
            this.prevGuessDisplay.Name = "prevGuessDisplay";
            this.prevGuessDisplay.Size = new System.Drawing.Size(0, 13);
            this.prevGuessDisplay.TabIndex = 4;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(101, 200);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 5;
            this.guessButton.Text = "GUESS!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(70, 229);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(145, 20);
            this.answerTextBox.TabIndex = 6;
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.Location = new System.Drawing.Point(269, 99);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(193, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "By: Douglas Shirilla";
            // 
            // guessesLeftLab
            // 
            this.guessesLeftLab.AutoSize = true;
            this.guessesLeftLab.Location = new System.Drawing.Point(34, 170);
            this.guessesLeftLab.Name = "guessesLeftLab";
            this.guessesLeftLab.Size = new System.Drawing.Size(72, 13);
            this.guessesLeftLab.TabIndex = 9;
            this.guessesLeftLab.Text = "Guesses Left:";
            // 
            // guessNumLab
            // 
            this.guessNumLab.AutoSize = true;
            this.guessNumLab.Location = new System.Drawing.Point(112, 170);
            this.guessNumLab.Name = "guessNumLab";
            this.guessNumLab.Size = new System.Drawing.Size(0, 13);
            this.guessNumLab.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 315);
            this.Controls.Add(this.guessNumLab);
            this.Controls.Add(this.guessesLeftLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.prevGuessDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterGuessBox);
            this.Controls.Add(this.LetterEnterLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label LetterEnterLabel;
        private System.Windows.Forms.TextBox letterGuessBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prevGuessDisplay;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guessesLeftLab;
        private System.Windows.Forms.Label guessNumLab;
    }
}

