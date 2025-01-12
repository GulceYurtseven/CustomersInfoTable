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

namespace customers
{
    public partial class Grafik : Form
    {
        SqlConnection baglan3 = new SqlConnection("Data Source=DESKTOP-6N5IK50;Initial Catalog=deneme;Integrated Security=True");
        public Grafik()
        {
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            //şehir garfiği
            baglan3.Open();
            SqlCommand sehirGrafikKomut = new SqlCommand("SELECT CITY, COUNT(*) FROM COSTUMERS GROUP BY CITY", baglan3);
            SqlDataReader dr6 = sehirGrafikKomut.ExecuteReader();
            while (dr6.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr6[0], dr6[1]);
            }
            baglan3.Close();

            //ilçe grafiği
            baglan3.Open();
            SqlCommand ilceGrafikKomut = new SqlCommand("SELECT DISTRICT, COUNT(*) FROM COSTUMERS GROUP BY DISTRICT", baglan3);
            SqlDataReader dr7 = ilceGrafikKomut.ExecuteReader();
            while (dr7.Read())
            {
                chart2.Series["İlçeler"].Points.AddXY(dr7[0], dr7[1]);
            }
            baglan3.Close();
        }

    }
}
