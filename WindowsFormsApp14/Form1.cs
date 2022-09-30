using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LimeGreen;
            TransparencyKey = Color.LimeGreen;
            Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            Height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            Location = new Point(0, 0);
            TopMost = true;
            pictureBox1.Width = Height;
            pictureBox1.Height = Height;
            pictureBox1.Location = new Point(Width/2 - Height / 2, 0);
            timer1.Enabled = true;
            ShowInTaskbar = false;
        }
        public static Random rd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Visible = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Vine boom sound effect.wav");
            player.Play();
            timer2.Interval = 6000;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Interval = rd.Next(300000, 600000);
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
    }
}
