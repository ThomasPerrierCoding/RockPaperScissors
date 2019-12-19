namespace RockPaperScissors
{
    partial class FormRockPapeerSccissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRockPapeerSccissors));
            this.label1 = new System.Windows.Forms.Label();
            this.labelYourChoice = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.labelComputerChoice = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.txtUserWin = new System.Windows.Forms.TextBox();
            this.txtCompWin = new System.Windows.Forms.TextBox();
            this.txtTie = new System.Windows.Forms.TextBox();
            this.labelUserWins = new System.Windows.Forms.Label();
            this.labelComputerWins = new System.Windows.Forms.Label();
            this.labelTies = new System.Windows.Forms.Label();
            this.labelResetAll = new System.Windows.Forms.Label();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1181, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock/Paper/Scissors - You vs. The Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYourChoice
            // 
            this.labelYourChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelYourChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourChoice.Location = new System.Drawing.Point(191, 250);
            this.labelYourChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourChoice.Name = "labelYourChoice";
            this.labelYourChoice.Size = new System.Drawing.Size(231, 28);
            this.labelYourChoice.TabIndex = 1;
            this.labelYourChoice.Text = "Your Choice:";
            this.labelYourChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRock
            // 
            this.btnRock.Image = ((System.Drawing.Image)(resources.GetObject("btnRock.Image")));
            this.btnRock.Location = new System.Drawing.Point(429, 130);
            this.btnRock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(293, 267);
            this.btnRock.TabIndex = 2;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Image = ((System.Drawing.Image)(resources.GetObject("btnPaper.Image")));
            this.btnPaper.Location = new System.Drawing.Point(752, 134);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(293, 267);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Image = ((System.Drawing.Image)(resources.GetObject("btnScissors.Image")));
            this.btnScissors.Location = new System.Drawing.Point(1077, 134);
            this.btnScissors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(293, 267);
            this.btnScissors.TabIndex = 4;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelUserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserChoice.Location = new System.Drawing.Point(191, 422);
            this.labelUserChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(231, 42);
            this.labelUserChoice.TabIndex = 5;
            this.labelUserChoice.Text = "User Choice:";
            this.labelUserChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChoice
            // 
            this.txtChoice.Enabled = false;
            this.txtChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoice.Location = new System.Drawing.Point(449, 426);
            this.txtChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(916, 37);
            this.txtChoice.TabIndex = 6;
            this.txtChoice.TextChanged += new System.EventHandler(this.txtChoice_TextChanged);
            // 
            // txtComp
            // 
            this.txtComp.Enabled = false;
            this.txtComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp.Location = new System.Drawing.Point(445, 503);
            this.txtComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(916, 37);
            this.txtComp.TabIndex = 8;
            // 
            // labelComputerChoice
            // 
            this.labelComputerChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerChoice.Location = new System.Drawing.Point(132, 500);
            this.labelComputerChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerChoice.Name = "labelComputerChoice";
            this.labelComputerChoice.Size = new System.Drawing.Size(285, 42);
            this.labelComputerChoice.TabIndex = 7;
            this.labelComputerChoice.Text = "Computer Choice:";
            this.labelComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWin
            // 
            this.txtWin.Enabled = false;
            this.txtWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(449, 577);
            this.txtWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(916, 37);
            this.txtWin.TabIndex = 10;
            // 
            // labelWinner
            // 
            this.labelWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.Location = new System.Drawing.Point(187, 577);
            this.labelWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(231, 42);
            this.labelWinner.TabIndex = 9;
            this.labelWinner.Text = "Winner:";
            this.labelWinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(143, 751);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(173, 52);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(475, 751);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(173, 52);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(852, 751);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(173, 52);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // txtUserWin
            // 
            this.txtUserWin.BackColor = System.Drawing.Color.Yellow;
            this.txtUserWin.Enabled = false;
            this.txtUserWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserWin.Location = new System.Drawing.Point(143, 697);
            this.txtUserWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserWin.Name = "txtUserWin";
            this.txtUserWin.ReadOnly = true;
            this.txtUserWin.Size = new System.Drawing.Size(176, 37);
            this.txtUserWin.TabIndex = 14;
            // 
            // txtCompWin
            // 
            this.txtCompWin.BackColor = System.Drawing.Color.Yellow;
            this.txtCompWin.Enabled = false;
            this.txtCompWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompWin.Location = new System.Drawing.Point(471, 697);
            this.txtCompWin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompWin.Name = "txtCompWin";
            this.txtCompWin.ReadOnly = true;
            this.txtCompWin.Size = new System.Drawing.Size(176, 37);
            this.txtCompWin.TabIndex = 15;
            // 
            // txtTie
            // 
            this.txtTie.BackColor = System.Drawing.Color.Yellow;
            this.txtTie.Enabled = false;
            this.txtTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTie.Location = new System.Drawing.Point(852, 697);
            this.txtTie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTie.Name = "txtTie";
            this.txtTie.ReadOnly = true;
            this.txtTie.Size = new System.Drawing.Size(176, 37);
            this.txtTie.TabIndex = 16;
            // 
            // labelUserWins
            // 
            this.labelUserWins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelUserWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserWins.Location = new System.Drawing.Point(143, 651);
            this.labelUserWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserWins.Name = "labelUserWins";
            this.labelUserWins.Size = new System.Drawing.Size(173, 42);
            this.labelUserWins.TabIndex = 17;
            this.labelUserWins.Text = "User Wins:";
            this.labelUserWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComputerWins
            // 
            this.labelComputerWins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerWins.Location = new System.Drawing.Point(443, 651);
            this.labelComputerWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerWins.Name = "labelComputerWins";
            this.labelComputerWins.Size = new System.Drawing.Size(241, 42);
            this.labelComputerWins.TabIndex = 18;
            this.labelComputerWins.Text = "Computer WIns:";
            this.labelComputerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTies
            // 
            this.labelTies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTies.Location = new System.Drawing.Point(856, 651);
            this.labelTies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTies.Name = "labelTies";
            this.labelTies.Size = new System.Drawing.Size(173, 42);
            this.labelTies.TabIndex = 19;
            this.labelTies.Text = "Ties:";
            this.labelTies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResetAll
            // 
            this.labelResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetAll.Location = new System.Drawing.Point(1189, 651);
            this.labelResetAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResetAll.Name = "labelResetAll";
            this.labelResetAll.Size = new System.Drawing.Size(173, 42);
            this.labelResetAll.TabIndex = 22;
            this.labelResetAll.Text = "Reset All:";
            this.labelResetAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetAll.Location = new System.Drawing.Point(1185, 751);
            this.buttonResetAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(173, 52);
            this.buttonResetAll.TabIndex = 20;
            this.buttonResetAll.Text = "Reset All";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // FormRockPapeerSccissors
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(1523, 834);
            this.Controls.Add(this.labelResetAll);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.labelTies);
            this.Controls.Add(this.labelComputerWins);
            this.Controls.Add(this.labelUserWins);
            this.Controls.Add(this.txtTie);
            this.Controls.Add(this.txtCompWin);
            this.Controls.Add(this.txtUserWin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.txtWin);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.labelComputerChoice);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.labelYourChoice);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRockPapeerSccissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeff Scott - Chapter 4 Pages 182 - 183 Rock Paper Scissors Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYourChoice;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label labelComputerChoice;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox txtUserWin;
        private System.Windows.Forms.TextBox txtCompWin;
        private System.Windows.Forms.TextBox txtTie;
        private System.Windows.Forms.Label labelUserWins;
        private System.Windows.Forms.Label labelComputerWins;
        private System.Windows.Forms.Label labelTies;
        private System.Windows.Forms.Label labelResetAll;
        private System.Windows.Forms.Button buttonResetAll;
    }
}

