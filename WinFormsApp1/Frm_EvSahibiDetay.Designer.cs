namespace WinFormsApp1
{
    partial class Frm_EvSahibiDetay
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            groupBox6 = new GroupBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(159, 93);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 3;
            label7.Text = "Null Null";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 93);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 2;
            label6.Text = "AD SOYAD :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 49);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 1;
            label5.Text = "00000000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 49);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "T.C. NO :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(12, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borç Bilgi Paneli";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(9, 139);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(379, 96);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Aidat Bilgi Ekranı";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(373, 70);
            dataGridView2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(139, 241);
            button5.Name = "button5";
            button5.Size = new Size(117, 36);
            button5.TabIndex = 0;
            button5.Text = "SONUÇ GETİR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(9, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(379, 110);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fatura Bilgi Ekranı";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(373, 84);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(406, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(382, 218);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Araç Yer Bilgileri";
            // 
            // button4
            // 
            button4.Location = new Point(194, 171);
            button4.Name = "button4";
            button4.Size = new Size(93, 32);
            button4.TabIndex = 8;
            button4.Text = "GÜNCELLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(31, 171);
            button3.Name = "button3";
            button3.Size = new Size(81, 32);
            button3.TabIndex = 7;
            button3.Text = "TEMİZLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "AÇIK", "KAPALI" });
            comboBox2.Location = new Point(200, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DOLU", "BOŞ" });
            comboBox1.Location = new Point(200, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 116);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Otopark Tipi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 33);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 2;
            label2.Text = "Otopark Numarası :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 77);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Otopark Durumu :";
            // 
            // button2
            // 
            button2.Location = new Point(293, 171);
            button2.Name = "button2";
            button2.Size = new Size(73, 32);
            button2.TabIndex = 0;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(406, 236);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(382, 213);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Apartman Bilgi Ekranı";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(168, 137);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 7;
            label15.Text = "Null";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(168, 107);
            label14.Name = "label14";
            label14.Size = new Size(36, 20);
            label14.TabIndex = 6;
            label14.Text = "Null";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(168, 77);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 5;
            label13.Text = "Null";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(168, 44);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 4;
            label12.Text = "Null";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 137);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 3;
            label11.Text = "Daire Tipi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 107);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 2;
            label10.Text = "Daire No :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 77);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 1;
            label9.Text = "Apartman Blok:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 44);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 0;
            label8.Text = "Apartman Adı :";
            // 
            // Frm_EvSahibiDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_EvSahibiDetay";
            Text = "Frm_EvSahibiDetay";
            FormClosing += Frm_EvSahibiDetay_FormClosing;
            Load += Frm_EvSahibiDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}