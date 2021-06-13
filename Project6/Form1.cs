//RSA
//прості числа вибрати випадковим чином, перевірити простоту методом "решета Ератосфена"
//Вибирається ціле число e, таке, що 1<e<phi (n) та e, взаємно просте з phi (n). (Вибрати випадковим чином і перевірити взаємну простоту алгоритмом Евкліда)
//Знаходиться число d, таке, що ed equiv 1 (mod phi (n)). (Знайти за дапомогою розширеного алгоритму Евкліда).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class Form1 : Form
    {
        static char[] characters = new char[] { '#', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J','K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
            'T', 'Y', 'V', 'W', 'X', 'U', 'Z',' ', '1', '2', '3', '4', '5', '6', '7','8', '9', '0' };
        
        public Form1()
        {
            InitializeComponent();
        }

        static uint SieveEratosthenes(uint n)
        {
            var a = new uint[n + 1];
            for (var i = 2u; i < n + 1; i++)
            {
                a[i] = i;
            }
            
            for (var p = 2; p < n + 1; p++)
            {
                for (var j = p*p; j < n + 1; j += p)
                    a[j] = 0;
            }
            if (a.Contains(n))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static uint Calculate_e(uint phi_n)
        {
            var random = new Random();
            var e = (uint) random.Next((int) phi_n);
            for (uint i = 2; i <= phi_n; i++)
                if ((phi_n % i == 0) && (e % i == 0)) 
                {
                    e--;
                }
            
            return e;
        }
        
        public static BigInteger modinv(BigInteger u, BigInteger v)
        {
            BigInteger inv, u1, u3, v1, v3, t1, t3, q;
            BigInteger iter;
            
            u1 = 1;
            u3 = u;
            v1 = 0;
            v3 = v;
            iter = 1;
            while (v3 != 0)
            {
                q = u3 / v3;
                t3 = u3 % v3;
                t1 = u1 + q * v1;
                u1 = v1; v1 = t1; u3 = v3; v3 = t3;
                iter = -iter;
            }
            if (u3 != 1)
                return 0;   
          
            if (iter < 0)
                inv = v - u1;
            else
                inv = u1;
            return inv;
        }
        
        private static List<string> RSA_Endoce(string s, uint e, uint n)
        {
            var result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                bi = bi % n;

                result.Add(bi.ToString());
            }

            return result;
        }
        private void button1_Click(object sender, EventArgs eventArgs)
        {
            var p = 0u;
            var q = 0u;

            do
            {
                var random = new Random();
                p = (uint) random.Next(1000);
                q = (uint) random.Next(1000);
            } while (SieveEratosthenes(p) == 0 || SieveEratosthenes(q) == 0);
            
            textBox2.Text = p.ToString();
            textBox3.Text = q.ToString();
            var n = p * q;
            textBox4.Text = n.ToString();
            var phi_n = (p - 1) * (q - 1);
            textBox5.Text = phi_n.ToString();
            uint e = Calculate_e(phi_n);
            textBox6.Text = e.ToString();
            BigInteger d = modinv(e, phi_n);
            textBox7.Text = d.ToString();
            var s = textBox1.Text.ToUpper();
            var result = RSA_Endoce(s, e, n);

            var sb = new StringBuilder();
            foreach (string item in result)
                sb.AppendLine(item);

            textBox8.Text = sb.ToString();
            
            StreamWriter sw = new StreamWriter("out1.txt");
            foreach (string item in result)
                sw.WriteLine(item);
            sw.Close();
        }
        
        private string RSA_Dedoce(List<string> input, BigInteger d, uint n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                bi = bi % n;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var d = BigInteger.Parse(textBox7.Text);
            var n = uint.Parse(textBox4.Text);
 
            List<string> input = new List<string>();
 
            
            StreamReader sr = new StreamReader("out1.txt");
 
            while (!sr.EndOfStream)
            {
                input.Add(sr.ReadLine());
            }
            
            sr.Close();
 
            string result = RSA_Dedoce(input, d, n);
 
            StreamWriter sw = new StreamWriter("out2.txt");
            sw.WriteLine(result);
            sw.Close();
 
            // Process.Start("out2.txt");
            textBox9.Text = result;
        }
    }
}