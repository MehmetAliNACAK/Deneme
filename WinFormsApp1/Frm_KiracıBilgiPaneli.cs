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
using System.Windows.Forms.Design.Behavior;

namespace WinFormsApp1
{
    public partial class Frm_KiracıBilgiPaneli : Form
    {
        public Frm_KiracıBilgiPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Frm_KiracıBilgiPaneli_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from Tbl_Kiracı", bgl.baglati());

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Frm_KiracıBilgiPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }
    }
}
