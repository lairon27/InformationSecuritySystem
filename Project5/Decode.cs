using System;
using System.IO;
using System.Windows.Forms;

namespace Project5
{
    public partial class Decode : Form
    {
        public Decode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog1.FileName;
            var fileText = File.ReadAllLines(filename);
            textBox1.Text = fileText[0];
            textBox2.Text = fileText[1];
        
            MessageBox.Show("File open");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var filename = openFileDialog1.FileName;
            var fileText = File.ReadAllLines(filename);
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var inputText1 = fileText[0];
            var password1 = fileText[1];
            // var password = "";
            var decrypt = "";
            var index = "";
            var index1 = "";
            var q = alphabet.Length;
            
            for (var i = 0; i < inputText1.Length; i++)
            {
                var letterIndex = alphabet.IndexOf(inputText1[i]);
                var codeIndex = alphabet.IndexOf(password1[i]);
                // password += alphabet[(q - codeIndex)].ToString();
                if (letterIndex < 0)
                {
                    decrypt += inputText1[i].ToString();
                }
                else
                {
                    decrypt += alphabet[(letterIndex + (q - codeIndex)) % q].ToString();
                }
                
                index += Convert.ToString(letterIndex);
                // index1 += Convert.ToString(alphabet.IndexOf(password[i]));
            }
            label2.Text = index;
            label1.Text = index1;
            // textBox2.Text = password;
            textBox4.Text = decrypt;
        }
    }
}