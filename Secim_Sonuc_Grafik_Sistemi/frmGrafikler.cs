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
    public partial class frmGrafikler : Form
    {
        public frmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENES\MSSQLSERVER01;Initial Catalog=SecimSonuc;Integrated Security=True");
        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            //İlçe Adlarını ComboBoxa çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ilceAd from tbl_ilce",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbBoxIlce.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiklere TOPLAM sonucları getirme

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(AParti),SUM(BParti),SUM(CParti),SUM(Dparti) from tbl_ilce",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                chartSecimSonuc.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chartSecimSonuc.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chartSecimSonuc.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chartSecimSonuc.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
            }
            baglanti.Close();
        }

        private void cmbBoxIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select *from tbl_ilce where ilceAd=@p1",baglanti);
            komut3.Parameters.AddWithValue("p1", cmbBoxIlce.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                progressBarA.Value = int.Parse(dr3[2].ToString());
                progressBarB.Value = int.Parse(dr3[3].ToString());
                progressBarC.Value = int.Parse(dr3[4].ToString());
                progressBarD.Value = int.Parse(dr3[5].ToString());

                lblAparti.Text = dr3[2].ToString();
                lblBparti.Text = dr3[3].ToString();
                lblCparti.Text = dr3[4].ToString();
                lblDparti.Text = dr3[5].ToString();
            }
            baglanti.Close();
        }
    }
}
