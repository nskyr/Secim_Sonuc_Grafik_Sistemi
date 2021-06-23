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
namespace Secim_Sonuc_Grafik_Sistemi
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ENES\MSSQLSERVER01;Initial Catalog=SecimSonuc;Integrated Security=True");

        private void btnOyGirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ilce (ilceAd,AParti,BParti,CParti,DParti) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIlceAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtAparti.Text);
            komut.Parameters.AddWithValue("@p3", txtBparti.Text);
            komut.Parameters.AddWithValue("@p4", txtCparti.Text);
            komut.Parameters.AddWithValue("@p5", txtDparti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            frmGrafikler frm = new frmGrafikler();
            frm.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
