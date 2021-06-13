//рядково-стовпчиковий метод перестановки з двома ключами

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encrypt.Click += button1_Click;
            decrypt.Click += button2_Click;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Decrypt();
            form2.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Menu();
            form2.Show();
        }
    }
}