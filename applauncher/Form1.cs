using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime;
using System.Diagnostics;


namespace applauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "notepad.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "mspaint.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "iexplore.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "explorer.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "write.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button33_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "7zFM.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "devenv.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "C:\\NClass\\bin\\nclass.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "C:\\SharpDevelop\\bin\\SharpDevelop.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button39_Click(object sender, EventArgs e)
        {
           
                ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "C:\\_apps\\Start.EXE";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            
                  ProcessStartInfo startInfo = new ProcessStartInfo();
                  startInfo.FileName = "cmd";
            //startInfo.Arguments = textBox1.Text;
            Process.Start(startInfo);
        }
    }
}
