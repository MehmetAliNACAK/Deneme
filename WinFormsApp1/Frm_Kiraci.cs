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
using System.Security.Cryptography.Pkcs;

namespace WinFormsApp1
{
    public partial class Frm_Kiraci : Form
    {
        public Frm_Kiraci()
        {
            InitializeComponent();
        }

        private void Frm_Kiraci_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kiracı Where KiracıTC=@p1 and KiracıSifre=@p2", bgl.baglati());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                Frm_Kiracı_Detay fr = new Frm_Kiracı_Detay();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Kiracı_Uye_Ol fr = new Frm_Kiracı_Uye_Ol();
            fr.Show();
            this.Hide();
        }

        
    }
}
