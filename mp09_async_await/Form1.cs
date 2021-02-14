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

namespace mp09_async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string[] fileArray = Directory.GetFiles(@"C:\");
            foreach (string name in fileArray)
            {
               lv_1.Text += name + "\r\n";
            }
            button1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            inpt_2.Text = "Buenas";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy hh:mm:ss");
            inpt_date.Text = date;
        }
    }
}
