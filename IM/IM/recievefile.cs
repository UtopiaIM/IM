using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IM
{
    public partial class recievefile : Form
    {
        public recievefile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rf = new FolderBrowserDialog();
            if (rf.ShowDialog()==DialogResult.OK)
            {
                waterTextBox1.Text = rf.SelectedPath; 
            }
        }
    }
}
