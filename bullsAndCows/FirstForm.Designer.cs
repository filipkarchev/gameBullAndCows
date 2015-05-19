namespace bullsAndCows
{
    partial class FirstForm
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
            this.txtFirstPlayer = new System.Windows.Forms.TextBox();
            this.txtSecondPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbLength = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbLength.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstPlayer
            // 
            this.txtFirstPlayer.Location = new System.Drawing.Point(146, 38);
            this.txtFirstPlayer.Name = "txtFirstPlayer";
            this.txtFirstPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtFirstPlayer.TabIndex = 0;
            // 
            // txtSecondPlayer
            // 
            this.txtSecondPlayer.Location = new System.Drawing.Point(146, 70);
            this.txtSecondPlayer.Name = "txtSecondPlayer";
            this.txtSecondPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtSecondPlayer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добре дошли в играта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Име на първия играч";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Име на втория играч";
            // 
            // gbLength
            // 
            this.gbLength.Controls.Add(this.rb6);
            this.gbLength.Controls.Add(this.rb5);
            this.gbLength.Controls.Add(this.rb4);
            this.gbLength.Controls.Add(this.rb3);
            this.gbLength.Location = new System.Drawing.Point(12, 109);
            this.gbLength.Name = "gbLength";
            this.gbLength.Size = new System.Drawing.Size(166, 130);
            this.gbLength.TabIndex = 5;
            this.gbLength.TabStop = false;
            this.gbLength.Text = "Дължина на числото";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(7, 20);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(78, 17);
            this.rb3.TabIndex = 0;
            this.rb3.Text = "3-цифрено";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Checked = true;
            this.rb4.Location = new System.Drawing.Point(7, 44);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(78, 17);
            this.rb4.TabIndex = 1;
            this.rb4.TabStop = true;
            this.rb4.Text = "4-цифрено";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(7, 68);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(78, 17);
            this.rb5.TabIndex = 2;
            this.rb5.Text = "5-цифрено";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(7, 92);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(78, 17);
            this.rb6.TabIndex = 3;
            this.rb6.Text = "6-цифрено";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(184, 171);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Играйте";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gbLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecondPlayer);
            this.Controls.Add(this.txtFirstPlayer);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.gbLength.ResumeLayout(false);
            this.gbLength.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstPlayer;
        private System.Windows.Forms.TextBox txtSecondPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbLength;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btnPlay;
    }
}