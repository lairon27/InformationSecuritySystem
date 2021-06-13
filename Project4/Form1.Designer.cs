namespace Project4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (102)))), ((int) (((byte) (165)))), ((int) (((byte) (173)))));
            this.encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (142)))), ((int) (((byte) (155)))), ((int) (((byte) (151)))));
            this.encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.encrypt.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (74)))), ((int) (((byte) (82)))));
            this.encrypt.Location = new System.Drawing.Point(12, 153);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(134, 40);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Encrypt/Зашифрувати";
            this.encrypt.UseVisualStyleBackColor = false;
            // 
            // decrypt
            // 
            this.decrypt.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (102)))), ((int) (((byte) (165)))), ((int) (((byte) (173)))));
            this.decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decrypt.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (74)))), ((int) (((byte) (82)))));
            this.decrypt.Location = new System.Drawing.Point(163, 153);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(134, 40);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Decrypt/Розшифрувати";
            this.decrypt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (74)))), ((int) (((byte) (82)))));
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select an option Оберіть опцію";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 46);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (44)))), ((int) (((byte) (74)))), ((int) (((byte) (82)))));
            this.groupBox1.Location = new System.Drawing.Point(41, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language/Мова";
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioButton2.Location = new System.Drawing.Point(122, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Українська";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (82)))), ((int) (((byte) (149)))), ((int) (((byte) (139)))));
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (77)))), ((int) (((byte) (71)))));
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (77)))), ((int) (((byte) (71)))));
            this.radioButton1.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (185)))), ((int) (((byte) (196)))), ((int) (((byte) (201)))));
            this.ClientSize = new System.Drawing.Size(309, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Button decrypt;

        private System.Windows.Forms.Button encrypt;

        #endregion
    }
}