using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Frm_Kiracı_Uye_Ol : Form
    {
        public Frm_Kiracı_Uye_Ol()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kiracı (KiracıTC,KiracıAd,KiracıSoyad,KiracıTelefon,KiracıSifre,KiracıCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglati());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p5", textBox3.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglati().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir.Şifreniz :" + textBox3.Text, "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Frm_Kiracı_Uye_Ol_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}