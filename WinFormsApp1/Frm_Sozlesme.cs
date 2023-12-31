using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Frm_Sozlesme : Form
    {
        public Frm_Sozlesme()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Frm_Sozlesme_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Frm_Sozlesme_Load(object sender, EventArgs e)
        {
            label5.Text = tc;
            SqlCommand komut = new SqlCommand("Select KiracıAd,KiracıSoyad from Tbl_Kiracı where KiracıTC= @p1", bgl.baglati());

            komut.Parameters.AddWithValue("@p1", label5.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0] + " " + dr[1];

            }


            SqlCommand komut2 = new SqlCommand("Select ApartmanAdı,ApartmanBlok from Tbl_Apartman where ApartmanÜyeTC like '" + label5.Text + "'", bgl.baglati());


            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label13.Text = dr2["ApartmanAdı"].ToString();
                label14.Text = dr2["ApartmanBlok"].ToString();
            }


            SqlCommand komut3 = new SqlCommand("Select DaireNo,DaireTipi from Tbl_Daire where DaireSahibiTC like '" + label5.Text + "'", bgl.baglati());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label15.Text = dr3["DaireNo"].ToString();
                label12.Text = dr3["DaireTipi"].ToString();

            }
            bgl.baglati().Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("select KiraMiktarı,DepozitoMiktarı from Tbl_Kira,Tbl_Depozito where KiraSahibiTC like '" + label5.Text +"' ", bgl.baglati());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                label16.Text = dr4["KiraMiktarı"].ToString();
                label3.Text = dr4["DepozitoMiktarı"].ToString();
            }

        }
    }
}
