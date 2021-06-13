using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project4
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
 
            var newAlphabet = alphabet + "0123456789!@#$%^&*)_+-=<>?,.";
           
            var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));
            var square = new char[n, n];
            var index = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (index < newAlphabet.Length)
                    {
                        square[i, j] = newAlphabet[index];
                        index++;
                    }
                }
            }

            var lengthRow = square.GetLength(1);

            var random = new Random();
            for (var i = square.Length - 1; i > 0; i--)
            {
                var i0 = i / lengthRow;
                var i1 = i % lengthRow;

                var j = random.Next(i + 1);
                var j0 = j / lengthRow;
                var j1 = j % lengthRow;

                var temp = square[i0, i1];
                square[i0, i1] = square[j0, j1];
                square[j0, j1] = temp;
            }
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    dataGridView1.Rows[i].Cells[j].Value = square[i, j];
                    dataGridView1.Rows[i].HeaderCell.Value = (i).ToString();
                    dataGridView1.Columns[j].HeaderCell.Value = (j).ToString();
                }
            }
            
            var message = textBox1.Text;
            var key = "";
            var key1 = "";
            var encrypt = "";
            var coordinates = new int[message.Length * 2];
            
            for (var i = 0; i < message.Length; i++)
            {
                for (var j = 0; j < square.GetLength(0); j++)
                    for (var k = 0; k < square.GetLength(1); k++)
                        if (char.ToLower(square[j, k]) == message[i] || char.ToUpper(square[j, k]) == message[i])
                        {
                            key1 += (Convert.ToString(j));
                            key += (Convert.ToString(k));
                            coordinates[i] = k;
                            coordinates[i + message.Length] = j;
                        }
            }
            
            for (var i = 0; i < message.Length * 2; i += 2)
            {
                encrypt += square[coordinates[i + 1], coordinates[i]];
            }
            var newMessage = (key + key1);
            var list = new List<string>();
            var l = 0;
            while (l < newMessage.Length - 1)
            {
                list.Add(newMessage.Substring(l, 2));
                l += 2;
            }
            textBox2.Text = string.Join("\t", list);
            textBox3.Text = encrypt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = saveFileDialog1.FileName;
            var sb = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            { 
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value);
                }
            }

            var value = sb.ToString();
            File.WriteAllText(filename, $"{textBox2.Text}\n{textBox3.Text}\n{value}");
            MessageBox.Show("File save");
        }
    }
}