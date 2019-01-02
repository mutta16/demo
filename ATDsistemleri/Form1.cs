using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDsistemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCeConnection baglanti = new SqlCeConnection(@"Data Source=|DataDirectory|\AtdSistemleriDatabase.sdf");
        public string pozisyon;
        public static string idNogonder;
        public static string AdGonder;
        public static string SoyadGonder;
        public static string KimlikNoGonder;
        public static string PozisyonGonder;

        

        private void Form1_Load(object sender, EventArgs e)
        {

            
            // TODO: This line of code loads data into the 'atdSistemleriDatabaseDataSet.PersonelTablosu' table. You can move, or remove it, as needed.
            //this.personelTablosuTableAdapter.Fill(this.atdSistemleriDatabaseDataSet.PersonelTablosu);
            this.personelTablosuTableAdapter.Fill(this.atdSistemleriDatabaseDataSet.PersonelTablosu);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            

        }

        private void personelTablosuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personelTablosuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atdSistemleriDatabaseDataSet);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtGiris.TextLength == 10)
            {
                e.Handled = true;
                txtGiris.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtGiris.Text.Length > 9)
            {
                SqlCeDataReader dr = null;
                SqlCeDataReader dr2 = null;
                SqlCeCommand komut = new SqlCeCommand("select*from PersonelTablosu where KartNo='"+txtGiris.Text+"'",baglanti);
                baglanti.Open();
                dr=komut.ExecuteReader();
                while (dr.Read())
                {
                    pozisyon= dr["Pozisyon"].ToString();
                    idNogonder = dr["KartNo"].ToString();
                    KimlikNoGonder = dr["KimlikNo"].ToString();
                    AdGonder = dr["Ad"].ToString();
                    SoyadGonder = dr["Soyad"].ToString();
                    PozisyonGonder = dr["Pozisyon"].ToString();
                    txtGiris.Text = "";
                }



                SqlCeCommand komut2 = new SqlCeCommand("select*from PersonelTablosu where KimlikNo='" + txtGiris.Text + "'", baglanti);
                
                dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    pozisyon = dr2["Pozisyon"].ToString();
                    txtGiris.Text = "";
                    
                }


                if (pozisyon == "AMIR")
                {

                    amirPanel formac = new amirPanel();
                    formac.ShowDialog();
                    pozisyon = "";
                    txtGiris.Focus();
                }
                else if (pozisyon == "OPERATOR")
                {
                    opPanel formac = new opPanel();
                    formac.ShowDialog();
                    pozisyon = "";
                    txtGiris.Focus();
                }
                else
                {
                    txtGiris.Text = "";
                    MessageBox.Show("TANIMLI KULLANICI DEĞİLSİNİZ.YÖNETİCİNİZE BAŞVURUN.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning );
                    txtGiris.Focus();
                }
                           
                baglanti.Close();
                
            }
            else
            {
                

            }
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtGiris.Text += 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtGiris.Text = "";
            txtGiris.Focus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            txtGiris.Focus();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txtGiris.Focus();
        }
    }
}
