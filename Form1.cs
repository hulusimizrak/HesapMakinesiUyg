using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiUyg
{
    public partial class Form1 : Form
    {
        private double sayi1 = 0, sayi2 = 0, sonucGoster;
        private string yapilacakIslem = "";
        private string islemSayac; // kullanıcı işlemini bitirdiğinde değerleri sıfırlamak için kullanılan kontrol

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtEkran.Text = "0"; // sayfa yüklenince ekrana 0 yazdır
            islemSayac = "";
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            if (islemSayac == "") // ekrana ilk defa değer yazdırılıyorsa sayı değerini gir
            {
                txtEkran.Text = "1";
                 
            }
            else // ekran doluysa yanına yeni buton değerini ekle
            {
                txtEkran.Text = txtEkran.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "2";
                
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "3";
                
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "4";
                
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "4";
            }

        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "5";
                
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "6";
                
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "7";
                
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "8";
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (islemSayac == "")
            {
                txtEkran.Text = "9";
                
            }
            else
            {
                txtEkran.Text = "9" + txtEkran.Text;
            }
        }
        private void btnSifir_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = ""; // ekran boşsa sıfır değerini yazma
            }
            else
            {
                txtEkran.Text = txtEkran.Text + "0";
            }
        }



        private void btnTersAl_Click(object sender, EventArgs e)
        {
            int gelenSayi = Convert.ToInt32(txtEkran.Text);

            gelenSayi = gelenSayi * (-1);            
            txtEkran.Text = gelenSayi.ToString();

        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "-";
                yapilacakIslem = "cikarma";
            }
            else
            {
                sayi1 = Convert.ToDouble(txtEkran.Text);
                lblGoster.Text = (sayi1 + " -").ToString();
                txtEkran.ResetText();
                yapilacakIslem = "cikarma";
            }
        }
        private void btnToplama_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "";
                yapilacakIslem = "toplama";
            }
            else
            {
                sayi1 = Convert.ToDouble(txtEkran.Text);
                lblGoster.Text = (sayi1 + " +").ToString();
                txtEkran.ResetText();
                yapilacakIslem = "toplama";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "";
                yapilacakIslem = "mod";
            }
            else
            {
                sayi1 = Convert.ToDouble(txtEkran.Text);
                lblGoster.Text = (sayi1 + " = Mod (").ToString();
                txtEkran.ResetText();
                yapilacakIslem = "mod";
            }
        }
        private void btnCarpma_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "";
                yapilacakIslem = "carpma";
            }
            else
            {
                sayi1 = Convert.ToDouble(txtEkran.Text);
                lblGoster.Text = (sayi1 + " X").ToString();
                txtEkran.ResetText();
                yapilacakIslem = "carpma";
            }
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "";
                yapilacakIslem = "bolme";
            }
            else
            {
                sayi1 = Convert.ToInt32(txtEkran.Text);
                lblGoster.Text = (sayi1 + " /").ToString();
                txtEkran.ResetText();
                yapilacakIslem = "bolme";
            }
        }
        private void btnKok_Click(object sender, EventArgs e)
        {
            sonucGoster = Math.Sqrt(Convert.ToDouble(txtEkran.Text));
            txtEkran.Text = sonucGoster.ToString();
            DegerleriSifirla();
        }
        
        private void btnAC_Click(object sender, EventArgs e)
        {
            txtEkran.ResetText();
            txtEkran.Text = "0";
            DegerleriSifirla();
            lblGoster.Text = "";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {

            if (sayi1 == 0 && sayi2 == 0)
            {
                MessageBox.Show("Geçersiz Veri !!");
            }
            else
            {
                sayi2 = Convert.ToDouble(txtEkran.Text);

                switch (yapilacakIslem)
                {
                    case "cikarma":
                        sonucGoster = (sayi1 - sayi2);
                        txtEkran.Text = sonucGoster.ToString();
                        lblGoster.Text = (sayi1 + " - " + sayi2 +" = ").ToString();
                        break;
                    case "bolme":
                        sonucGoster = (sayi1 / sayi2);
                        txtEkran.Text = sonucGoster.ToString();
                        lblGoster.Text = (sayi1 + " / " + sayi2 +" = ").ToString();
                        break;
                    case "toplama":
                        sonucGoster = (sayi1 + sayi2);
                        txtEkran.Text = sonucGoster.ToString();
                        lblGoster.Text = (sayi1 + " + " + sayi2 +" = ").ToString();
                        break;
                    case "carpma":
                        sonucGoster = (sayi1 * sayi2);
                        txtEkran.Text = sonucGoster.ToString();
                        lblGoster.Text = (sayi1 + " X " + sayi2 +" = ").ToString();
                        break;
                    case "mod":
                        sonucGoster = (sayi1 % sayi2);
                        txtEkran.Text = sonucGoster.ToString();
                        lblGoster.Text = (sayi1 + "= Mod( " + sayi2 +" ) ").ToString();
                        break;
                    default:
                        break;
                }

                DegerleriSifirla();
            }
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Convert.ToDouble(txtEkran.Text) / 100).ToString();
            DegerleriSifirla();
        }

        private void DegerleriSifirla()
        {
            sayi1 = 0;
            sayi2 = 0;
            yapilacakIslem = "";
            islemSayac = "";
        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text.Substring(0,txtEkran.Text.Length-1); // sondan bir sayı silme

        }

        private void btnBirBolu_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (1 / Convert.ToDouble(txtEkran.Text)).ToString();
            DegerleriSifirla();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Pow(Convert.ToDouble(txtEkran.Text),2)).ToString();
            DegerleriSifirla();
        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Pow(Convert.ToDouble(txtEkran.Text), 3)).ToString();
            DegerleriSifirla();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Sin(Math.PI * Convert.ToDouble(txtEkran.Text) / 180)).ToString();
            DegerleriSifirla();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Cos(Math.PI * Convert.ToDouble(txtEkran.Text) / 180)).ToString();
            DegerleriSifirla();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Tan(Math.PI * Convert.ToDouble(txtEkran.Text) / 180)).ToString();
            DegerleriSifirla();
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (1/(Math.Tan(Math.PI * Convert.ToDouble(txtEkran.Text) / 180))).ToString();
            DegerleriSifirla();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Log10(Convert.ToDouble(txtEkran.Text))).ToString();
            DegerleriSifirla();
        }

        private void btnOnUzeriX_Click(object sender, EventArgs e)
        {
            txtEkran.Text = (Math.Pow(10,Convert.ToDouble(txtEkran.Text))).ToString();
            DegerleriSifirla();
        }

        private void btnFaktoryel_Click(object sender, EventArgs e)
        {
            int verilenDeger = Convert.ToInt32(txtEkran.Text);
            int deger=1;
            for (int i = 1; i <= verilenDeger;i++ ) 
            {
                deger = deger * i;
            
            }
            txtEkran.Text = deger.ToString();
            DegerleriSifirla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEkran.Text = Math.Round(Math.PI,4).ToString(); // virgülden sonra 2 karakter göster
        }

       
        private void txtEkran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
               
               if (islemSayac == "") // ekrana ilk defa değer yazdırılıyorsa klavyeden buton değerini gir
               {
                   txtEkran.Text = e.KeyChar.ToString();
                   
               }
               else // ekran doluysa yanına klavyeden yeni buton değerini ekle
               {
                   txtEkran.Text += e.KeyChar.ToString();
               }
               e.Handled = true;                    
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        

        
        
    }
}
