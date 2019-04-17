namespace TicTacToeAI
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
            this.components = new System.ComponentModel.Container();
            this.PlayerWins1 = new System.Windows.Forms.Label();
            this.Computerwins1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.startover1 = new System.Windows.Forms.Button();
            this.Computermoves = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlayerWins1
            // 
            this.PlayerWins1.AutoSize = true;
            this.PlayerWins1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWins1.Location = new System.Drawing.Point(12, 9);
            this.PlayerWins1.Name = "PlayerWins1";
            this.PlayerWins1.Size = new System.Drawing.Size(122, 20);
            this.PlayerWins1.TabIndex = 0;
            this.PlayerWins1.Text = "Player Wins: 0";
            // 
            // Computerwins1
            // 
            this.Computerwins1.AutoSize = true;
            this.Computerwins1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computerwins1.Location = new System.Drawing.Point(508, 9);
            this.Computerwins1.Name = "Computerwins1";
            this.Computerwins1.Size = new System.Drawing.Size(151, 20);
            this.Computerwins1.TabIndex = 0;
            this.Computerwins1.Text = "Computer Wins: 0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(69, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 160);
            this.button1.TabIndex = 1;
            this.button1.Tag = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(252, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 160);
            this.button2.TabIndex = 1;
            this.button2.Tag = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(435, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 160);
            this.button3.TabIndex = 1;
            this.button3.Tag = "Play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(69, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 160);
            this.button4.TabIndex = 1;
            this.button4.Tag = "Play";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(435, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 160);
            this.button6.TabIndex = 1;
            this.button6.Tag = "Play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(252, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 160);
            this.button5.TabIndex = 1;
            this.button5.Tag = "Play";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(252, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 160);
            this.button8.TabIndex = 1;
            this.button8.Tag = "Play";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(69, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 160);
            this.button7.TabIndex = 1;
            this.button7.Tag = "Play";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(435, 395);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(177, 160);
            this.button9.TabIndex = 1;
            this.button9.Tag = "Play";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // startover1
            // 
            this.startover1.Location = new System.Drawing.Point(292, 578);
            this.startover1.Name = "startover1";
            this.startover1.Size = new System.Drawing.Size(97, 27);
            this.startover1.TabIndex = 2;
            this.startover1.Text = "Start Over";
            this.startover1.UseVisualStyleBackColor = true;
            this.startover1.Click += new System.EventHandler(this.restartGame);
            // 
            // Computermoves
            // 
            this.Computermoves.Interval = 1000;
            this.Computermoves.Tick += new System.EventHandler(this.Computermove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 680);
            this.Controls.Add(this.startover1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Computerwins1);
            this.Controls.Add(this.PlayerWins1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerWins1;
        private System.Windows.Forms.Label Computerwins1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button startover1;
        private System.Windows.Forms.Timer Computermoves;
    }
}

