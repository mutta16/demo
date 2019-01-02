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
using System.Net.Mail;

namespace ATDsistemleri
{
    public partial class C2Adet : Form
    {
        public C2Adet()
        {
            InitializeComponent();
        }

        private int ADET;


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






        private void C2Adet_Load(object sender, EventArgs e)
        {
             ADET = 0;
            textBox1.Text = ADET.ToString();


            try
            {
                SqlCeDataReader dr = null;
                SqlCeCommand komut = new SqlCeCommand("select * from Adetler2", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                baglanti.Open();
                dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Kesici2 = dr["Kesici2"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 2 ADETİ ÇAĞIR
                    


                }
                baglanti.Close(); //BAĞLANTIYI KAPAT

            }
            catch (Exception)
            {

                MessageBox.Show("KESİCİ 2 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADET = ADET + 1;
            textBox1.Text = ADET.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADET = ADET - 1;
            textBox1.Text = ADET.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ADET == 0)
            {
                button2.Visible = false;
            }
            else
            {
                button2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";

            }
            if (ADET == 0)
            {
                MessageBox.Show("MİKTAR GİRMELİSİNİZ.'0' SEÇİLEMEZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Azalt = 0;
                int islem;
                Int32.TryParse(Kesici2, out Azalt); //KESİCİ1 STRİNG DEĞİŞKENİNİ İNT 'A ÇEVİRME İŞLEMİ
                islem = Azalt - ADET;
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
            /////////////////////////////////
                try
                {
                    SqlCeDataReader dr = null;
                    SqlCeCommand komut = new SqlCeCommand("select * from Adetler2", baglanti);//MEVCUT ÇEKMECE İÇİNDEKİ ADETİ ÇAĞIR
                    baglanti.Open();
                    dr = komut.ExecuteReader();

                    while (dr.Read())
                    {
                        Kesici2 = dr["Kesici2"].ToString(); //KESİCİ1 DEĞİŞKENİNİN İÇERİSİNE SQL DEN KESİCİ 2 ADETİ ÇAĞIR
                        


                    }
                    baglanti.Close(); //BAĞLANTIYI KAPAT

                }
                catch (Exception)
                {

                    MessageBox.Show("KESİCİ 2 VERİLER AÇILIRKEN HATA OLUŞTU.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                try
                {
                    int Mkesici2;
                    Int32.TryParse(Kesici2, out Mkesici2);

                    if (Mkesici2 <= 15)
                    {
                        MailMessage mesaj = new MailMessage();
                        SmtpClient istemci = new SmtpClient();
                        istemci.Credentials = new System.Net.NetworkCredential("bilgi@atdsistemleri.com", "Bm.264816");
                        istemci.Port = 587;
                        istemci.Host = "revolver.guzelhosting.com";
                        istemci.EnableSsl = false;

                        mesaj.To.Add("mkayali@atdsistemleri.com");
                        mesaj.From = new MailAddress("bilgi@atdsistemleri.com");
                        mesaj.Subject = "SİPARİŞ BİLGİLENDİRME MAİLİ ÇEKMECE2";
                        mesaj.Body = "Merhaba! Çekmece2 için stok sayısı kritik seviyeye düşmüştür."+'\n'+"Sipariş geçmelisiniz.İyi Günler."+'\n'+"Kesici Güncel Adeti : "+Mkesici2;
                        istemci.Send(mesaj);
                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("MAİL GÖNDERİRKEN HATA OLUŞTU.İNTERNET BAĞLANTISINI KONTROL ETMELİSİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                }
            }
            
            
            
            

        }
    }
}
