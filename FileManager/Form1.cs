using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileDialogToolbar1_LocationChanged(object sender, EventArgs e)
        {
            //shellView1.CurrentFolder = fileDialogToolbar1.;
        }

        private int PreviousSelectedItemsCount = 0;
        private void shellView1_SelectionChanged(object sender, EventArgs e)
        {
            if (shellView1.SelectedItems.Count() == PreviousSelectedItemsCount)
                return;
            PreviousSelectedItemsCount = shellView1.SelectedItems.Count();
            long Size = 0;
            foreach (var item in shellView1.SelectedItems)
            {
                if (item.IsFileSystem)
                {
                    if (item.IsFolder)
                    {
                        System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(item.FileSystemPath);
                        Size += DirSize(d);
                    }
                    else
                    {
                        FileInfo fi = new FileInfo(item.FileSystemPath);
                        Size += fi.Length;
                    }
                }
            }
            label3.Text = ThousandDashDelimeter(Size);

        }
        private long DirSize(System.IO.DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += DirSize(di);
            }
            return (Size);
        }

        private string ThousandDashDelimeter(long x)
        {
            string res = x.ToString("0,0", System.Globalization.CultureInfo.InvariantCulture);
            res = res.Replace(',', ' ');
            return res;
        }

        private void shellView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                shellView1.NavigateBack();
        }

        private void shellView1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(shellView1.SelectedItems[0].FileSystemPath);
        }
    }
}
