namespace Windows_Forms_Countdown
{
    partial class Form3
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.nameConfirmationButton = new System.Windows.Forms.Button();
            this.pointsDisplay = new System.Windows.Forms.Label();
            this.differenceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(210, 39);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(87, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter your name.";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(210, 55);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.playerNameTextBox.TabIndex = 1;
            this.playerNameTextBox.TextChanged += new System.EventHandler(this.playerNameTextBox_TextChanged);
            // 
            // nameConfirmationButton
            // 
            this.nameConfirmationButton.Location = new System.Drawing.Point(210, 81);
            this.nameConfirmationButton.Name = "nameConfirmationButton";
            this.nameConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.nameConfirmationButton.TabIndex = 2;
            this.nameConfirmationButton.Text = "Confirm";
            this.nameConfirmationButton.UseVisualStyleBackColor = true;
            this.nameConfirmationButton.Click += new System.EventHandler(this.nameConfirmationButton_Click);
            // 
            // pointsDisplay
            // 
            this.pointsDisplay.AutoSize = true;
            this.pointsDisplay.Location = new System.Drawing.Point(6, 39);
            this.pointsDisplay.Name = "pointsDisplay";
            this.pointsDisplay.Size = new System.Drawing.Size(114, 13);
            this.pointsDisplay.TabIndex = 3;
            this.pointsDisplay.Text = "NUMBER OF POINTS";
            // 
            // differenceLabel
            // 
            this.differenceLabel.AutoSize = true;
            this.differenceLabel.Location = new System.Drawing.Point(6, 16);
            this.differenceLabel.Name = "differenceLabel";
            this.differenceLabel.Size = new System.Drawing.Size(153, 13);
            this.differenceLabel.TabIndex = 4;
            this.differenceLabel.Text = "DIFFERENCE WITH TARGET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Game Over! Here are your results:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your results will be saved.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.differenceLabel);
            this.groupBox1.Controls.Add(this.pointsDisplay);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 119);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameConfirmationButton);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button nameConfirmationButton;
        private System.Windows.Forms.Label pointsDisplay;
        private System.Windows.Forms.Label differenceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}