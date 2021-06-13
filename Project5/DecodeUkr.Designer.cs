using System.ComponentModel;

namespace Project5
{
    partial class DecodeUkr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecodeUkr));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 43);
            this.label3.TabIndex = 10;
            this.label3.Text = "Зашифроване повідомлення";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ключ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (102)))), ((int) (((byte) (165)))), ((int) (((byte) (173)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(163, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Розшифрувати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 41);
            this.label5.TabIndex = 15;
            this.label5.Text = "Розшифроване повідомлення";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (102)))), ((int) (((byte) (165)))), ((int) (((byte) (173)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(163, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Відкрити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 22);
            this.textBox3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(162, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 22);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(163, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 22);
            this.label2.TabIndex = 19;
            // 
            // DecodeUkr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (185)))), ((int) (((byte) (196)))), ((int) (((byte) (201)))));
            this.ClientSize = new System.Drawing.Size(510, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DecodeUkr";
            this.Text = "Розшифрування";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}