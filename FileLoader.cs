using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HPCProject
{
    class FileLoader
    {
        public void LoadFiles()
        {
            string sourceString = Environment.CurrentDirectory;
            
            string fileName = "TextSearchCpluse.dll";
            string sourcePath = sourceString;
            string targetPath = @"D:\HPCFiles";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);

        }
    }
}
