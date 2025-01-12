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
    public partial class Istatislik : Form
    {
        SqlConnection baglan2 = new SqlConnection("Data Source=DESKTOP-6N5IK50;Initial Catalog=deneme;Integrated Security=True");
        public Istatislik()
        {
            InitializeComponent();
        }

        private void Istatislik_Load(object sender, EventArgs e)
        {
            //insan sayısı
            baglan2.Open();
            SqlCommand insanTopKomut = new SqlCommand("select count(*) from COSTUMERS",baglan2);           
            SqlDataReader dr1 = insanTopKomut.ExecuteReader();//üst sınıfa erişen bir nesne, bu nesne üst sınıftan veri okuyor
            while (dr1.Read())
            {
                insanLbel.Text = dr1[0].ToString();
            }
            baglan2.Close();

            //şehir sayısı
            baglan2.Open();
            SqlCommand sehirTopKomut = new SqlCommand("select count(distinct(CITY)) from COSTUMERS", baglan2);
            SqlDataReader dr2 = sehirTopKomut.ExecuteReader();
            while (dr2.Read())
            {
                sehirLabel.Text = dr2[0].ToString();
            }
            baglan2.Close();

            //ilçe sayısı
            baglan2.Open();
            SqlCommand ilceTopKomut = new SqlCommand("select count(distinct(DISTRICT)) from COSTUMERS", baglan2);
            SqlDataReader dr3 = ilceTopKomut.ExecuteReader();
            while (dr3.Read())
            {
                ilceLabel.Text = dr3[0].ToString();
            }
            baglan2.Close();

            //turk sayısı
            baglan2.Open();
            SqlCommand turkTopKomut = new SqlCommand("select count(*) from COSTUMERS where NATION ='Türk'", baglan2);
            SqlDataReader dr4 = turkTopKomut.ExecuteReader();
            while (dr4.Read())
            {
                turkLabel.Text = dr4[0].ToString();
            }
            baglan2.Close();

            //yabancı sayısı
            baglan2.Open();
            SqlCommand yabancıTopKomut = new SqlCommand("select count(*) from COSTUMERS where NATION ='Yabancı'", baglan2);
            SqlDataReader dr5 = yabancıTopKomut.ExecuteReader();
            while (dr5.Read())
            {
                yabancıLabel.Text = dr5[0].ToString();
            }
            baglan2.Close();          
        }      
    }
}
