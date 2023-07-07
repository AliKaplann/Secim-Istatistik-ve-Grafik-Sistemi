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

namespace SecimIstatistikVeGrafikSistemi
{
    public partial class OyGiris : Form
    {
        public OyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-TFCL3EH;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void btnoygiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSECIM (ILCEADI,MUZPARTISI,KARPUZPARTISI,LIMONPARTISI,KIVIPARTISI,CEVIZPARTISI) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtilcead.Text);
            komut.Parameters.AddWithValue("@p2", txtmuz.Text);
            komut.Parameters.AddWithValue("@p3", txtkarpuz.Text);
            komut.Parameters.AddWithValue("@p4", txtlimon.Text);
            komut.Parameters.AddWithValue("@p5", txtkivi.Text);
            komut.Parameters.AddWithValue("@p6", txtceviz.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");
        }
        private void btngrafikler_Click(object sender, EventArgs e)
        {
            Grafikler grafik = new Grafikler();
            grafik.Show();
        }
    }
}
