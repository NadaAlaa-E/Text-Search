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
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parallelGPURadioButton = new System.Windows.Forms.RadioButton();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.numOfThreadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.completionLabel = new System.Windows.Forms.Label();
            this.n_resultsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfThreadsNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.searchQueryTextBox.Location = new System.Drawing.Point(508, 117);
            this.searchQueryTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchQueryTextBox.Multiline = true;
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(642, 271);
            this.searchQueryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label1.Location = new System.Drawing.Point(501, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Query";
            // 
            // parallelOmpRadioButton
            // 
            this.parallelOmpRadioButton.AutoSize = true;
            this.parallelOmpRadioButton.Checked = true;
            this.parallelOmpRadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.parallelOmpRadioButton.Location = new System.Drawing.Point(34, 55);
            this.parallelOmpRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.parallelOmpRadioButton.Name = "parallelOmpRadioButton";
            this.parallelOmpRadioButton.Size = new System.Drawing.Size(158, 45);
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
            this.sequentialRadioButton.Location = new System.Drawing.Point(34, 112);
            this.sequentialRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.sequentialRadioButton.Name = "sequentialRadioButton";
            this.sequentialRadioButton.Size = new System.Drawing.Size(206, 45);
            this.sequentialRadioButton.TabIndex = 4;
            this.sequentialRadioButton.Text = "Sequential";
            this.sequentialRadioButton.UseVisualStyleBackColor = true;
            this.sequentialRadioButton.CheckedChanged += new System.EventHandler(this.sequentialRadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Threads";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.searchButton.Location = new System.Drawing.Point(28, 400);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(418, 77);
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
            this.groupBox1.Location = new System.Drawing.Point(30, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(416, 271);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Mode";
            // 
            // parallelGPURadioButton
            // 
            this.parallelGPURadioButton.AutoSize = true;
            this.parallelGPURadioButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.parallelGPURadioButton.Location = new System.Drawing.Point(34, 169);
            this.parallelGPURadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.parallelGPURadioButton.Name = "parallelGPURadioButton";
            this.parallelGPURadioButton.Size = new System.Drawing.Size(233, 45);
            this.parallelGPURadioButton.TabIndex = 5;
            this.parallelGPURadioButton.Text = "Parallel GPU";
            this.parallelGPURadioButton.UseVisualStyleBackColor = true;
            this.parallelGPURadioButton.CheckedChanged += new System.EventHandler(this.parallelGPURadioButton_CheckedChanged);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 40;
            this.resultsListBox.Location = new System.Drawing.Point(836, 60);
            this.resultsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(252, 364);
            this.resultsListBox.TabIndex = 9;
            // 
            // numOfThreadsNumericUpDown
            // 
            this.numOfThreadsNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.numOfThreadsNumericUpDown.Location = new System.Drawing.Point(340, 52);
            this.numOfThreadsNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.numOfThreadsNumericUpDown.Name = "numOfThreadsNumericUpDown";
            this.numOfThreadsNumericUpDown.Size = new System.Drawing.Size(106, 48);
            this.numOfThreadsNumericUpDown.TabIndex = 10;
            this.numOfThreadsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // completionLabel
            // 
            this.completionLabel.AutoSize = true;
            this.completionLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.completionLabel.Location = new System.Drawing.Point(12, 413);
            this.completionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.completionLabel.Name = "completionLabel";
            this.completionLabel.Size = new System.Drawing.Size(302, 41);
            this.completionLabel.TabIndex = 11;
            this.completionLabel.Text = "Search Completed!";
            this.completionLabel.Visible = false;
            // 
            // n_resultsLabel
            // 
            this.n_resultsLabel.AutoSize = true;
            this.n_resultsLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.n_resultsLabel.Location = new System.Drawing.Point(12, 60);
            this.n_resultsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.n_resultsLabel.Name = "n_resultsLabel";
            this.n_resultsLabel.Size = new System.Drawing.Size(732, 41);
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
            this.groupBox2.Location = new System.Drawing.Point(31, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1122, 482);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.timeLabel.Location = new System.Drawing.Point(12, 119);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(604, 41);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Search Duration was 1.03254 seconds.";
            this.timeLabel.Visible = false;
            // 
            // loadFileButton
            // 
            this.loadFileButton.AutoSize = true;
            this.loadFileButton.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.loadFileButton.Location = new System.Drawing.Point(916, 400);
            this.loadFileButton.Margin = new System.Windows.Forms.Padding(6);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(234, 77);
            this.loadFileButton.TabIndex = 14;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1190, 1039);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numOfThreadsNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchQueryTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Text Search";
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
        private System.Windows.Forms.RadioButton parallelOmpRadioButton;
        private System.Windows.Forms.RadioButton sequentialRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.NumericUpDown numOfThreadsNumericUpDown;
        private System.Windows.Forms.Label completionLabel;
        private System.Windows.Forms.Label n_resultsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RadioButton parallelGPURadioButton;
        private System.Windows.Forms.Button loadFileButton;
    }
}

