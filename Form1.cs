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
namespace HPCProject
{

    public partial class Form1 : Form
    {
        public string searchQuery;
        public mode searchMode;
        public int num_threads;
        int length;
        int[] positions;

        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!IsDataComplete())
            {
                MessageBox.Show("Please Enter Search Query.");
                return;
            }


            searchQuery = this.searchQueryTextBox.Text;
            num_threads = Convert.ToInt32(this.numOfThreadsNumericUpDown.Value);
            
            IntPtr textsearch = Wrap.Create_TextSearch_Obj(searchQuery);
            Wrap.Execute_SearchforWord(textsearch, searchQuery, searchMode, out positions, out length);
            double time = Wrap.Execute_GetElapsedTime(textsearch);
            Wrap.Delete_TextSearch_Obj(textsearch); //don't forget
        }

        private void DisplayResults()
        {
            resultsListBox.Items.Add(positions);
        }

        private bool IsDataComplete()
        {
            return searchQueryTextBox.Text.Length != 0;
        }

        private void parallelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = mode.Parallel;
        }

        private void sequentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = mode.Serial;
        }

        private void parallelGPURadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = mode.ParallelGPU;
        }
    }
    public enum mode { Parallel, Serial, ParallelGPU };
    public class Wrap
    {
        [DllImport(@"D:\Text-Search-master\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int subtract(int N, int M);
        [DllImport(@"D:\Text-Search-master\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Create_TextSearch_Obj(string keyword);
        [DllImport(@"D:\Text-Search-master\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Delete_TextSearch_Obj(IntPtr Obj);
        [DllImport(@"D:\Text-Search-master\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Execute_GetElapsedTime(IntPtr Obj);
        [DllImport(@"D:\Text-Search-master\Release\TextSearchCpluse.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Execute_SearchforWord(IntPtr Obj, string keyword, mode searchMode, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out int[] data, out int count);
    }
}
