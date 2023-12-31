namespace WinFormsApp1
{
    partial class FrmEvSahibiKayıtOl
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
            textBox3 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(261, 368);
            button1.Name = "button1";
            button1.Size = new Size(141, 53);
            button1.TabIndex = 26;
            button1.Text = "KAYIT OL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "KADIN", "ERKEK" });
            comboBox1.Location = new Point(292, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(292, 196);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(292, 136);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 23;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 320);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 20;
            label6.Text = "CİNSİYET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 266);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 19;
            label5.Text = "ŞİFRE :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 206);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 18;
            label4.Text = "TELEFON :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 142);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 17;
            label3.Text = "TC KİMLİK NO : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 81);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 16;
            label2.Text = "SOYAD : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 29);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 15;
            label1.Text = "AD :";
            // 
            // FrmEvSahibiKayıtOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 451);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEvSahibiKayıtOl";
            Text = "FrmEvSahibiKayıtOl";
            FormClosing += FrmEvSahibi_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Button button1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}