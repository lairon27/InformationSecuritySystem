using System;
using System.IO;
using System.Windows.Forms;

namespace Project4
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog1.FileName;
            var fileText = File.ReadAllLines(filename);
            textBox1.Text = fileText[1];
            textBox2.Text = fileText[0];
            
            MessageBox.Show("File open");
        }

        void button1_Click(object sender, EventArgs e)
        {
            var filename = openFileDialog1.FileName;
            var fileText = File.ReadAllLines(filename);
            var alphabet = fileText[2];
            var message = textBox1.Text;
            var coordinates = new int[message.Length * 2];
            var encrypt = "";
            
            var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));
            var square = new char[n, n];
            var index = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (index < alphabet.Length)
                    {
                        square[i, j] = alphabet[index];
                        index++;
                    }
                }
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
            
            var q = 0;
            foreach (var t in message)
            {
                for (var l = 0; l < square.GetLength(0); l++)
                    for (var k = 0; k < square.GetLength(1); k++)
                        if (char.ToLower(square[l, k]) == t || char.ToUpper(square[l, k]) == t)
                        {
                            coordinates[q] = k;
                            coordinates[q + 1] = l;
                            q += 2;
                        }
            }
            
            for (var i = 0; i < message.Length; i++)
            {
                encrypt += square[coordinates[i + message.Length], coordinates[i]];
            }
            textBox3.Text = encrypt;
        }
    }
}