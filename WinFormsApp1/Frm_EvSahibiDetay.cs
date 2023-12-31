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
    public partial class Frm_EvSahibiDetay : Form
    {
        public Frm_EvSahibiDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Frm_EvSahibiDetay_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Otopark (OtoparkDurum,OtoparkTipi,OtoparkNumarası) values(@p1,@p2,@p3)", bgl.baglati());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.ExecuteNonQuery();



            /*   SqlCommand komut4 = new SqlCommand("create trigger OtoparkGuncelle\r\non Tbl_Otopark \r\ninstead of\r\ninsert \r\nas\r\n\tdeclare @id int\r\n\tselect @id = OtoparkNumarası from inserted \r\n\t update Tbl_Otopark set OtoparkDurum=@p1 OtoparkTipi=@p2 where OtoparkNumarası=@id", bgl.baglati());
                komut4.Parameters.AddWithValue("@p1", comboBox1.Text);
                komut4.Parameters.AddWithValue("@p2", comboBox2.Text);
                komut4.Parameters.AddWithValue("@p3", textBox1.Text);
                komut4.ExecuteNonQuery();
            */


            MessageBox.Show("Kayıt Gerçekleşmiştir");

            bgl.baglati().Close();

        }

        private void Frm_EvSahibiDetay_Load(object sender, EventArgs e)
        {
            label5.Text = tc;

            SqlCommand komut = new SqlCommand("Select EvSahibiAd,EvSahibiSoyad from Tbl_EvSahibi where EvSahibiTC= @p1", bgl.baglati());
            komut.Parameters.AddWithValue("@p1", label5.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0] + " " + dr[1];

            }

            SqlCommand komut2 = new SqlCommand("Select ApartmanAdı,ApartmanBlok from Tbl_Apartman where ApartmanÜyeTC like '" + label5.Text + "'", bgl.baglati());
            // komut2.Parameters.AddWithValue("@c1", label5.Text);

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label12.Text = dr2["ApartmanAdı"].ToString();
                label13.Text = dr2["ApartmanBlok"].ToString();
            }


            SqlCommand komut3 = new SqlCommand("Select DaireNo,DaireTipi from Tbl_Daire where DaireSahibiTC like '" + label5.Text + "'", bgl.baglati());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label14.Text = dr3["DaireNo"].ToString();
                label15.Text = dr3["DaireTipi"].ToString();

            }
            bgl.baglati().Close();





            /*
                        SqlCommand komut2 = new SqlCommand("Select OtoparkNumarası from Tbl_Otopark", bgl.baglati());
                        SqlDataReader dr2 = komut2.ExecuteReader();

                        while (dr2.Read())
                        {

                        }
            */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text == " ") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            SqlCommand komut3 = new SqlCommand("select OtoparkNumarası,OtoparkDurum,OtoparkTipi from Tbl_Otopark where OtoparkNumarası like '" + textBox1.Text + "' ", bgl.baglati());


            SqlDataReader dr3 = komut3.ExecuteReader();


            while (dr3.Read())
            {

                textBox1.Text = dr3["OtoparkNumarası"].ToString();
                comboBox1.Text = dr3["OtoparkDurum"].ToString();
                comboBox2.Text = dr3["OtoparkTipi"].ToString();


            }
            bgl.baglati().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Update Tbl_Otopark set OtoparkTipi = @p1,OtoparkDurum = @p2 where OtoparkNumarası = @p3", bgl.baglati());
            komut4.Parameters.AddWithValue("@p1", comboBox2.Text);
            komut4.Parameters.AddWithValue("@p2", comboBox1.Text);
            komut4.Parameters.AddWithValue("@p3", textBox1.Text);
            komut4.ExecuteNonQuery();
            bgl.baglati().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = tc;

            SqlCommand komut = new SqlCommand("select FaturaTür,FaturaMiktar from Tbl_Fatura where FaturaSahibiTC =@p1", bgl.baglati());

            komut.Parameters.AddWithValue("@p1", label5.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand komut2 = new SqlCommand("select AidatÜcreti from Tbl_Aidat where AidatSahibiTC =@t1", bgl.baglati());

            komut2.Parameters.AddWithValue("@t1", label5.Text);

            SqlDataAdapter da2 = new SqlDataAdapter(komut2);

            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            bgl.baglati().Close();
        }


    }
}
