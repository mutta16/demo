using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Net.Mail;

namespace ATDsistemleri
{
    public partial class AyarPaneli : Form
    {
        public AyarPaneli()
        {
            InitializeComponent();
        }


        SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\AtdSistemleriDatabase.sdf");
        public string Kesici1;
        public string Kesici2;
        public string Kesici3;
        public string Kesici4;


        private void AyarPaneli_Load(object sender, EventArgs e)
        {
            
            
            btnKesici3.Visible = false;
            btnKesici4.Visible = false;
            keypad.Visible = false;

            SqlCeDataReader oku = null;
            SqlCeCommand komut=new SqlCeCommand("Select * from Adetler",baglanti);
            baglanti.Open();
            
            oku=komut.ExecuteReader();
            
            while (oku.Read())
            {
                chart1.Series["CEKMECE1"].Points.AddY(oku[0]);
            }
          

            /////////

            SqlCeDataReader oku2 = null;
            SqlCeCommand komut2 = new SqlCeCommand("Select * from Adetler2", baglanti);
          

            oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                chart1.Series["CEKMECE2"].Points.AddY(oku2[0]);
            }
            baglanti.Close();

            chart1.Series["CEKMECE1"].Points[0].AxisLabel = "ÇEKMECELER";




        }

        private void btnKesici1_Click(object sender, EventArgs e)
        {
            btnKesici2.Visible = false;
            btnKesici3.Visible = false;
            btnKesici4.Visible = false;
            keypad.Visible = true;

            try
            {
            
                SqlCeDataReader dr = null;// DATAREADER I SIFIRLA
                SqlCeCommand komut = new SqlCeCommand("select*from Adetler ", baglanti); //MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Kesici1 = dr["Kesici1"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 1 ADETİ ÇAĞIR
                    label1.Text = Kesici1.ToString(); // KESİCİ 1 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch
            {
                MessageBox.Show("KESİCİ 1 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnKesici2_Click(object sender, EventArgs e)
        {
            btnKesici1.Visible = false;
            btnKesici3.Visible = false;
            btnKesici4.Visible = false;
            keypad.Visible = true;


            try
            {

                SqlCeDataReader dr = null;// DATAREADER I SIFIRLA
                SqlCeCommand komut = new SqlCeCommand("select*from Adetler2 ", baglanti); //MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Kesici2 = dr["Kesici2"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 1 ADETİ ÇAĞIR
                    label1.Text = Kesici2.ToString(); // KESİCİ 1 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch
            {
                MessageBox.Show("KESİCİ 2 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKesici3_Click(object sender, EventArgs e)
        {
            btnKesici1.Visible = false;
            btnKesici2.Visible = false;
            btnKesici4.Visible = false;
            keypad.Visible = true;


            try
            {

                SqlCeDataReader dr = null;// DATAREADER I SIFIRLA
                SqlCeCommand komut = new SqlCeCommand("select*from Adetler3 ", baglanti); //MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Kesici3 = dr["Kesici3"].ToString(); //KESİCİ3 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 1 ADETİ ÇAĞIR
                    label1.Text = Kesici3.ToString(); // KESİCİ 3 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch
            {
                MessageBox.Show("KESİCİ 3 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKesici4_Click(object sender, EventArgs e)
        {
            btnKesici1.Visible = false;
            btnKesici2.Visible = false;
            btnKesici3.Visible = false;
            keypad.Visible = true;


            try
            {

                SqlCeDataReader dr = null;// DATAREADER I SIFIRLA
                SqlCeCommand komut = new SqlCeCommand("select*from Adetler4 ", baglanti); //MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Kesici4 = dr["Kesici4"].ToString(); //KESİCİ4 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 1 ADETİ ÇAĞIR
                    label1.Text = Kesici4.ToString(); // KESİCİ 4 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch
            {
                MessageBox.Show("KESİCİ 4 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AyarPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Close();
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            if(label2.Text=="00")
            {
                label2.Text = "";
                label2.Text += 1;
            }
            else
            {
                label2.Text += 1;
            }

            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 2;
            }
            else
            {
                label2.Text += 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 3;
            }
            else
            {
                label2.Text += 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 4;
            }
            else
            {
                label2.Text += 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 5;
            }
            else
            {
                label2.Text += 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 6;
            }
            else
            {
                label2.Text += 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 7;
            }
            else
            {
                label2.Text += 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 8;
            }
            else
            {
                label2.Text += 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 9;
            }
            else
            {
                label2.Text += 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00")
            {
                label2.Text = "";
                label2.Text += 0;
            }
            else
            {
                label2.Text += 0;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            label2.Text = "00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
                
            
            

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (btnKesici1.Visible==true)
            {
                try
                {
                SqlCeCommand sil = new SqlCeCommand("delete from Adetler", baglanti);
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();

                SqlCeCommand kaydet = new SqlCeCommand("insert into Adetler(Kesici1) values ('"+label2.Text.ToString()+"') ", baglanti);
                baglanti.Open();
                kaydet.ExecuteNonQuery();
                baglanti.Close();

                keypad.Visible = false;
                btnKesici1.Visible = true;
                btnKesici2.Visible = true;
                btnKesici3.Visible = false;
                btnKesici4.Visible = false;
                label2.Text = "00";
                label1.Text = "00";
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
            else if (btnKesici2.Visible == true)
            {

                try
                {
                    SqlCeCommand sil = new SqlCeCommand("delete from Adetler2", baglanti);
                    baglanti.Open();
                    sil.ExecuteNonQuery();
                    baglanti.Close();

                    SqlCeCommand kaydet = new SqlCeCommand("insert into Adetler2(Kesici2) values ('" + label2.Text.ToString() + "') ", baglanti);
                    baglanti.Open();
                    kaydet.ExecuteNonQuery();
                    baglanti.Close();

                    keypad.Visible = false;
                    btnKesici1.Visible = true;
                    btnKesici2.Visible = true;
                    btnKesici3.Visible = false;
                    btnKesici4.Visible = false;
                    label2.Text = "00";
                    label1.Text = "00";
                }
                catch (Exception)
                {
                    
                    throw;
                }
               
            }
            else if (btnKesici3.Visible == true)
            {
                try
                {
                    SqlCeCommand sil = new SqlCeCommand("delete from Adetler3", baglanti);
                    baglanti.Open();
                    sil.ExecuteNonQuery();
                    baglanti.Close();

                    SqlCeCommand kaydet = new SqlCeCommand("insert into Adetler3(Kesici3) values ('" + label2.Text.ToString() + "') ", baglanti);
                    baglanti.Open();
                    kaydet.ExecuteNonQuery();
                    baglanti.Close();

                    keypad.Visible = false;
                    btnKesici1.Visible = true;
                    btnKesici2.Visible = true;
                    btnKesici3.Visible = true;
                    btnKesici4.Visible = true;
                    label2.Text = "00";
                    label1.Text = "00";
                }
                catch (Exception)
                {
                    
                    throw;
                }

              
            }
            else if (btnKesici4.Visible == true)
            {
                try
                {
                    SqlCeCommand sil = new SqlCeCommand("delete from Adetler4", baglanti);
                    baglanti.Open();
                    sil.ExecuteNonQuery();
                    baglanti.Close();

                    SqlCeCommand kaydet = new SqlCeCommand("insert into Adetler4(Kesici4) values ('" + label2.Text.ToString() + "') ", baglanti);
                    baglanti.Open();
                    kaydet.ExecuteNonQuery();
                    baglanti.Close();

                    keypad.Visible = false;
                    btnKesici1.Visible = true;
                    btnKesici2.Visible = true;
                    btnKesici3.Visible = true;
                    btnKesici4.Visible = true;
                    label2.Text = "00";
                    label1.Text = "00";
                }
                catch (Exception)
                {

                    throw;
                }
            }







            
            chart1.Series["CEKMECE1"].Points.Clear();
            chart1.Series["CEKMECE2"].Points.Clear();
            /////////////////////////////


            btnKesici3.Visible = false;
            btnKesici4.Visible = false;
            keypad.Visible = false;

            SqlCeDataReader oku = null;
            SqlCeCommand komut = new SqlCeCommand("Select * from Adetler", baglanti);
            baglanti.Open();

            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                chart1.Series["CEKMECE1"].Points.AddY(oku[0]);
            }


            /////////

            SqlCeDataReader oku2 = null;
            SqlCeCommand komut2 = new SqlCeCommand("Select * from Adetler2", baglanti);


            oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                chart1.Series["CEKMECE2"].Points.AddY(oku2[0]);
            }
            baglanti.Close();

            chart1.Update();

            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            try
            {
                LogPaneli formac = new LogPaneli();
                formac.ShowDialog();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void btnRaporPersonel_Click(object sender, EventArgs e)
        {
            try
            {
                uyeRaporPaneli formac = new uyeRaporPaneli();
                formac.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
        

      

   
    }
}
