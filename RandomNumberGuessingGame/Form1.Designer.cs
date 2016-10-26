namespace WindowsFormsApplication6
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterGuess = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.txtAttemptNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(12, 209);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 134);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(260, 59);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Guess";
            // 
            // txtEnterGuess
            // 
            this.txtEnterGuess.Location = new System.Drawing.Point(12, 93);
            this.txtEnterGuess.Name = "txtEnterGuess";
            this.txtEnterGuess.Size = new System.Drawing.Size(65, 20);
            this.txtEnterGuess.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(197, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.Location = new System.Drawing.Point(107, 209);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(75, 23);
            this.btnStartOver.TabIndex = 5;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // txtAttemptNumber
            // 
            this.txtAttemptNumber.Location = new System.Drawing.Point(121, 93);
            this.txtAttemptNumber.Name = "txtAttemptNumber";
            this.txtAttemptNumber.ReadOnly = true;
            this.txtAttemptNumber.Size = new System.Drawing.Size(35, 20);
            this.txtAttemptNumber.TabIndex = 6;
            this.txtAttemptNumber.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attempt Number";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAttemptNumber);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEnterGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnGuess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterGuess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.TextBox txtAttemptNumber;
        private System.Windows.Forms.Label label3;
    }
}

