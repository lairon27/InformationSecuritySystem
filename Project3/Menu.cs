using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            encrypted.Click += button1_Click;
            button1.Click += button2_Click;
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog1.FileName;
            var fileText = File.ReadAllLines(filename);
            textBox1.Text = fileText[2];
            textBox3.Text = fileText[0];
            textBox4.Text = fileText[1];
            textBox5.Text = fileText[3];
            textBox6.Text = fileText[4];
            MessageBox.Show("File open");
        }
        
        void button1_Click(object sender, EventArgs e)
        {
            var n = int.Parse(textBox3.Text);
            var m = int.Parse(textBox4.Text);
            var keys=textBox5.Text.ToCharArray();
            var keys1=textBox6.Text.ToCharArray();
            var array = new char[m,n];
            var s = textBox1.Text;
            
            for (var i = 0; i < s.Length; i++)
            {
                array[i/n, i%n] = s[i];
            }
            
            dataGridView2.RowCount = m;
            dataGridView2.ColumnCount = n;
            for (var i = 0; i < m; ++i)
            {   
                for (var j = 0; j < n; ++j)
                {
                    dataGridView2.Rows[i].Cells[j].Value = array[i, j];
                }
            }
            
            var result = new char[m, n];
            
            for (var i = 0; i <m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var ii = keys[j].ToString();
                    result[i, j] = array[i, int.Parse(ii)-1];
                }
            }
            
            string a = null;
            foreach (var item in result)
            {
                a += item.ToString();
            }
            
            var array1 = new char[m, n];
            for (var i = 0; i < a.Length; i++)
            {
                array1[i/n, i%n] = a[i];
            }
            
            var result1 = new char[m, n];
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var ii = keys1[i].ToString();
                    result1[i, j] = array1[int.Parse(ii) - 1, j];
                }
            }
            var sb = new StringBuilder();
            for (var j = 0; j < m; j++)
            {
                for (var i = 0; i < n; i++)
                {
                    sb.Append($"{result1[j, i]}");
                }
            }
            textBox2.Text = sb.ToString();
            
            dataGridView1.RowCount = m;
            dataGridView1.ColumnCount = n;
            for(var i = 0; i < m; ++i)
            {   
                for (var j = 0; j < n; ++j)
                {
                    dataGridView1.Rows[i].Cells[j].Value = result1[i, j];
                }
            }
        }
    }
}