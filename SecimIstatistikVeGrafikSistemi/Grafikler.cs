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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TFCL3EH;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void Grafikler_Load(object sender, EventArgs e)
        {
            //İlçe adlarını combobox'a çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEADI From TBLSECIM", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            baglanti.Close();

            //Grafiğe toplam sonuçları getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(MUZPARTISI),SUM(KARPUZPARTISI),SUM(LIMONPARTISI),SUM(KIVIPARTISI),SUM(CEVIZPARTISI) from TBLSECIM", baglanti);
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("MUZ PARTİSİ", reader2[0]);
                chart1.Series["Partiler"].Points.AddXY("KARPUZ PARTİSİ", reader2[1]);
                chart1.Series["Partiler"].Points.AddXY("LIMON PARTİSİ", reader2[2]);
                chart1.Series["Partiler"].Points.AddXY("KIVI PARTİSİ", reader2[3]);
                chart1.Series["Partiler"].Points.AddXY("CEVIZ PARTİSİ", reader2[4]);
            }
            baglanti.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLSECIM where ILCEADI=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                progressBar1.Value = int.Parse(reader[2].ToString());
                progressBar2.Value = int.Parse(reader[3].ToString());
                progressBar3.Value = int.Parse(reader[4].ToString());
                progressBar4.Value = int.Parse(reader[5].ToString());
                progressBar5.Value = int.Parse(reader[6].ToString());

                lblmuz.Text = reader[2].ToString();
                lblkarpuz.Text = reader[3].ToString();
                lbllimon.Text = reader[4].ToString();
                lblkivi.Text = reader[5].ToString();
                lblceviz .Text = reader[6].ToString();
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
