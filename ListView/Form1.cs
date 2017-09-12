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

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Public\Pictures");
            int indexImagem = 1;
            foreach (System.IO.FileSystemInfo file in dir.GetFileSystemInfos())
            {
                if (file.Attributes == FileAttributes.Directory)
                    indexImagem = 0;
                listView1.Items.Add(file.Name, indexImagem);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void iconesGrandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void iconesPequenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
