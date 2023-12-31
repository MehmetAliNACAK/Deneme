namespace WinFormsApp1
{
    partial class Frm_EvSahibi
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
            maskedTextBox1 = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(162, 98);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(139, 27);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(300, 221);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 176);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 11;
            label2.Text = "Ev Sahibi Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 101);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 10;
            label1.Text = "Ev Sahibi TC : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 173);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 27);
            textBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(162, 282);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 72);
            button1.TabIndex = 8;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_EvSahibi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "Frm_EvSahibi";
            Text = "Frm_EvSahibi";
            FormClosing += Frm_EvSahibi_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button button1;
    }
}