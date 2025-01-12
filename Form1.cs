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
    public partial class Form1 : Form
        {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6N5IK50;Initial Catalog=deneme;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'denemeDataSet.COSTUMERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cOSTUMERSTableAdapter.Fill(this.denemeDataSet.COSTUMERS);
            // TODO: Bu kod satırı 'denemeDataSet.COSTUMERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cOSTUMERSTableAdapter.Fill(this.denemeDataSet.COSTUMERS);

        }

        private void tabloyuGosterButton_Click(object sender, EventArgs e)
        {
            this.cOSTUMERSTableAdapter.Fill(this.denemeDataSet.COSTUMERS);
        }

        private void yeniKisiEkleButton_Click(object sender, EventArgs e)
        {
            string durum = "Yabancı";
            baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO COSTUMERS(COSTOMERNAME, CITY, BIRTHDATE, DISTRICT, GENDER , NATION, AGE) VALUES (@name,@city,@birth,@dist,@gender,@nation,@age)",baglan);
            //SqlCommand komut2 = new SqlCommand("UPDATE COSTUMERS SET AGE = DATEDIFF(YEAR, BIRTHDATE, GETDATE()) ,@age)",baglan);
            komut.Parameters.AddWithValue("@name", nameTextBox.Text);
            komut.Parameters.AddWithValue("@city", cityTextBox2.Text);
            komut.Parameters.AddWithValue("@birth", Convert.ToDateTime(birthTextBox3.Text));
            komut.Parameters.AddWithValue("@dist", distTextBox4.Text);
            komut.Parameters.AddWithValue("@gender", genderTextBox5.Text);
            komut.Parameters.AddWithValue("@age", ageTextBox7.Text);
            //komut2.Parameters.AddWithValue("@age", ageTextBox7.Text);

            if (TRradioButton1.Checked)
            {
                durum = "Türk";
            }
            if (YabanciradioButton2.Checked)
            {
                durum = "Yabancı";
            }
            komut.Parameters.AddWithValue("@nation", durum);
            komut.ExecuteNonQuery();
            baglan.Close();
            this.cOSTUMERSTableAdapter.Fill(this.denemeDataSet.COSTUMERS);//ekledikten sonra ekrana yazsın
            MessageBox.Show("Kişi Eklendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string durum;
            int secilenSatir;

            secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            IDlabel.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            nameTextBox.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            cityTextBox2.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            birthTextBox3.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            distTextBox4.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            genderTextBox5.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();
            durum = dataGridView1.Rows[secilenSatir].Cells[6].Value.ToString();
            ageTextBox7.Text = dataGridView1.Rows[secilenSatir].Cells[7].Value.ToString();
            
            if (durum == "Türk")
            {
                TRradioButton1.Checked = true;
            }
            if (durum == "Yabancı")
            {
                YabanciradioButton2.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand silkomut = new SqlCommand("DELETE FROM COSTUMERS WHERE ID = @id",baglan);
            silkomut.Parameters.AddWithValue("@id", IDlabel.Text);
            silkomut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kişi silindi");
            this.cOSTUMERSTableAdapter.Fill(this.denemeDataSet.COSTUMERS);//sildikten sonra ekrana yazsın
        }
        private void guncelleButton_Click_1(object sender, EventArgs e)
        {
            string durum = "Yabancı";
            baglan.Open();         
            SqlCommand guncelleKomut = new SqlCommand("UPDATE COSTUMERS SET COSTOMERNAME=@name ,CITY=@city , BIRTHDATE=@birth , DISTRICT=@dist , GENDER=@gender, NATION=@nation, AGE=@age WHERE ID=@id", baglan);
            guncelleKomut.Parameters.AddWithValue("@name", nameTextBox.Text);
            guncelleKomut.Parameters.AddWithValue("@city", cityTextBox2.Text);
            guncelleKomut.Parameters.AddWithValue("@birth", Convert.ToDateTime(birthTextBox3.Text));
            guncelleKomut.Parameters.AddWithValue("@dist", distTextBox4.Text);
            guncelleKomut.Parameters.AddWithValue("@gender", genderTextBox5.Text);
            guncelleKomut.Parameters.AddWithValue("@age", ageTextBox7.Text);

            if (TRradioButton1.Checked == true)
            {
                durum = "Türk";
            }
            if (YabanciradioButton2.Checked == true)
            {
                durum = "Yabancı";
            }

            guncelleKomut.Parameters.AddWithValue("@nation",durum);
            guncelleKomut.Parameters.AddWithValue("@id", IDlabel.Text);
            guncelleKomut.ExecuteNonQuery();
            baglan.Close(); 
            MessageBox.Show("kişi güncellendi");
            this.cOSTUMERSTableAdapter.Fill(this.denemeDataSet.COSTUMERS);//güncelledikten sonra ekrana yazsın
          
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            IDlabel.Text = "";
            nameTextBox.Text = "";
            cityTextBox2.Text = "";
            birthTextBox3.Text = "";
            distTextBox4.Text = "";
            genderTextBox5.Text = "";
            ageTextBox7.Text = "";
            TRradioButton1.Checked = false;
            YabanciradioButton2.Checked = false;
            nameTextBox.Focus();

        }
        private void istatislikButton_Click(object sender, EventArgs e)
        {
            Istatislik istform = new Istatislik();
            istform.Show();
        }
        private void SehirGrafikButton_Click(object sender, EventArgs e)
        {
            Grafik grafikform = new Grafik();
            grafikform.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length < 2)
            {
                dataGridView1.DataSource = denemeDataSet.COSTUMERS;
                return;
            }
                

            denemeDataSet dt = new denemeDataSet();
            denemeDataSet.COSTUMERSRow[] drRow = (denemeDataSet.COSTUMERSRow[])denemeDataSet.COSTUMERS.Select("COSTOMERNAME LIKE '%" + txtSearch.Text+"%'");
            dt.Merge(drRow);

            //this.cOSTUMERSTableAdapter.Fill(dt.COSTUMERS); //.Where(x => x["COSTOMERNAME"] ));
            dataGridView1.DataSource = dt.COSTUMERS;
        }
    }
}