using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace HPCProject
{

    public partial class Form1 : Form
    {
        public string paragraph;
        public mode searchMode;
        public int n_threads;
        int length;
        int[] positions;
        double executionTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            n_resultsLabel.Visible = timeLabel.Visible = completionLabel.Visible = false;
            groupBox2.Update();

            if (!IsDataComplete())
            {
                return;
            }
            
            string searchQuery = this.searchQueryTextBox.Text;
            n_threads = Convert.ToInt32(this.numOfThreadsNumericUpDown.Value);

            IntPtr textsearch = Wrap.Create_TextSearch_Obj(paragraph, n_threads);
            Wrap.Execute_SearchforWord(textsearch, searchQuery, searchMode, out positions, out length);
            executionTime = Wrap.Execute_GetElapsedTime(textsearch);
            Wrap.Delete_TextSearch_Obj(textsearch);

            DisplayResults();
        }

        private void DisplayResults()
        {
            resultsListBox.Items.Clear();

            if (length == 0) n_resultsLabel.Text = "Query not found.";
            else n_resultsLabel.Text = length + " results found at the following locations: ";
            timeLabel.Text = "Execution time was " + executionTime + " seconds.";
            n_resultsLabel.Visible = timeLabel.Visible = completionLabel.Visible = true;

            for (int i = 0; i < length; i++)
            {
                resultsListBox.Items.Add(positions[i]);
            }
        }

        private bool IsDataComplete()
        {
            if (searchQueryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Search Query.");
                return false;
            }
            else if (paragraph == null)
            {
                MessageBox.Show("Please Load File.");
                return false;
            }
            return true;
        }

        private void parallelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = mode.ParallelCPU;
        }

        private void sequentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = mode.Serial;
        }

        private void parallelGPURadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = mode.ParallelGPU;
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(fileName);
                paragraph = sr.ReadToEnd();

                sr.Dispose();
            }
        }
    }
    public enum mode { ParallelCPU, Serial, ParallelGPU };
    public class Wrap
    {
        [DllImport(@"E:\Work\4th Year - 1st Semestre\High Performance Computing\Project\Text-Search\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Create_TextSearch_Obj(string keyword, int n_threads);
        [DllImport(@"E:\Work\4th Year - 1st Semestre\High Performance Computing\Project\Text-Search\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Delete_TextSearch_Obj(IntPtr Obj);
        [DllImport(@"E:\Work\4th Year - 1st Semestre\High Performance Computing\Project\Text-Search\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Execute_GetElapsedTime(IntPtr Obj);
        [DllImport(@"E:\Work\4th Year - 1st Semestre\High Performance Computing\Project\Text-Search\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Execute_SearchforWord(IntPtr Obj, string keyword, mode searchMode, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out int[] data, out int count);
    }
}
