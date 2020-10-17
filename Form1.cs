using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirTahminOyunu
{
    public partial class Form1 : Form
    {
        String[] sehirler =
        {
            "İstanbul","Ankara","İzmir","Adana","Adıyaman",
            "Afyonkarahisar","Ağrı","Amasya","Ankara","Antalya","Artvin",
            "Aydın","Balıkesir","Bilecik","Bingöl","Bitlis","Bolu","Burdur","Bursa","Çanakkale",
            "Çankırı","Çorum","Denizli","Diyarbakır","Edirne","Elazığ","Erzincan","Erzurum","Eskişehir",
            "Gaziantep","Giresun","Gümüşhane","Hakkari","Hatay","Isparta","Mersin","Kars","Kastamonu",
            "Kayseri","Kırklareli","Kırşehir","Kocaeli","Konya","Kütahya","Malatya","Manisa","Kahramanmaraş",
            "Mardin","Muğla","Muş","Nevşehir","Niğde","Ordu","Rize","Sakarya","Samsun","Siirt","Sinop","Sivas",
            "Tekirdağ","Tokat","Trabzon","Tunceli","Şanlıurfa","Uşak","Van","Yozgat","Zonguldak","Aksaray",
            "Bayburt","Karaman","Kırıkkale","Batman","Şırnak","Bartın","Ardahan","Iğdır","Yalova","Karabük","Kilis","Osmaniye","Düzce"
        };
        string bulunacaksehirismi = "";
        int bulunanharfsayisi = 0;
        int kalanhak = 4;
        Random rastgele;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            bulunanharfsayisi = 0;
            btnHarfGir.Enabled = true;
            btnTahminEt.Enabled = true;
            lblGirilenHarfler.Text = "";
            kalanhak = 4;

            YeniSehirSec();

            grpOyunAlanı.Controls.Clear();

            for (int i = 0; i < bulunacaksehirismi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = bulunacaksehirismi[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                grpOyunAlanı.Controls.Add(label);
            }

        }

        private void btnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfvarmı = false;
            if (txtHarf.Text.Length!=1)
            {
                MessageBox.Show("Lütfen tek harf giriniz.");

            }
            else
            {
                if (lblGirilenHarfler.Text.Contains(txtHarf.Text))
                {
                    MessageBox.Show("Bu harfi önceden girmiştiniz");
                    txtHarf.Text = "";
                    txtHarf.Focus();

                    return;
                }
                foreach (Control item in grpOyunAlanı.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper()==txtHarf.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            harfvarmı = true;
                            bulunanharfsayisi++;



                        }

                    }
                }

            }
            if (!harfvarmı)
            {
                kalanhak--;
                lblKalanHak.Text = kalanhak.ToString();
                if (kalanhak==0)
                {
                    btnHarfGir.Enabled = false;
                    btnTahminEt.Enabled = false;
                    MessageBox.Show("Kaybettiniz,yeni oyun butonuna tıklayarak yeniden deneyebilirsiniz,Cevap: "+bulunacaksehirismi);

                }
            }
            lblGirilenHarfler.Text += txtHarf.Text + " ";
            if (bulunanharfsayisi == bulunacaksehirismi.Length)
            {
                btnHarfGir.Enabled = false;
                btnTahminEt.Enabled = false;
                MessageBox.Show("Oyun bitti,tebrikler oyunu kazandınız");
                

            }
            txtHarf.Text = "";
            txtHarf.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHarfGir.Enabled = false;
            btnTahminEt.Enabled = false;
            rastgele = new Random();

            this.AcceptButton = btnHarfGir;

        }

        private void YeniSehirSec()
        {
            int rastgelesayi = rastgele.Next(0, sehirler.Length);
            bulunacaksehirismi = sehirler[rastgelesayi];
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (bulunacaksehirismi.ToUpper()==txtKelime.Text.ToUpper())
            {
                foreach (Control item in grpOyunAlanı.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;

                    }
                }
                MessageBox.Show("Tebrikler kazandınız.");
            }
            else
            {
                MessageBox.Show("Maalesef kaybettiniz,Cevap: "+bulunacaksehirismi);
            }
            btnHarfGir.Enabled = false;
            btnTahminEt.Enabled = false;

        }
    }
}
