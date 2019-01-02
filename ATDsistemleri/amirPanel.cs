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

namespace ATDsistemleri
{
    public partial class amirPanel : Form
    {
        public amirPanel()
        {
            InitializeComponent();
        }

        SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\AtdSistemleriDatabase.sdf");
        public string Kesici1;
        public string Kesici2;
        public string Kesici3;
        public string Kesici4;

        public string KartNo;
        public string KimlikNo;
        public string Ad;
        public string Soyad;
        public string Pozisyon;

        private void amirPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atdSistemleriDatabaseDataSet.Loglar' table. You can move, or remove it, as needed.
            this.loglarTableAdapter.Fill(this.atdSistemleriDatabaseDataSet.Loglar);
            label6.Visible=false;
            button3.Visible=false;
            lblAdet3.Visible=false;
            btnKesici4.Visible=false;
            label8.Visible=false;
            lblAdet4.Visible = false;


            
            try
            {
                label2.Text = "Hoşgeldin " + Form1.AdGonder.ToString(); //FORM1 DEN AÇILAN YENİ FORMA İSİM YAZABİLMEK İÇİN VERİ ALDIK
                SqlCeDataReader dr = null;// DATAREADER I SIFIRLA
                SqlCeCommand komut = new SqlCeCommand("select*from Adetler ", baglanti); //MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Kesici1 = dr["Kesici1"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 1 ADETİ ÇAĞIR
                    lblAdet1.Text = Kesici1.ToString(); // KESİCİ 1 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch
            {
                MessageBox.Show("KESİCİ 1 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //slabel1.Text = Form1.idNogonder.ToString();




            //////////////                          KESİCİ 2 İŞLEMLERİ                              ///////////////////////////
            try
            {
                SqlCeDataReader dr = null;
                SqlCeCommand komut = new SqlCeCommand("select * from Adetler2", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Kesici2 = dr["Kesici2"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 2 ADETİ ÇAĞIR
                    lblAdet2.Text = Kesici2.ToString(); // KESİCİ 2 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 2 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //////////////                          KESİCİ 3 İŞLEMLERİ                              ///////////////////////////
            try
            {
                SqlCeDataReader dr = null;
                SqlCeCommand komut = new SqlCeCommand("select * from Adetler3", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Kesici3 = dr["Kesici3"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 3 ADETİ ÇAĞIR
                    lblAdet3.Text = Kesici3.ToString(); // KESİCİ 3 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 3 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //////////////                          KESİCİ 4 İŞLEMLERİ                              ///////////////////////////
            try
            {
                SqlCeDataReader dr4 = null;
                SqlCeCommand komut4 = new SqlCeCommand("select * from Adetler4", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr4 = komut4.ExecuteReader();

                while (dr4.Read())
                {
                    Kesici4 = dr4["Kesici4"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 4 ADETİ ÇAĞIR
                    lblAdet4.Text= Kesici4.ToString(); // KESİCİ 4 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 4 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            


           

        }

        private void amirPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglanti.Close();
        }

        private void btnKesici1_Click(object sender, EventArgs e)
        {

            int Azalt = 0;
            int islem;
            Int32.TryParse(Kesici1, out Azalt); //KESİCİ1 STRİNG DEĞİŞKENİNİ İNT 'A ÇEVİRME İŞLEMİ
            islem = Azalt - 1;
            SqlCeCommand sil = new SqlCeCommand("delete  from Adetler", baglanti); // SQL DEKİ KESİCİ1 TABLOSUNU SİL
            try
            {
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ1 ADET BİLGİSİ SİLİNİRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                SqlCeCommand yaz = new SqlCeCommand("insert into Adetler values ('" + islem + "')", baglanti);//SQL DEKİ KESİCİ1 TABLOSUNA 1 EKSİLTİMİŞ VERİYİ YAZ
                baglanti.Open();
                yaz.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ1 ADET BİLGİSİ YAZILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string yorum="Kesici1 çekmecesi açıldı";
                SqlCeCommand logyaz=new SqlCeCommand("insert into Loglar (KartNo,KimlikNo,Ad,Soyad,Pozisyon,Tarih,İslem) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",baglanti);
                baglanti.Open();
                logyaz.Parameters.AddWithValue("@p1",Form1.idNogonder.ToString());
                logyaz.Parameters.AddWithValue("@p2",Form1.KimlikNoGonder.ToString());
                logyaz.Parameters.AddWithValue("@p3", Form1.AdGonder.ToString());
                logyaz.Parameters.AddWithValue("@p4", Form1.SoyadGonder.ToString());
                logyaz.Parameters.AddWithValue("@p5",Form1.PozisyonGonder.ToString());
                logyaz.Parameters.AddWithValue("@p6", DateTime.Now);
                logyaz.Parameters.AddWithValue("@p7", yorum.ToString());
                logyaz.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("LOGLAR YAZILIRKEN HATA OLUŞTU");
            }
           

            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close(); //İŞLEM YAPMADAN ÇIKIŞ YAP
        }

        private void btnKesici2_Click(object sender, EventArgs e)
        {

            C2Adet formac = new C2Adet();
            formac.ShowDialog();
            /*
            int adet;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";

            }
            adet=Convert.ToInt16(textBox1.Text);
            
            int Azalt = 0;
            int islem;
            Int32.TryParse(Kesici2, out Azalt); //KESİCİ1 STRİNG DEĞİŞKENİNİ İNT 'A ÇEVİRME İŞLEMİ
            islem = Azalt - adet;
            SqlCeCommand sil = new SqlCeCommand("delete  from Adetler2", baglanti); // SQL DEKİ KESİCİ1 TABLOSUNU SİL
            try
            {
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ2 ADET BİLGİSİ SİLİNİRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                SqlCeCommand yaz = new SqlCeCommand("insert into Adetler2 values ('" + islem + "')", baglanti);//SQL DEKİ KESİCİ1 TABLOSUNA 1 EKSİLTİMİŞ VERİYİ YAZ
                baglanti.Open();
                yaz.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ2 ADET BİLGİSİ YAZILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            try
            {
                string yorum = "Kesici2 çekmecesi açıldı";
                SqlCeCommand logyaz = new SqlCeCommand("insert into Loglar (KartNo,KimlikNo,Ad,Soyad,Pozisyon,Tarih,İslem) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                baglanti.Open();
                logyaz.Parameters.AddWithValue("@p1", Form1.idNogonder.ToString());
                logyaz.Parameters.AddWithValue("@p2", Form1.KimlikNoGonder.ToString());
                logyaz.Parameters.AddWithValue("@p3", Form1.AdGonder.ToString());
                logyaz.Parameters.AddWithValue("@p4", Form1.SoyadGonder.ToString());
                logyaz.Parameters.AddWithValue("@p5", Form1.PozisyonGonder.ToString());
                logyaz.Parameters.AddWithValue("@p6", DateTime.Now);
                logyaz.Parameters.AddWithValue("@p7", yorum.ToString());
                logyaz.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("LOGLAR YAZILIRKEN HATA OLUŞTU");
            }*/


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Azalt = 0;
            int islem;
            Int32.TryParse(Kesici3, out Azalt); //KESİCİ1 STRİNG DEĞİŞKENİNİ İNT 'A ÇEVİRME İŞLEMİ
            islem = Azalt - 1;
            SqlCeCommand sil = new SqlCeCommand("delete  from Adetler3", baglanti); // SQL DEKİ KESİCİ1 TABLOSUNU SİL
            try
            {
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ3 ADET BİLGİSİ SİLİNİRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                SqlCeCommand yaz = new SqlCeCommand("insert into Adetler3 values ('" + islem + "')", baglanti);//SQL DEKİ KESİCİ1 TABLOSUNA 1 EKSİLTİMİŞ VERİYİ YAZ
                baglanti.Open();
                yaz.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ3 ADET BİLGİSİ YAZILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string yorum = "Kesici3 çekmecesi açıldı";
                SqlCeCommand logyaz = new SqlCeCommand("insert into Loglar (KartNo,KimlikNo,Ad,Soyad,Pozisyon,Tarih,İslem) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                baglanti.Open();
                logyaz.Parameters.AddWithValue("@p1", Form1.idNogonder.ToString());
                logyaz.Parameters.AddWithValue("@p2", Form1.KimlikNoGonder.ToString());
                logyaz.Parameters.AddWithValue("@p3", Form1.AdGonder.ToString());
                logyaz.Parameters.AddWithValue("@p4", Form1.SoyadGonder.ToString());
                logyaz.Parameters.AddWithValue("@p5", Form1.PozisyonGonder.ToString());
                logyaz.Parameters.AddWithValue("@p6", DateTime.Now);
                logyaz.Parameters.AddWithValue("@p7", yorum.ToString());
                logyaz.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("LOGLAR YAZILIRKEN HATA OLUŞTU");
            }
        }

        private void btnKesici4_Click(object sender, EventArgs e)
        {
            int Azalt = 0;
            int islem;
            Int32.TryParse(Kesici4, out Azalt); //KESİCİ1 STRİNG DEĞİŞKENİNİ İNT 'A ÇEVİRME İŞLEMİ
            islem = Azalt - 1;
            SqlCeCommand sil = new SqlCeCommand("delete  from Adetler4", baglanti); // SQL DEKİ KESİCİ1 TABLOSUNU SİL
            try
            {
                baglanti.Open();
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ4 ADET BİLGİSİ SİLİNİRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                SqlCeCommand yaz = new SqlCeCommand("insert into Adetler4 values ('" + islem + "')", baglanti);//SQL DEKİ KESİCİ1 TABLOSUNA 1 EKSİLTİMİŞ VERİYİ YAZ
                baglanti.Open();
                yaz.ExecuteNonQuery();
                baglanti.Close();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ4 ADET BİLGİSİ YAZILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string yorum = "Kesici4 çekmecesi açıldı";
                SqlCeCommand logyaz = new SqlCeCommand("insert into Loglar (KartNo,KimlikNo,Ad,Soyad,Pozisyon,Tarih,İslem) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                baglanti.Open();
                logyaz.Parameters.AddWithValue("@p1", Form1.idNogonder.ToString());
                logyaz.Parameters.AddWithValue("@p2", Form1.KimlikNoGonder.ToString());
                logyaz.Parameters.AddWithValue("@p3", Form1.AdGonder.ToString());
                logyaz.Parameters.AddWithValue("@p4", Form1.SoyadGonder.ToString());
                logyaz.Parameters.AddWithValue("@p5", Form1.PozisyonGonder.ToString());
                logyaz.Parameters.AddWithValue("@p6", DateTime.Now);
                logyaz.Parameters.AddWithValue("@p7", yorum.ToString());
                logyaz.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("LOGLAR YAZILIRKEN HATA OLUŞTU");
            }
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            AyarPaneli formac = new AyarPaneli();
            try
            {
                formac.ShowDialog();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void amirPanel_Activated(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "Hoşgeldin " + Form1.AdGonder.ToString(); //FORM1 DEN AÇILAN YENİ FORMA İSİM YAZABİLMEK İÇİN VERİ ALDIK
                SqlCeDataReader dr = null;// DATAREADER I SIFIRLA
                SqlCeCommand komut = new SqlCeCommand("select*from Adetler ", baglanti); //MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    Kesici1 = dr["Kesici1"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 1 ADETİ ÇAĞIR
                    lblAdet1.Text = Kesici1.ToString(); // KESİCİ 1 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch
            {
                MessageBox.Show("KESİCİ 1 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //slabel1.Text = Form1.idNogonder.ToString();




            //////////////                          KESİCİ 2 İŞLEMLERİ                              ///////////////////////////
            try
            {
                SqlCeDataReader dr = null;
                SqlCeCommand komut = new SqlCeCommand("select * from Adetler2", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Kesici2 = dr["Kesici2"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 2 ADETİ ÇAĞIR
                    lblAdet2.Text = Kesici2.ToString(); // KESİCİ 2 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 2 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //////////////                          KESİCİ 3 İŞLEMLERİ                              ///////////////////////////
            try
            {
                SqlCeDataReader dr = null;
                SqlCeCommand komut = new SqlCeCommand("select * from Adetler3", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Kesici3 = dr["Kesici3"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 3 ADETİ ÇAĞIR
                    lblAdet3.Text = Kesici3.ToString(); // KESİCİ 3 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 3 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //////////////                          KESİCİ 4 İŞLEMLERİ                              ///////////////////////////
            try
            {
                SqlCeDataReader dr4 = null;
                SqlCeCommand komut4 = new SqlCeCommand("select * from Adetler4", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr4 = komut4.ExecuteReader();

                while (dr4.Read())
                {
                    Kesici4 = dr4["Kesici4"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 4 ADETİ ÇAĞIR
                    lblAdet4.Text = Kesici4.ToString(); // KESİCİ 4 ADET LABELINA VERİYİ YAZ


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 4 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

      
                
        

        
    }
}
