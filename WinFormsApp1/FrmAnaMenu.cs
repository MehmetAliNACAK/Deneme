namespace WinFormsApp1
{

    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_EvSahibi fr = new Frm_EvSahibi();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Yonetici fr = new Frm_Yonetici();
            fr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Kiraci fr = new Frm_Kiraci();
            fr.Show();
            this.Hide();
        }

        private void FrmAnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }
    }
}