using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPCProject
{
    public partial class Form1 : Form
    {
        public string searchQuery;
        public int searchMode;
        public int threadsNumber;
        public List<int> results = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchQuery = this.searchQueryTextBox.Text;
            threadsNumber = Convert.ToInt32(this.numOfThreadsNumericUpDown.Value);
            if(this.parallelRadioButton.Checked==true)
            {
                this.searchMode = 0;
            }
            else
            {
                this.searchMode = 1;
            }
        }
    }
}
