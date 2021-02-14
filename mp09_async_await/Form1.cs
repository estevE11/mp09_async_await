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
using System.Diagnostics;
namespace mp09_async_await
{
    public partial class Form1 : Form
    {
        // Ruta d'on carregarà els arxius
        private string TEST_PATH = @"E:\dev";

        // Temps de descans del thread entre bucle de foreach
        // Augmentar per veure els efectes del multithreading mes clars
        private int sleepTime = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            var searchTask = Task<List<string>>.Factory.StartNew(() => singleThreadedSearch());
            await searchTask;
            timer.Stop();
            foreach(string name in searchTask.Result)
            {
                txtBox_1.Text += name + "\r\n";
            }
            inpt_1.Text = timer.Elapsed.TotalSeconds.ToString() + " segons";
            button1.Enabled = true;
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            var searchTask = Task<List<string>>.Factory.StartNew(() => multiThreadedSearch());
            await searchTask;
            timer.Stop();
            foreach (string name in searchTask.Result)
            {
                txtBox_2.Text += name + "\r\n";
            }
            inpt_2.Text = timer.Elapsed.TotalSeconds.ToString() + " segons";
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy hh:mm:ss");
            inpt_date.Text = date;
        }

        private List<string> singleThreadedSearch() {
            List<string> res = new List<string>();

            foreach (string d in Directory.GetDirectories(TEST_PATH)) {
                foreach (string s in Directory.GetFiles(d)) {
                    res.Add(s);
                    System.Threading.Thread.Sleep(sleepTime);
                }
            }

            return res;
        }

        private List<string> multiThreadedSearch() {
            List<string> res = new List<string>();

            Parallel.ForEach(Directory.GetDirectories(TEST_PATH), (d) => {
                Parallel.ForEach(Directory.GetFiles(d), (s) => {
                    res.Add(s);
                    System.Threading.Thread.Sleep(sleepTime);
                });
            });

            return res;
        }
    }
}
