namespace RandomNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.birthYearLabel = new System.Windows.Forms.Label();
            this.birthMonthLabel = new System.Windows.Forms.Label();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.favoriteColorLabel = new System.Windows.Forms.Label();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.birthMonthTextBox = new System.Windows.Forms.TextBox();
            this.birthDayTextBox = new System.Windows.Forms.TextBox();
            this.favoriteColorTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your lucky number?";
            // 
            // birthYearLabel
            // 
            this.birthYearLabel.AutoSize = true;
            this.birthYearLabel.Location = new System.Drawing.Point(92, 75);
            this.birthYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthYearLabel.Name = "birthYearLabel";
            this.birthYearLabel.Size = new System.Drawing.Size(128, 16);
            this.birthYearLabel.TabIndex = 1;
            this.birthYearLabel.Text = "Enter your birth year:";
            // 
            // birthMonthLabel
            // 
            this.birthMonthLabel.AutoSize = true;
            this.birthMonthLabel.Location = new System.Drawing.Point(80, 106);
            this.birthMonthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthMonthLabel.Name = "birthMonthLabel";
            this.birthMonthLabel.Size = new System.Drawing.Size(137, 16);
            this.birthMonthLabel.TabIndex = 2;
            this.birthMonthLabel.Text = "Enter your birth month:";
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Location = new System.Drawing.Point(96, 137);
            this.birthDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(124, 16);
            this.birthDayLabel.TabIndex = 3;
            this.birthDayLabel.Text = "Enter your birth day:";
            // 
            // favoriteColorLabel
            // 
            this.favoriteColorLabel.AutoSize = true;
            this.favoriteColorLabel.Location = new System.Drawing.Point(65, 167);
            this.favoriteColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.favoriteColorLabel.Name = "favoriteColorLabel";
            this.favoriteColorLabel.Size = new System.Drawing.Size(150, 16);
            this.favoriteColorLabel.TabIndex = 4;
            this.favoriteColorLabel.Text = "Enter your favorite color:";
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(239, 70);
            this.birthYearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(132, 22);
            this.birthYearTextBox.TabIndex = 5;
            // 
            // birthMonthTextBox
            // 
            this.birthMonthTextBox.Location = new System.Drawing.Point(239, 101);
            this.birthMonthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthMonthTextBox.Name = "birthMonthTextBox";
            this.birthMonthTextBox.Size = new System.Drawing.Size(132, 22);
            this.birthMonthTextBox.TabIndex = 6;
            // 
            // birthDayTextBox
            // 
            this.birthDayTextBox.Location = new System.Drawing.Point(239, 132);
            this.birthDayTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthDayTextBox.Name = "birthDayTextBox";
            this.birthDayTextBox.Size = new System.Drawing.Size(132, 22);
            this.birthDayTextBox.TabIndex = 7;
            // 
            // favoriteColorTextBox
            // 
            this.favoriteColorTextBox.Location = new System.Drawing.Point(239, 162);
            this.favoriteColorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.favoriteColorTextBox.Name = "favoriteColorTextBox";
            this.favoriteColorTextBox.Size = new System.Drawing.Size(132, 22);
            this.favoriteColorTextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calculateButton.Location = new System.Drawing.Point(72, 207);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(300, 47);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Get Your Lucky Number";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(439, 270);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.favoriteColorTextBox);
            this.Controls.Add(this.birthDayTextBox);
            this.Controls.Add(this.birthMonthTextBox);
            this.Controls.Add(this.birthYearTextBox);
            this.Controls.Add(this.favoriteColorLabel);
            this.Controls.Add(this.birthDayLabel);
            this.Controls.Add(this.birthMonthLabel);
            this.Controls.Add(this.birthYearLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthYearLabel;
        private System.Windows.Forms.Label birthMonthLabel;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Label favoriteColorLabel;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.TextBox birthMonthTextBox;
        private System.Windows.Forms.TextBox birthDayTextBox;
        private System.Windows.Forms.TextBox favoriteColorTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

