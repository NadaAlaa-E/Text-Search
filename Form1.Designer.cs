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
            this.parallelOmpRadioButton = new System.Windows.Forms.RadioButton();
            this.sequentialRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parallelGPURadioButton = new System.Windows.Forms.RadioButton();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.completionLabel = new System.Windows.Forms.Label();
            this.n_resultsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.numOfThreadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfThreadsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.searchQueryTextBox.Location = new System.Drawing.Point(254, 61);
            this.searchQueryTextBox.Multiline = true;
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(323, 143);
            this.searchQueryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label1.Location = new System.Drawing.Point(250, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Query";
            // 
            // parallelOmpRadioButton
            // 
            this.parallelOmpRadioButton.AutoSize = true;
            this.parallelOmpRadioButton.Checked = true;
            this.parallelOmpRadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.parallelOmpRadioButton.Location = new System.Drawing.Point(17, 29);
            this.parallelOmpRadioButton.Name = "parallelOmpRadioButton";
            this.parallelOmpRadioButton.Size = new System.Drawing.Size(82, 25);
            this.parallelOmpRadioButton.TabIndex = 3;
            this.parallelOmpRadioButton.TabStop = true;
            this.parallelOmpRadioButton.Text = "Parallel";
            this.parallelOmpRadioButton.UseVisualStyleBackColor = true;
            this.parallelOmpRadioButton.CheckedChanged += new System.EventHandler(this.parallelRadioButton_CheckedChanged);
            // 
            // sequentialRadioButton
            // 
            this.sequentialRadioButton.AutoSize = true;
            this.sequentialRadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.sequentialRadioButton.Location = new System.Drawing.Point(17, 58);
            this.sequentialRadioButton.Name = "sequentialRadioButton";
            this.sequentialRadioButton.Size = new System.Drawing.Size(105, 25);
            this.sequentialRadioButton.TabIndex = 4;
            this.sequentialRadioButton.Text = "Sequential";
            this.sequentialRadioButton.UseVisualStyleBackColor = true;
            this.sequentialRadioButton.CheckedChanged += new System.EventHandler(this.sequentialRadioButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.searchButton.Location = new System.Drawing.Point(25, 208);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(209, 40);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parallelGPURadioButton);
            this.groupBox1.Controls.Add(this.parallelOmpRadioButton);
            this.groupBox1.Controls.Add(this.sequentialRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.groupBox1.Location = new System.Drawing.Point(26, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Mode";
            // 
            // parallelGPURadioButton
            // 
            this.parallelGPURadioButton.AutoSize = true;
            this.parallelGPURadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.parallelGPURadioButton.Location = new System.Drawing.Point(17, 88);
            this.parallelGPURadioButton.Name = "parallelGPURadioButton";
            this.parallelGPURadioButton.Size = new System.Drawing.Size(118, 25);
            this.parallelGPURadioButton.TabIndex = 5;
            this.parallelGPURadioButton.Text = "Parallel GPU";
            this.parallelGPURadioButton.UseVisualStyleBackColor = true;
            this.parallelGPURadioButton.CheckedChanged += new System.EventHandler(this.parallelGPURadioButton_CheckedChanged);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 21;
            this.resultsListBox.Location = new System.Drawing.Point(418, 31);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(128, 172);
            this.resultsListBox.TabIndex = 9;
            // 
            // completionLabel
            // 
            this.completionLabel.AutoSize = true;
            this.completionLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.completionLabel.Location = new System.Drawing.Point(6, 215);
            this.completionLabel.Name = "completionLabel";
            this.completionLabel.Size = new System.Drawing.Size(150, 21);
            this.completionLabel.TabIndex = 11;
            this.completionLabel.Text = "Search Completed!";
            this.completionLabel.Visible = false;
            // 
            // n_resultsLabel
            // 
            this.n_resultsLabel.AutoSize = true;
            this.n_resultsLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.n_resultsLabel.Location = new System.Drawing.Point(6, 31);
            this.n_resultsLabel.Name = "n_resultsLabel";
            this.n_resultsLabel.Size = new System.Drawing.Size(362, 21);
            this.n_resultsLabel.TabIndex = 12;
            this.n_resultsLabel.Text = "14 results were found at the following locations";
            this.n_resultsLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Controls.Add(this.resultsListBox);
            this.groupBox2.Controls.Add(this.n_resultsLabel);
            this.groupBox2.Controls.Add(this.completionLabel);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.groupBox2.Location = new System.Drawing.Point(16, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 251);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.timeLabel.Location = new System.Drawing.Point(6, 62);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(298, 21);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Search Duration was 1.03254 seconds.";
            this.timeLabel.Visible = false;
            // 
            // loadFileButton
            // 
            this.loadFileButton.AutoSize = true;
            this.loadFileButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.loadFileButton.Location = new System.Drawing.Point(458, 208);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(117, 40);
            this.loadFileButton.TabIndex = 14;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // numOfThreadsNumericUpDown
            // 
            this.numOfThreadsNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.numOfThreadsNumericUpDown.Location = new System.Drawing.Point(180, 27);
            this.numOfThreadsNumericUpDown.Name = "numOfThreadsNumericUpDown";
            this.numOfThreadsNumericUpDown.Size = new System.Drawing.Size(53, 28);
            this.numOfThreadsNumericUpDown.TabIndex = 12;
            this.numOfThreadsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Threads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(595, 515);
            this.Controls.Add(this.numOfThreadsNumericUpDown);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchQueryTextBox);
            this.Name = "Form1";
            this.Text = "Text Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfThreadsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchQueryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton parallelOmpRadioButton;
        private System.Windows.Forms.RadioButton sequentialRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Label completionLabel;
        private System.Windows.Forms.Label n_resultsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RadioButton parallelGPURadioButton;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.NumericUpDown numOfThreadsNumericUpDown;
        private System.Windows.Forms.Label label3;
    }
}

