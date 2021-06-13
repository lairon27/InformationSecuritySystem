using System;
using System.IO;
using System.Windows.Forms;

namespace Project5
{
    public partial class EncodeUkr : Form
    {
        public EncodeUkr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            var inputText = textBox1.Text.ToUpper();
            var rand = new Random();
            
            var password = "";
            
            for (var i = 0; i < inputText.Length; i++)
                password += alphabet[rand.Next(0, alphabet.Length)];

            textBox2.Text = password;
            
            var encrypt = "";
            var index = "";
            var index1 = "";
            var q = alphabet.Length;
        
            for (var i = 0; i < inputText.Length; i++)
            {
                var letterIndex = alphabet.IndexOf(inputText[i]);
                var codeIndex = alphabet.IndexOf(password[i]);
                if (letterIndex < 0)
                {
                    encrypt += inputText[i].ToString();
                }
                else
                {
                    encrypt += alphabet[(letterIndex + codeIndex) % q].ToString();
                }

                index += Convert.ToString(letterIndex);
                index1 += Convert.ToString(codeIndex);
            }

            label1.Text = index;
            label2.Text = index1;
            textBox3.Text = encrypt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, $"{textBox3.Text}\n{textBox2.Text}");
            MessageBox.Show("Файл збережено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new DecodeUkr(); 
            form2.Show();
        }
    }
}