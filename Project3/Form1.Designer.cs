namespace Project3
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
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(95, 181);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(210, 77);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "Зашифрувати";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(378, 181);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(210, 77);
            this.decrypt.TabIndex = 2;
            this.decrypt.Text = "Розшифрувати";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(211, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть опцію\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button decrypt;

        private System.Windows.Forms.Button encrypt;

        #endregion
    }
}