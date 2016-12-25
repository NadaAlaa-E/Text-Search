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
        public int searchMode;
        public int threadsNumber;
        public List<int> results = new List<int>();
        public Form1()
        {
            InitializeComponent();
            //////////////testing 
            int x = Wrap.subtract(10, 5);
            string tmp = "islam omar islam islam";
            IntPtr textsearch = Wrap.Create_TextSearch_Obj(tmp); // 
            int length;
            int[] positions;
            Wrap.Execute_SearchforWord(textsearch, "islam", mode.Serial, out positions, out length);
            double time = Wrap.Execute_GetElapsedTime(textsearch);
            Wrap.Delete_TextSearch_Obj(textsearch); //don't forget
            int vx = 0;
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
    public enum mode { Parallel, Serial };
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
