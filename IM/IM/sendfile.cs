using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IM
{
    public partial class sendfile : Form
    {
        public sendfile()
        {
            InitializeComponent();
        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "所有文件(*.*)|*.*";
            openfile.InitialDirectory = "C:\\";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                waterTextBox1.Text = openfile.FileName;
                FileInfo fileif = new FileInfo(openfile.FileName);
                long filelen = fileif.Length;
                if (filelen < 1024)
                    skinLabel5.Text = filelen.ToString() + "字节";
                else
                {
                    if (filelen >= 1024 && filelen < (1024*1024))
                    {
                        filelen = filelen / 1024;
                        skinLabel5.Text = filelen.ToString() + "KB";
                    }
                    else
                    {
                        filelen = filelen / (1024*1024);
                        skinLabel5.Text = filelen.ToString() + "MB";
                    }
                }
            }
            
        }
    }
}
