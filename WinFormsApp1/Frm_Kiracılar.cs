using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Frm_Kiracılar : Form
    {
        public Frm_Kiracılar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Frm_Kiracılar_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from Tbl_Kira", bgl.baglati());

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Frm_Kiracılar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
