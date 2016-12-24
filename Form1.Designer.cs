namespace HPCProject
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
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parallelRadioButton = new System.Windows.Forms.RadioButton();
            this.sequentialRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.numOfThreadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfThreadsNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.searchQueryTextBox.Location = new System.Drawing.Point(263, 51);
            this.searchQueryTextBox.Multiline = true;
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(368, 143);
            this.searchQueryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label1.Location = new System.Drawing.Point(259, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Query";
            // 
            // parallelRadioButton
            // 
            this.parallelRadioButton.AutoSize = true;
            this.parallelRadioButton.Checked = true;
            this.parallelRadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.parallelRadioButton.Location = new System.Drawing.Point(17, 27);
            this.parallelRadioButton.Name = "parallelRadioButton";
            this.parallelRadioButton.Size = new System.Drawing.Size(137, 25);
            this.parallelRadioButton.TabIndex = 3;
            this.parallelRadioButton.TabStop = true;
            this.parallelRadioButton.Text = "Parallel Search";
            this.parallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // sequentialRadioButton
            // 
            this.sequentialRadioButton.AutoSize = true;
            this.sequentialRadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.sequentialRadioButton.Location = new System.Drawing.Point(17, 58);
            this.sequentialRadioButton.Name = "sequentialRadioButton";
            this.sequentialRadioButton.Size = new System.Drawing.Size(160, 25);
            this.sequentialRadioButton.TabIndex = 4;
            this.sequentialRadioButton.Text = "Sequential Search";
            this.sequentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Threads";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.button1.Location = new System.Drawing.Point(16, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parallelRadioButton);
            this.groupBox1.Controls.Add(this.sequentialRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Mode";
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 21;
            this.resultsListBox.Items.AddRange(new object[] {
            "215",
            "3435",
            "4598",
            "18422",
            "36501",
            "46548",
            "656878",
            "487855",
            "495352",
            "1577884",
            "45664879",
            "87987879",
            "4545620022"});
            this.resultsListBox.Location = new System.Drawing.Point(20, 69);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(128, 193);
            this.resultsListBox.TabIndex = 9;
            // 
            // numOfThreadsNumericUpDown
            // 
            this.numOfThreadsNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.numOfThreadsNumericUpDown.Location = new System.Drawing.Point(170, 27);
            this.numOfThreadsNumericUpDown.Name = "numOfThreadsNumericUpDown";
            this.numOfThreadsNumericUpDown.Size = new System.Drawing.Size(63, 28);
            this.numOfThreadsNumericUpDown.TabIndex = 10;
            this.numOfThreadsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Completed!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "14 results were found at the following locations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.resultsListBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.groupBox2.Location = new System.Drawing.Point(16, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 283);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label5.Location = new System.Drawing.Point(168, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Duration was 1.03254 seconds.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numOfThreadsNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchQueryTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfThreadsNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchQueryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton parallelRadioButton;
        private System.Windows.Forms.RadioButton sequentialRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.NumericUpDown numOfThreadsNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}

