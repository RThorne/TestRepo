namespace WindowsFormsApplication10
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
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pcguess = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            this.highscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 13);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcguess
            // 
            this.pcguess.AutoSize = true;
            this.pcguess.Location = new System.Drawing.Point(13, 70);
            this.pcguess.Name = "pcguess";
            this.pcguess.Size = new System.Drawing.Size(61, 13);
            this.pcguess.TabIndex = 2;
            this.pcguess.Text = "Kompiuteris";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(120, 13);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 3;
            this.score.Text = "label2";
            // 
            // level
            // 
            this.level.FormattingEnabled = true;
            this.level.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.level.Location = new System.Drawing.Point(94, 40);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(121, 21);
            this.level.TabIndex = 4;
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Location = new System.Drawing.Point(91, 70);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(35, 13);
            this.highscore.TabIndex = 5;
            this.highscore.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 106);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.level);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pcguess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pcguess;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.Label highscore;
    }
}

