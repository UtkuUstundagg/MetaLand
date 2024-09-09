using MetaLand.Classes;
using MetaLand.Screens;
using MetaLand.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaLand
{
    public partial class Oyun : Form
    {
        public DateTime date;
        int kullanici_No = 0;
        int alan = 0;

        int boxSizeX;
        int boxSizeY;

        public PictureBox[,] pbList;
        private List<Alan> alanList = new List<Alan>();


        Connection conn = new Connection();
        public Oyun()
        {
            InitializeComponent();
        }

        public void kullaniciNoAl(int kullaniciNo)
        {
            dateTimePicker1.Value = date;
            kullanici_No = kullaniciNo;
            labelSetle();
        }

        public void labelSetle()
        {
            conn.connectionAc();
            l_No.Text = kullanici_No.ToString();
            l_Para.Text = conn.kullaniciEnvanterParaBul(kullanici_No).ToString();
            l_Esya.Text = conn.kullaniciEnvanterEsyaBul(kullanici_No).ToString();
            l_Yiyecek.Text = conn.kullaniciEnvanterYiyecekBul(kullanici_No).ToString();
            l_Is.Text = conn.kullaniciIsDurumuBul(kullanici_No).ToString();

            conn.connectionKapat();
        }

        public void haritaOlustur()
        {
            boyutBul();
            pbList = new PictureBox[alan, alan];


            int alanNo = 1;
            for (int i = 0; i < alan; i++)
            {
                for (int j = 0; j < alan; j++)
                {
                    Alan alan = new Alan();
                    Label label = new Label();

                    pbList[i, j] = new PictureBox();



                    int xPos = 10 + (j * boxSizeX);
                    int yPos = 10 + (i * boxSizeY);

                    label.SetBounds(xPos + 5, yPos + 5, 20, 15);
                    label.Text = alanNo.ToString();
                    label.BackColor = Color.LightGray;

                    pbList[i, j].SetBounds(xPos, yPos, boxSizeX, boxSizeY);
                    pbList[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pbList[i, j].MouseClick += Oyun_MouseClick;

                    alan.Satir = i;
                    alan.Sutun = j;
                    alan.X = xPos;
                    alan.Y = yPos;

                    alan.Alan_No = alanNo;
                    alan.Alan_Sahibi = 1;

                    conn.connectionAc();
                    conn.pbSet(alanNo, xPos, yPos);
                    conn.connectionKapat();

                    if (i == 0 && j < 3)
                    {
                        alan.Alan_Turu = "Isletme";
                        alan.SatiliyorMu = 0;
                        if (j == 0)
                        {
                            alan.Isletme_Turu = "Market";
                            Label label2 = new Label();
                            label2.Text = "Market";
                            label2.BackColor = Color.LightGray;
                            label2.SetBounds(xPos + 5, yPos + 25, 50, 15);

                            Label label3 = new Label();
                            label3.Text = "1";
                            label3.BackColor = Color.LightGray;
                            label3.SetBounds(xPos + 5, yPos + 45, 15, 15);

                            Controls.Add(label2);
                            Controls.Add(label3);

                        }
                        else if (j == 1)
                        {
                            alan.Isletme_Turu = "Magaza";
                            Label label2 = new Label();
                            label2.Text = "Magaza";
                            label2.BackColor = Color.LightGray;
                            label2.SetBounds(xPos + 5, yPos + 25, 50, 15);

                            Label label3 = new Label();
                            label3.Text = "1";
                            label3.BackColor = Color.LightGray;
                            label3.SetBounds(xPos + 5, yPos + 45, 20, 15);

                            Controls.Add(label2);
                            Controls.Add(label3);
                        }
                        else if (j == 2)
                        {
                            alan.Isletme_Turu = "Emlak";
                            Label label2 = new Label();
                            label2.Text = "Emlak";
                            label2.BackColor = Color.LightGray;
                            label2.SetBounds(xPos + 5, yPos + 25, 50, 15);

                            Label label3 = new Label();
                            label3.Text = "1";
                            label3.BackColor = Color.LightGray;
                            label3.SetBounds(xPos + 5, yPos + 45, 20, 15);

                            Controls.Add(label2);
                            Controls.Add(label3);
                        }

                        alan.Isletme_Seviyesi = 1;
                        alan.Isletme_Kapasitesi = 999;
                        alan.Isletme_Calisan_Sayisi = 0;
                        conn.connectionAc();
                        alan.Isletme_Sabit_Gelir_Miktari = conn.sabitGelirBul();
                        alan.Isletme_Sabit_Gelir_Orani = conn.sabitOranBul();
                        conn.connectionKapat();
                        alan.Mevcut_Seviye_Baslangic_Tarihi = dateTimePicker1.Value;
                    }
                    else
                    {
                        alan.SatiliyorMu = 1;
                        alan.Alan_Turu = "Arsa";
                        Label label2 = new Label();
                        label2.Text = "Arsa";
                        label2.BackColor = Color.LightGray;
                        label2.SetBounds(xPos + 5, yPos + 25, 50, 15);

                        Label label3 = new Label();
                        label3.Text = "1";
                        label3.BackColor = Color.LightGray;
                        label3.SetBounds(xPos + 5, yPos + 45, 20, 15);

                        Controls.Add(label2);
                        Controls.Add(label3);
                    }

                    alanNo++;

                    alanList.Add(alan);

                    Controls.Add(label);
                    Controls.Add(pbList[i, j]);
                }
            }

            conn.connectionAc();
            conn.alanTablosunaEkle(alanList);
            conn.connectionKapat();
            ızgaraRenklendir(alanList);
        }

        public void haritaEkranaBas()
        {
            boyutBul();
            pbList = new PictureBox[alan, alan];


            int alanNo = 1;
            for (int i = 0; i < alan; i++)
            {
                for (int j = 0; j < alan; j++)
                {
                    Alan alan = new Alan();
                    Label label = new Label();

                    pbList[i, j] = new PictureBox();


                    conn.connectionAc();
                    int xPos = conn.pbXBul(alanNo);
                    int yPos = conn.pbYBul(alanNo);
                    conn.connectionKapat();

                    label.SetBounds(xPos + 5, yPos + 5, 20, 15);
                    label.Text = alanNo.ToString();
                    

                    pbList[i, j].SetBounds(xPos, yPos, boxSizeX, boxSizeY);
                    pbList[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pbList[i, j].MouseClick += Oyun_MouseClick;

                    alan.Satir = i;
                    alan.Sutun = j;
                    alan.X = xPos;
                    alan.Y = yPos;
                    alan.Alan_No = alanNo;

                    conn.connectionAc();
                    alan.Alan_Sahibi = conn.intAlanBul(alanNo, 0);
                    alan.Alan_Turu = conn.stringAlanBul(alanNo, 1);
                    alan.Isletme_Turu = conn.stringAlanBul(alanNo, 2);
                    alan.Isletme_Seviyesi = conn.intAlanBul(alanNo, 3);
                    alan.Isletme_Kapasitesi = conn.intAlanBul(alanNo, 4);
                    alan.Isletme_Calisan_Sayisi = conn.intAlanBul(alanNo, 5);
                    alan.Isletme_Sabit_Gelir_Miktari = conn.intAlanBul(alanNo, 6);
                    alan.Isletme_Sabit_Gelir_Orani = conn.floatAlanBul(alanNo, 7);
                    alan.Mevcut_Seviye_Baslangic_Tarihi = conn.dateAlanBul(alanNo, 8);
                    alan.SatiliyorMu = conn.satilikKiralikBul(alanNo);
                    conn.connectionKapat();

                    if (alan.Alan_Sahibi != 0)
                    {
                        Label label2 = new Label();
                        Label label3 = new Label();
                        if (alan.Isletme_Turu != " ")
                        {
                            label2.Text = alan.Isletme_Turu;
                        }
                        else
                        {
                            label2.Text = alan.Alan_Turu;
                        }
                        if (alan.Alan_Turu == "Isletme")
                        {
                            if(alan.Isletme_Turu == "Market")
                            {
                                label.BackColor = Color.LightBlue;
                                label2.BackColor = Color.LightBlue;
                                label3.BackColor = Color.LightBlue;
                            }
                            else if(alan.Isletme_Turu == "Magaza")
                            {
                                label.BackColor = Color.Khaki;
                                label2.BackColor = Color.Khaki;
                                label3.BackColor = Color.Khaki;
                            }
                            else if (alan.Isletme_Turu == "Emlak")
                            {
                                label.BackColor = Color.IndianRed;
                                label2.BackColor = Color.IndianRed;
                                label3.BackColor = Color.IndianRed;
                            }
                        }
                        else
                        {
                            label.BackColor = Color.LightGray;
                            label2.BackColor = Color.LightGray;
                            label3.BackColor = Color.LightGray;
                        }
                        label3.Text = alan.Alan_Sahibi.ToString();

                        label2.SetBounds(xPos + 5, yPos + 25, 50, 15);
                        label3.SetBounds(xPos + 5, yPos + 45, 20, 15);

                        Controls.Add(label2);
                        Controls.Add(label3);

                    }


                    alanNo++;

                    alanList.Add(alan);

                    Controls.Add(label);
                    Controls.Add(pbList[i, j]);
                }
            }

            ızgaraRenklendir(alanList);

        }

        private void Oyun_MouseClick(object? sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            int pbXkord = pb.Bounds.X;
            int pbYkord = pb.Bounds.Y;

            var bulunan = alanList.Find(item => item.X == pbXkord && item.Y == pbYkord);

            if (bulunan != null)
            {
                if (bulunan.Isletme_Turu == "Market")
                {
                    Market ekran = new Market();
                    conn.connectionAc();
                    if (bulunan.Alan_Sahibi != 1)
                    {
                        ekran.labelAyarla(kullanici_No, conn.kullaniciYiyecekFiyat(bulunan.Alan_Sahibi), bulunan.Alan_Sahibi);
                    }
                    else
                    {
                        ekran.labelAyarla(kullanici_No, conn.yiyecekFiyat(), bulunan.Alan_Sahibi);
                    }
                    
                    conn.connectionKapat();

                    ekran.Show();


                }
                else if (bulunan.Isletme_Turu == "Magaza")
                {
                    Magaza ekran = new Magaza();
                    conn.connectionAc();
                    if (bulunan.Alan_Sahibi != 1)
                    {
                        ekran.labelAyarla(kullanici_No, conn.kullaniciEsyaFiyat(bulunan.Alan_Sahibi), bulunan.Alan_Sahibi);
                    }
                    else
                    {
                        ekran.labelAyarla(kullanici_No, conn.esyaFiyat(), bulunan.Alan_Sahibi);
                    }
                    
                    conn.connectionKapat();

                    ekran.Show();
                }
                else if (bulunan.Isletme_Turu == "Emlak")
                {
                    Emlak ekran = new Emlak();
                    ekran.teklifleriListele(kullanici_No, bulunan.Alan_Sahibi, dateTimePicker1.Value);
                    ekran.Show();
                }
            }


        }

        public void boyutBul()
        {
            conn.connectionAc();
            alan = conn.oyunAlaniBul();
            conn.connectionKapat();

            boxSizeX = 1000 / alan;
            boxSizeY = 600 / alan;

        }

        private void ızgaraRenklendir(List<Alan> alanList)
        {

            foreach (var item in alanList)
            {
                if (item.Alan_Turu == "Isletme" && item.Isletme_Turu == "Market")
                {
                    pbList[item.Satir, item.Sutun].BackColor = Color.LightBlue;
                }
                else if (item.Alan_Turu == "Isletme" && item.Isletme_Turu == "Magaza")
                {
                    pbList[item.Satir, item.Sutun].BackColor = Color.Khaki;
                }
                else if (item.Alan_Turu == "Isletme" && item.Isletme_Turu == "Emlak")
                {
                    pbList[item.Satir, item.Sutun].BackColor = Color.IndianRed;
                }
                else
                {
                    pbList[item.Satir, item.Sutun].BackColor = Color.LightGray;
                }
            }
        }

        private void btn_Sar_Click(object sender, EventArgs e)
        {
            conn.connectionAc();
            DateTime eskiTarih = conn.suankiTarihiBul();
            DateTime yeniTarih = dateTimePicker1.Value;
            conn.tarihiSar(yeniTarih);

            dateTimePicker1.Value = yeniTarih;

            TimeSpan gun = gunHesapla(eskiTarih, yeniTarih);

            conn.gunlukEnvanterEksiltmeYap(gun.Days);

            if (!conn.halaCalisiyorMu(kullanici_No, dateTimePicker1.Value))
            {
                conn.issizYap(kullanici_No);
            }

            if (!conn.devamKontrol(kullanici_No))
            {
                conn.oyuncuSil(kullanici_No);
                MessageBox.Show("Yiyecek Veya Eşyanız Bitti Oyunu Kaybettiniz", "Oyun Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            conn.connectionKapat();
            labelSetle();
            
        }

        public TimeSpan gunHesapla(DateTime eskiTarih, DateTime yeniTarih)
        {
            TimeSpan gunSayisi = yeniTarih - eskiTarih;
            return gunSayisi;
        }

        private void btn_IsBul_Click(object sender, EventArgs e)
        {
            Teklifler ekran = new Teklifler();
            ekran.Show();
            ekran.teklifGetir(kullanici_No, dateTimePicker1.Value);

        }

        private void btn_Isletme_Click(object sender, EventArgs e)
        {
            KullaniciIsletme ekran = new KullaniciIsletme();
            ekran.noGetir(kullanici_No);
            ekran.Show();
        }

        private void btn_SatKirala_Click(object sender, EventArgs e)
        {
            SatveyaKirala ekran = new SatveyaKirala();
            ekran.noGetir(kullanici_No);
            ekran.Show();
        }

        private void btn_Detay_Click(object sender, EventArgs e)
        {
            Detaylar ekran = new Detaylar();
            ekran.noGetir(kullanici_No);
            ekran.Show();
        }
    }
}
