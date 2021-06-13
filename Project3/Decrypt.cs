using System.Windows.Forms;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Project3
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            var firstKey = int.Parse(textBox3.Text);
            var secondKey = int.Parse(textBox4.Text);
           
            var stringUser = textBox1.Text;
            
            var matrix = new char[secondKey, firstKey];
            
            var listCharNumFirst = Enumerable.Range(1, firstKey).ToArray(); 
            var r = new Random();
            for (var i = firstKey - 1; i >= 1; i--)
            {
                var j = r.Next(i + 1);
                var temp = listCharNumFirst[j];
                listCharNumFirst[j] = listCharNumFirst[i];
                listCharNumFirst[i] = temp;
            }
            var sbu = new StringBuilder();
            foreach (var item in listCharNumFirst)
                sbu.Append(item);

            textBox5.Text = sbu.ToString();
            
            var listCharNumSecond = Enumerable.Range(1, secondKey).ToArray();
            for (var i = secondKey - 1; i >= 1; i--)
            {
                var j = r.Next(i + 1);
                var temp = listCharNumSecond[j];
                listCharNumSecond[j] = listCharNumSecond[i];
                listCharNumSecond[i] = temp;
            }
            
            var sbui = new StringBuilder();
            foreach (var item in listCharNumSecond)
                sbui.Append(item);

            textBox6.Text = sbui.ToString();
            for (var i = 0; i < stringUser.Length; i++)
            {
                matrix[i/firstKey, i%firstKey] = stringUser[i];
            }
 
            dataGridView1.RowCount = secondKey;
            dataGridView1.ColumnCount = firstKey;
            for (var i = 0; i < secondKey; ++i)
            {   
                for (var j = 0; j < firstKey; ++j)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            var result = new char[secondKey, firstKey];

            for (var j = 0; j < secondKey; j++)
            {
                for (var i = 0; i < firstKey; i++)
                {
                    var ii = listCharNumFirst[i].ToString();
                    result[j, int.Parse(ii) - 1] = matrix[j, i];
                }
            }
            
            string a = null;
            foreach (var item in result)
            {
                a += item.ToString();
            }
            
            var array1 = new char[secondKey, firstKey];
            for (var i = 0; i < a.Length; i++)
            {
                array1[i/firstKey, i%firstKey] = a[i];
            }
            
            var result1 = new char[secondKey, firstKey];
            for (var i = 0; i < secondKey; i++)
            {
                for (var j = 0; j < firstKey; j++)
                {
                    var ii = listCharNumSecond[i].ToString();
                    result1[int.Parse(ii) - 1, j] = array1[i, j];
                }
            }
            
            var sb = new StringBuilder();
            for (var j = 0; j < secondKey; j++)
            {
                for (var i = 0; i < firstKey; i++)
                {
                    sb.Append($"{result1[j, i]}");
                }
            }
            
            textBox2.Text = sb.ToString();
            
            dataGridView2.RowCount = secondKey;
            dataGridView2.ColumnCount = firstKey;
            for (var i = 0; i < secondKey; ++i)
            {
                for (var j = 0; j < firstKey; ++j)
                {
                    dataGridView2.Rows[i].Cells[j].Value = result1[i, j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, $"{textBox3.Text}\n{textBox4.Text}\n{textBox2.Text}\n{textBox5.Text}\n{textBox6.Text}");
            MessageBox.Show("File save");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Menu();
            form2.Show();
        }
    }
}