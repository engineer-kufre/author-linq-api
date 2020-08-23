namespace author_linq_api_UI
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
            this.getUsernamesByCountListBox = new System.Windows.Forms.ListBox();
            this.getUsernameByCountListBoxButton = new System.Windows.Forms.Button();
            this.getUsernameListBoxThresholdLabel = new System.Windows.Forms.Label();
            this.getUsernameByCountListBoxThreshold = new System.Windows.Forms.TextBox();
            this.getUsernameByDateListBoxThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getUsernameByDateListBoxButton = new System.Windows.Forms.Button();
            this.getUsernamesByDateListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.highestCommentCountTextBox = new System.Windows.Forms.TextBox();
            this.getUsernameByCommentCountButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getUsernamesByCountListBox
            // 
            this.getUsernamesByCountListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getUsernamesByCountListBox.FormattingEnabled = true;
            this.getUsernamesByCountListBox.ItemHeight = 20;
            this.getUsernamesByCountListBox.Location = new System.Drawing.Point(57, 113);
            this.getUsernamesByCountListBox.Name = "getUsernamesByCountListBox";
            this.getUsernamesByCountListBox.Size = new System.Drawing.Size(322, 302);
            this.getUsernamesByCountListBox.TabIndex = 0;
            // 
            // getUsernameByCountListBoxButton
            // 
            this.getUsernameByCountListBoxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(137)))), ((int)(((byte)(186)))));
            this.getUsernameByCountListBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getUsernameByCountListBoxButton.Location = new System.Drawing.Point(237, 447);
            this.getUsernameByCountListBoxButton.Name = "getUsernameByCountListBoxButton";
            this.getUsernameByCountListBoxButton.Size = new System.Drawing.Size(142, 60);
            this.getUsernameByCountListBoxButton.TabIndex = 1;
            this.getUsernameByCountListBoxButton.Text = "Get Usernames";
            this.getUsernameByCountListBoxButton.UseVisualStyleBackColor = false;
            this.getUsernameByCountListBoxButton.Click += new System.EventHandler(this.getUsernameByCountListBoxButton_Click);
            // 
            // getUsernameListBoxThresholdLabel
            // 
            this.getUsernameListBoxThresholdLabel.AutoSize = true;
            this.getUsernameListBoxThresholdLabel.Location = new System.Drawing.Point(105, 487);
            this.getUsernameListBoxThresholdLabel.Name = "getUsernameListBoxThresholdLabel";
            this.getUsernameListBoxThresholdLabel.Size = new System.Drawing.Size(74, 20);
            this.getUsernameListBoxThresholdLabel.TabIndex = 2;
            this.getUsernameListBoxThresholdLabel.Text = "Threshold";
            // 
            // getUsernameByCountListBoxThreshold
            // 
            this.getUsernameByCountListBoxThreshold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getUsernameByCountListBoxThreshold.Location = new System.Drawing.Point(57, 450);
            this.getUsernameByCountListBoxThreshold.Name = "getUsernameByCountListBoxThreshold";
            this.getUsernameByCountListBoxThreshold.Size = new System.Drawing.Size(174, 34);
            this.getUsernameByCountListBoxThreshold.TabIndex = 3;
            // 
            // getUsernameByDateListBoxThreshold
            // 
            this.getUsernameByDateListBoxThreshold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getUsernameByDateListBoxThreshold.Location = new System.Drawing.Point(511, 450);
            this.getUsernameByDateListBoxThreshold.Name = "getUsernameByDateListBoxThreshold";
            this.getUsernameByDateListBoxThreshold.Size = new System.Drawing.Size(174, 34);
            this.getUsernameByDateListBoxThreshold.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threshold";
            // 
            // getUsernameByDateListBoxButton
            // 
            this.getUsernameByDateListBoxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(137)))), ((int)(((byte)(186)))));
            this.getUsernameByDateListBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getUsernameByDateListBoxButton.Location = new System.Drawing.Point(691, 447);
            this.getUsernameByDateListBoxButton.Name = "getUsernameByDateListBoxButton";
            this.getUsernameByDateListBoxButton.Size = new System.Drawing.Size(142, 60);
            this.getUsernameByDateListBoxButton.TabIndex = 1;
            this.getUsernameByDateListBoxButton.Text = "Get Usernames";
            this.getUsernameByDateListBoxButton.UseVisualStyleBackColor = false;
            this.getUsernameByDateListBoxButton.Click += new System.EventHandler(this.getUsernameByDateListBoxButton_Click);
            // 
            // getUsernamesByDateListBox
            // 
            this.getUsernamesByDateListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getUsernamesByDateListBox.FormattingEnabled = true;
            this.getUsernamesByDateListBox.ItemHeight = 20;
            this.getUsernamesByDateListBox.Location = new System.Drawing.Point(511, 113);
            this.getUsernamesByDateListBox.Name = "getUsernamesByDateListBox";
            this.getUsernamesByDateListBox.Size = new System.Drawing.Size(322, 302);
            this.getUsernamesByDateListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retrieves the names of the most active authors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "(using submission count as the criteria)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "according to a set threshold.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Retrieve the names of authors (sorted by when";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "their record was created) according to a set";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "threshold.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Retrieves the name of the author with the highest comment count. ";
            // 
            // highestCommentCountTextBox
            // 
            this.highestCommentCountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highestCommentCountTextBox.Location = new System.Drawing.Point(358, 579);
            this.highestCommentCountTextBox.Name = "highestCommentCountTextBox";
            this.highestCommentCountTextBox.Size = new System.Drawing.Size(174, 34);
            this.highestCommentCountTextBox.TabIndex = 3;
            this.highestCommentCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getUsernameByCommentCountButton
            // 
            this.getUsernameByCommentCountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(137)))), ((int)(((byte)(186)))));
            this.getUsernameByCommentCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getUsernameByCommentCountButton.Location = new System.Drawing.Point(297, 619);
            this.getUsernameByCommentCountButton.Name = "getUsernameByCommentCountButton";
            this.getUsernameByCommentCountButton.Size = new System.Drawing.Size(142, 60);
            this.getUsernameByCommentCountButton.TabIndex = 1;
            this.getUsernameByCommentCountButton.Text = "Get Username";
            this.getUsernameByCommentCountButton.UseVisualStyleBackColor = false;
            this.getUsernameByCommentCountButton.Click += new System.EventHandler(this.getUsernameByCommentCountButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(137)))), ((int)(((byte)(186)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Location = new System.Drawing.Point(445, 619);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(142, 60);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "FORM RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(892, 726);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.getUsernameByCommentCountButton);
            this.Controls.Add(this.highestCommentCountTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getUsernamesByDateListBox);
            this.Controls.Add(this.getUsernameByDateListBoxButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getUsernameByDateListBoxThreshold);
            this.Controls.Add(this.getUsernameByCountListBoxThreshold);
            this.Controls.Add(this.getUsernameListBoxThresholdLabel);
            this.Controls.Add(this.getUsernameByCountListBoxButton);
            this.Controls.Add(this.getUsernamesByCountListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox getUsernamesByCountListBox;
        private System.Windows.Forms.Button getUsernameByCountListBoxButton;
        private System.Windows.Forms.Label getUsernameListBoxThresholdLabel;
        private System.Windows.Forms.TextBox getUsernameByCountListBoxThreshold;
        private System.Windows.Forms.TextBox getUsernameByDateListBoxThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getUsernameByDateListBoxButton;
        private System.Windows.Forms.ListBox getUsernamesByDateListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox highestCommentCountTextBox;
        private System.Windows.Forms.Button getUsernameByCommentCountButton;
        private System.Windows.Forms.Button resetButton;
    }
}

