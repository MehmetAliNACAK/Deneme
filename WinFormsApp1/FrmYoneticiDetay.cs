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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FrmYoneticiDetay : Form
    {
        public FrmYoneticiDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmYoneticiDetay_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void FrmYoneticiDetay_Load(object sender, EventArgs e)
        {
            label5.Text = tc;

            SqlCommand komut = new SqlCommand("Select YoneticiAd,YoneticiSoyad from Tbl_Yonetici where YoneticiTC= @p1", bgl.baglati());
            komut.Parameters.AddWithValue("@p1", label5.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0] + " " + dr[1];

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("select PersonelTC,PersonelAdı,PersonelSoyadı,PersonelGörevi from Tbl_Personel where PersonelGörevi like '" + comboBox1.Text + "' ", bgl.baglati());


            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

                label13.Text = dr3["PersonelTC"].ToString();
                label14.Text = dr3["PersonelAdı"].ToString();
                label15.Text = dr3["PersonelSoyadı"].ToString();
                comboBox1.Text = dr3["PersonelGörevi"].ToString();


            }
            bgl.baglati().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Kiracılar fr = new Frm_Kiracılar();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Kira  set KiraMiktarı = '" + textBox1.Text + "' where KiraSahibiTC = '" + maskedTextBox1.Text + " ' ", bgl.baglati());
            komut2.Parameters.AddWithValue("@p1", textBox1.Text);
            komut2.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut2.ExecuteNonQuery();
            bgl.baglati().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_EvSahibiBilgiPaneli fr2 = new Frm_EvSahibiBilgiPaneli();
            fr2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_KiracıBilgiPaneli fr2 = new Frm_KiracıBilgiPaneli();
            fr2.Show();
            this.Hide();
        }
    }
}
