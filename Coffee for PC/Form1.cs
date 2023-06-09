using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_for_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Quoted solution from this website.
            //https://teratail.com/questions/16990 Thanks a lot!
            Clipboard.Clear();
            Clipboard.SetText("カメラ");

            SendKeys.Send("^{ESC}");
            Application.DoEvents();

            SendKeys.Send("^v");
            Application.DoEvents();

            SendKeys.Send("{ENTER}");
            Clipboard.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://www.google.co.jp/search?q="+textBox2.Text;
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://duckduckgo.com/?q=" + textBox2.Text;
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr2 = new ProcessStartInfo();
            gobr2.FileName = "https://www.bing.com/search?q=" + textBox2.Text;
            gobr2.UseShellExecute = true;
            Process.Start(gobr2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://www.youtube.com/results?search_query=" + textBox2.Text;
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://www.nicovideo.jp/search/" + textBox2.Text;
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://yokochayokoha.github.io";
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://api.qrserver.com/v1/create-qr-code/?data="+textBox2.Text;
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gobr = new ProcessStartInfo();
            gobr.FileName = "https://sites.google.com/view/yokocafe/coffee";
            gobr.UseShellExecute = true;
            Process.Start(gobr);
        }
    }
}
