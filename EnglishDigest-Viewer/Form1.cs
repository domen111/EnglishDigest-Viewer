using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishDigest_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string AMCDir;

        private void Form1_Shown(object sender, EventArgs e)
        {
            while (true)
            {
                if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                AMCDir = folderBrowserDialog1.SelectedPath;
                if (AMCDir.EndsWith("\\") == false)
                    AMCDir += "\\";
                if (File.Exists(AMCDir + "EnglishDigest.exe") == false)
                {
                    if (MessageBox.Show("這似乎不是一個空中美語的光碟，請問你是否要重新選擇?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        continue;
                }
                break;
            }
        }
    }
}
