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

namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();
        bool durum;
        bool durum1;
        private void Kayıt_Engelle()
        {
            durum = true;
            durum1 = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Karma ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtAdSoyad.Text==read["AdSoyad"].ToString())
                {
                    durum = false;
                }
                if (txtAdSoyad.Text == "")
                {
                    durum1 = false;
                }
            }
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayıt_Engelle();
            if (durum1 == false)
            {
                MessageBox.Show("Lütfen Ad Soyad alanını doldurunuz", "Uyarı!");
                return;
            }
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("set dateformat dmy insert into Karma(Model,AdSoyad,Arıza,MusteriTel,IMEI,TelefonSifresi,Ucret,UcretAlınma,Tarih,Acıklama,TeslimDurumu) values(@Model,@AdSoyad,@Arıza,@MusteriTel,@IMEI,@TelefonSifresi,@Ucret,@UcretAlınma,@Tarih,@Acıklama,@TeslimDurumu)", baglanti);
                komut.Parameters.AddWithValue("@Model", txtModel.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Arıza", TxtArıza.Text);
                komut.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut.Parameters.AddWithValue("@IMEI", txtIMEI.Text);
                komut.Parameters.AddWithValue("@TelefonSifresi", txtTelefonSifresi.Text);
                komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
                komut.Parameters.AddWithValue("@UcretAlınma", comboUcret.Text);
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@Acıklama", rtxtAcıklama.Text);
                komut.Parameters.AddWithValue("@TeslimDurumu", comboTeslimDurumu.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["Karma"].Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from Karma", baglanti);
                adtr.Fill(daset, "Karma");
                dataGridView1.DataSource = daset.Tables["Karma"];
                MessageBox.Show("Müşteri Kaydı Eklendi");
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                        rtxtAcıklama.Text = "";
                        txtUcret.Text = "0₺";
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Bu isimde bir müşteri zaten var","Uyarı!");
            }
            
            
        }

        private void Kayıt_Göster()
        {
            
            
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from Karma", baglanti);
                adtr.Fill(daset, "Karma");
                dataGridView1.DataSource = daset.Tables["Karma"];
                baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Karma where MusteriID='" + dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["Karma"].Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from Karma", baglanti);
                adtr.Fill(daset, "Karma");
                dataGridView1.DataSource = daset.Tables["Karma"];
                MessageBox.Show("Kayıt Silindi");
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                        rtxtAcıklama.Text = "";
                        txtUcret.Text = "0₺";
                    }
                }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriID.Text = dataGridView1.CurrentRow.Cells["MusteriID"].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            TxtArıza.Text = dataGridView1.CurrentRow.Cells["Arıza"].Value.ToString();
            txtMusteriTel.Text = dataGridView1.CurrentRow.Cells["MusteriTel"].Value.ToString();
            txtIMEI.Text = dataGridView1.CurrentRow.Cells["IMEI"].Value.ToString();
            txtTelefonSifresi.Text = dataGridView1.CurrentRow.Cells["TelefonSifresi"].Value.ToString();
            txtUcret.Text = dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString();
            comboUcret.Text = dataGridView1.CurrentRow.Cells["UcretAlınma"].Value.ToString();
            rtxtAcıklama.Text = dataGridView1.CurrentRow.Cells["Acıklama"].Value.ToString();
            comboTeslimDurumu.Text = dataGridView1.CurrentRow.Cells["TeslimDurumu"].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Karma ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtMusteriID.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("update Karma set AdSoyad=@AdSoyad,Model=@Model,Arıza=@Arıza,MusteriTel=@MusteriTel,IMEI=@IMEI,Telefonsifresi=@TelefonSifresi,Ucret=@Ucret,UcretAlınma=@UcretAlınma,Acıklama=@Acıklama,TeslimDurumu=@TeslimDurumu where AdSoyad=@AdSoyad", baglanti);
                komut1.Parameters.AddWithValue("@Model", txtModel.Text);
                komut1.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut1.Parameters.AddWithValue("@Arıza", TxtArıza.Text);
                komut1.Parameters.AddWithValue("@MusteriTel", txtMusteriTel.Text);
                komut1.Parameters.AddWithValue("@IMEI", txtIMEI.Text);
                komut1.Parameters.AddWithValue("@TelefonSifresi", txtTelefonSifresi.Text);
                komut1.Parameters.AddWithValue("@Ucret", txtUcret.Text);
                komut1.Parameters.AddWithValue("@UcretAlınma", comboUcret.Text);
                komut1.Parameters.AddWithValue("@Acıklama", rtxtAcıklama.Text);
                komut1.Parameters.AddWithValue("@TeslimDurumu", comboTeslimDurumu.Text);
                komut1.ExecuteNonQuery();
                daset.Tables["Karma"].Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from Karma", baglanti);
                adtr.Fill(daset, "Karma");
                dataGridView1.DataSource = daset.Tables["Karma"];
                baglanti.Close();
                MessageBox.Show("Müşteri Kaydı Güncellendi");
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                        rtxtAcıklama.Text = "";
                        txtUcret.Text = "0₺";
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz","Uyarı!");
                 
            }
     
        }

        private void txtAdSoyadAra_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                    rtxtAcıklama.Text = "";
                    txtUcret.Text = "0₺";
                }



            }
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtUcret.Text = "0$";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtUcret.Text = "0₺";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable tablo1 = new DataTable();
            DataTable tablo2 = new DataTable();
            DataTable tablo3 = new DataTable();
            baglanti.Open();
            if (comboBox1.Text!=""&&comboBox2.Text!="")
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select *from Karma where UcretAlınma='" + comboBox1.Text + "' and TeslimDurumu='"+comboBox2.Text+"'", baglanti);
                adtr.Fill(tablo1);
                dataGridView1.DataSource = tablo1;
            }
            if (txtAdSoyad.Text!="")
            {

                SqlDataAdapter adtr2 = new SqlDataAdapter("select *from Karma where AdSoyad like '%" + txtAdSoyadAra.Text + "%'", baglanti);
                adtr2.Fill(tablo2);
                dataGridView1.DataSource = tablo2;
            }
            if (txtMusteriIDAra.Text!="")
            {
                SqlDataAdapter adtr3 = new SqlDataAdapter("select *from Karma where MusteriID like '%" + txtMusteriIDAra.Text + "%'", baglanti);
                adtr3.Fill(tablo3);
                dataGridView1.DataSource = tablo3;
               
            }
            baglanti.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            daset.Tables["Karma"].Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Karma", baglanti);
            adtr.Fill(daset, "Karma");
            dataGridView1.DataSource = daset.Tables["Karma"];
            baglanti.Close();
        }
    }
}
