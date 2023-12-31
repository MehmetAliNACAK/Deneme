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
using System.Windows.Forms.Design.Behavior;

namespace WinFormsApp1
{
    public partial class Frm_EvSahibi : Form
    {
        public Frm_EvSahibi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEvSahibiKayıtOl fr = new FrmEvSahibiKayıtOl();
            fr.Show();
            this.Hide();
        }

        private void Frm_EvSahibi_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_EvSahibi Where EvSahibiTC=@p1 and EvSahibiSifre=@p2", bgl.baglati());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                Frm_EvSahibiDetay fr = new Frm_EvSahibiDetay();
                fr.tc = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. veya Şifre");
            }
            bgl.baglati().Close();
        }

        
    }
}
