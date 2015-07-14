using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EnglishDigest_Viewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string AMCDir;
        public DateTime date;

        private void Form2_Load(object sender, EventArgs e)
        {
            if (checkMonth(AMCDir) == false)
            {
                MessageBox.Show("光碟月份有誤");
                this.Close();
                return;
            }
        }
        bool checkMonth(string dir)
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(AMCDir + "data\\CDVersion.xml");
            string[] diskMonth = xd.SelectSingleNode("INIT_DATA").SelectSingleNode("VERSION").InnerText.Split('-');
            if (date.Year != int.Parse(diskMonth[0]))
                return false;
            if (date.Month != int.Parse(diskMonth[1]))
                return false;
            return true;
        }
    }
}
