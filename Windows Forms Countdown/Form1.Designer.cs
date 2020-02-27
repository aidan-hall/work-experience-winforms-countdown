namespace Windows_Forms_Countdown
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
            this.selNLargeNumbers = new System.Windows.Forms.GroupBox();
            this.rd4N = new System.Windows.Forms.RadioButton();
            this.rd3N = new System.Windows.Forms.RadioButton();
            this.rd2N = new System.Windows.Forms.RadioButton();
            this.rd1N = new System.Windows.Forms.RadioButton();
            this.rd0N = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRecords = new System.Windows.Forms.Button();
            this.selNLargeNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // selNLargeNumbers
            // 
            this.selNLargeNumbers.Controls.Add(this.rd4N);
            this.selNLargeNumbers.Controls.Add(this.rd3N);
            this.selNLargeNumbers.Controls.Add(this.rd2N);
            this.selNLargeNumbers.Controls.Add(this.rd1N);
            this.selNLargeNumbers.Controls.Add(this.rd0N);
            this.selNLargeNumbers.Location = new System.Drawing.Point(12, 38);
            this.selNLargeNumbers.Name = "selNLargeNumbers";
            this.selNLargeNumbers.Size = new System.Drawing.Size(94, 135);
            this.selNLargeNumbers.TabIndex = 6;
            this.selNLargeNumbers.TabStop = false;
            this.selNLargeNumbers.Text = "Large Numbers";
            this.selNLargeNumbers.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rd4N
            // 
            this.rd4N.AutoSize = true;
            this.rd4N.Location = new System.Drawing.Point(6, 111);
            this.rd4N.Name = "rd4N";
            this.rd4N.Size = new System.Drawing.Size(31, 17);
            this.rd4N.TabIndex = 4;
            this.rd4N.Text = "4";
            this.rd4N.UseVisualStyleBackColor = true;
            this.rd4N.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rd3N
            // 
            this.rd3N.AutoSize = true;
            this.rd3N.Location = new System.Drawing.Point(6, 88);
            this.rd3N.Name = "rd3N";
            this.rd3N.Size = new System.Drawing.Size(31, 17);
            this.rd3N.TabIndex = 3;
            this.rd3N.Text = "3";
            this.rd3N.UseVisualStyleBackColor = true;
            this.rd3N.CheckedChanged += new System.EventHandler(this.rd3N_CheckedChanged);
            // 
            // rd2N
            // 
            this.rd2N.AutoSize = true;
            this.rd2N.Location = new System.Drawing.Point(6, 65);
            this.rd2N.Name = "rd2N";
            this.rd2N.Size = new System.Drawing.Size(31, 17);
            this.rd2N.TabIndex = 2;
            this.rd2N.Text = "2";
            this.rd2N.UseVisualStyleBackColor = true;
            this.rd2N.CheckedChanged += new System.EventHandler(this.rd2N_CheckedChanged);
            // 
            // rd1N
            // 
            this.rd1N.AutoSize = true;
            this.rd1N.Location = new System.Drawing.Point(6, 42);
            this.rd1N.Name = "rd1N";
            this.rd1N.Size = new System.Drawing.Size(31, 17);
            this.rd1N.TabIndex = 1;
            this.rd1N.Text = "1";
            this.rd1N.UseVisualStyleBackColor = true;
            this.rd1N.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd0N
            // 
            this.rd0N.AutoSize = true;
            this.rd0N.Checked = true;
            this.rd0N.Location = new System.Drawing.Point(6, 19);
            this.rd0N.Name = "rd0N";
            this.rd0N.Size = new System.Drawing.Size(31, 17);
            this.rd0N.TabIndex = 0;
            this.rd0N.TabStop = true;
            this.rd0N.Text = "0";
            this.rd0N.UseVisualStyleBackColor = true;
            this.rd0N.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(134, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select the number of large numbers to use.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btRecords
            // 
            this.btRecords.Location = new System.Drawing.Point(136, 137);
            this.btRecords.Name = "btRecords";
            this.btRecords.Size = new System.Drawing.Size(75, 23);
            this.btRecords.TabIndex = 0;
            this.btRecords.Text = "Records";
            this.btRecords.UseVisualStyleBackColor = true;
            this.btRecords.Click += new System.EventHandler(this.btRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 178);
            this.Controls.Add(this.btRecords);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selNLargeNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.selNLargeNumbers.ResumeLayout(false);
            this.selNLargeNumbers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox selNLargeNumbers;
        private System.Windows.Forms.RadioButton rd0N;
        private System.Windows.Forms.RadioButton rd1N;
        private System.Windows.Forms.RadioButton rd4N;
        private System.Windows.Forms.RadioButton rd3N;
        private System.Windows.Forms.RadioButton rd2N;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRecords;
    }
}

