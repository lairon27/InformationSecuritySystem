//Шифр Віженера

using System;
using System.Windows.Forms;

namespace Project5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            var timer = new Timer {Interval = 100};
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (label1.Left > -label1.Width)
            {
                label1.Left -= 7;
            }
            else
            {
                label1.Left = panel1.Width;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form1(); 
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new EncodeUkr(); 
            form2.Show();
        }
    }
}