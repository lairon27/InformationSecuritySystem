//квадрат Полібія (метод 2) з випадковим розміщенням символів алфавіту.

using System;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encrypt.Click += button1_Click;
            decrypt.Click += button2_Click;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var form2 = new Encrypt();
                form2.Show();
            }
            else
            {
                var form2 = new EncryptUkr();
                form2.Show();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var form2 = new Decrypt();
                form2.Show();
            }
            else
            {
                var form2 = new DecryptUkr();
                form2.Show();
            }
        }
    }
}