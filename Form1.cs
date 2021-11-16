using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class Form1 : Form
    {
        List<Button> buttonlar;
        List<Button> aciklar;
        const string sembollerHavuzu = "$₺€¥₾₽₪₦";
        char[] semboller;
        int kapananAdet = 0;

        public Form1()
        {
            InitializeComponent();
            ButtonlariOlustur();
            SembolOlustur();
        }

        private void SembolOlustur()
        {
            semboller = new char[16];
            Array.Copy(sembollerHavuzu.ToArray(), semboller, 8);// overload 1 stringi array yapip duz kopyalama
            Array.Copy(sembollerHavuzu.ToArray(), 0, semboller, 8, 8);
            Karistir(semboller);
        }

        private void Karistir(char[] dizi)
        {
            Random rnd = new Random();
            char gecici;
            int talihliIndex;
            for (int i = 0; i < dizi.Length; i++)
            {
                talihliIndex = rnd.Next(i, dizi.Length);
                gecici = dizi[i];
                dizi[i] = dizi[talihliIndex];
                dizi[talihliIndex] = gecici;
            }
        }

        private void ButtonlariOlustur()
        {
            aciklar = new List<Button>();
            buttonlar = new List<Button>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Font = new Font("Times New Roman", 24f);
                    btn.Location = new Point(j * 60, i * 60);
                    btn.Click += Btn_Click;
                    pnlButonlar.Controls.Add(btn);
                    buttonlar.Add(btn);
                }
            }
        }



        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (aciklar.Contains(tiklanan)) return;// zaten acik olan buttonu tekrar eklmememk icin
            
            if (aciklar.Count == 2)
                AcikKartlariKapat();

            aciklar.Add(tiklanan);
            int i = buttonlar.IndexOf(tiklanan);
            tiklanan.Text = semboller[i].ToString();

            if (aciklar.Count == 2 && aciklar[0].Text == aciklar[1].Text)
            {
                Refresh();
                Thread.Sleep(500);
                AcikKartlariKapatveGizle();
                kapananAdet += 2;
            }
            if (kapananAdet == 16)
            {
                MessageBox.Show("Oyun bitti");
                BtnTekrarOyna.Show();
            }
        }

        private void AcikKartlariKapat()
        {
            foreach (Button button in aciklar)
            {
                button.Text = "";

            }
            aciklar.Clear();
        }

        private void AcikKartlariKapatveGizle()
        {
            foreach (Button button in aciklar)
            {
                button.Text = "";
                button.Hide();
            }
            aciklar.Clear();
        }
 
        private void BtnTekrarOyna_Click(object sender, EventArgs e)
        {
            pnlButonlar.Controls.Clear();
            ButtonlariOlustur();
            SembolOlustur();
            kapananAdet = 0;
            aciklar.Clear();
            BtnTekrarOyna.Hide();

        }
    }
}
