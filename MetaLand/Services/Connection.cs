using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MetaLand.Classes;
using System.Data;

namespace MetaLand.Services
{
    internal class Connection
    {
        SqlConnection connection = new SqlConnection("Data Source= DESKTOP-E3QRRJF; Initial Catalog = MetaLandDB;Integrated Security=true");

        public void connectionAc()
        {
            connection.Open();
        }

        public void connectionKapat()
        {
            connection.Close();
        }

        public void kayitEkle(Kullanici kullanici)
        {
            string kullaniciAdi = kullanici.Kullanici_Adi;
            string kullaniciAdiSoyadi = kullanici.Kullanici_Soyadi;
            string kullaniciAdiSifre = kullanici.Kullanici_Sifre;
            string isDurumu = kullanici.Kullanici_Is_Durumu;

            SqlCommand command = new SqlCommand("INSERT INTO Kullanici VALUES (@Kullanici_Adi, @Kullanici_Soyadi, @Kullanici_Sifre);", connection);

            command.Parameters.AddWithValue("@Kullanici_Adi", kullaniciAdi);
            command.Parameters.AddWithValue("@Kullanici_Soyadi", kullaniciAdiSoyadi);
            command.Parameters.AddWithValue("@Kullanici_Sifre", kullaniciAdiSifre);
            

            command.ExecuteNonQuery();

            int kullaniciNo = 0;
            command = new SqlCommand("SELECT Kullanici_No FROM Kullanici WHERE Kullanici_Adi = @Kullanici_Adi AND Kullanici_Soyadi = @Kullanici_Soyadi AND Kullanici_Sifre = @Kullanici_Sifre;", connection);
            command.Parameters.AddWithValue("@Kullanici_Adi", kullaniciAdi);
            command.Parameters.AddWithValue("@Kullanici_Soyadi", kullaniciAdiSoyadi);
            command.Parameters.AddWithValue("@Kullanici_Sifre", kullaniciAdiSifre);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                kullaniciNo = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();

            DateTime dateTime = DateTime.Now;
            command = new SqlCommand("INSERT INTO Kullanici_Is VALUES (@kullaniciNo, @KullaniciIsDurumu, @calisilanAlanNo, @calisanIsletmeTuru, @ucret, @basTar, @bitTar);", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            command.Parameters.AddWithValue("@KullaniciIsDurumu", "Issiz");
            command.Parameters.AddWithValue("@calisilanAlanNo", 0);
            command.Parameters.AddWithValue("@calisanIsletmeTuru", "NULL");
            command.Parameters.AddWithValue("@ucret", "0");
            command.Parameters.AddWithValue("@basTar", dateTime);
            command.Parameters.AddWithValue("@bitTar", dateTime);
            command.ExecuteNonQuery();

        }

        public Boolean kayitKontrol(string kullaniciAdi, string kullaniciSifre)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_Adi, Kullanici_Sifre FROM Kullanici WHERE Kullanici_Adi = @kullaniciAdi AND Kullanici_Sifre = @kullaniciSifre;", connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            command.Parameters.AddWithValue("@kullaniciSifre", kullaniciSifre);
            SqlDataReader read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                return true;
            }
            else
            {
                read.Close();
                return false;
            }

        }

        public Boolean yoneticiKontrol(string kullaniciAdi, string kullaniciSifre)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_No, Kullanici_Adi, Kullanici_Sifre FROM Kullanici WHERE Kullanici_No = 1 AND Kullanici_Adi = @kullaniciAdi AND Kullanici_Sifre = @kullaniciSifre;", connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            command.Parameters.AddWithValue("@kullaniciSifre", kullaniciSifre);

            SqlDataReader read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                return true;
            }
            else
            {
                read.Close();
                return false;
            }
        }

        public void kullaniciEnvanterSetle()
        {

            int kulEnvanterNo = 0;
            int kulYemekMiktari = 0;
            int kulEsyaMiktari = 0;
            int kulParaMiktari = 0;

            SqlCommand command = new SqlCommand("SELECT * FROM Kullanici WHERE Kullanici_No = (SELECT MAX(Kullanici_No) FROM Kullanici);", connection);
            SqlCommand command1 = new SqlCommand("SELECT * FROM Yonetici_Baslangic_Envanter", connection);

            SqlDataReader r1 = command.ExecuteReader();

            while (r1.Read())
            {
                kulEnvanterNo = Convert.ToInt32(r1.GetValue(0));
            }
            r1.Close();

            SqlDataReader r2 = command1.ExecuteReader();

            while (r2.Read())
            {
                kulYemekMiktari = Convert.ToInt32(r2.GetValue(0));
                kulEsyaMiktari = Convert.ToInt32(r2.GetValue(1));
                kulParaMiktari = Convert.ToInt32(r2.GetValue(2));
            }
            r2.Close();

            SqlCommand command2 = new SqlCommand("INSERT INTO Kullanici_Envanter VALUES (@kullaniciEnvanterNo, @kullaniciYemek, @kullaniciEsya, @kullaniciPara);", connection);

            command2.Parameters.AddWithValue("kullaniciEnvanterNo", kulEnvanterNo);
            command2.Parameters.AddWithValue("kullaniciYemek", kulYemekMiktari);
            command2.Parameters.AddWithValue("kullaniciEsya", kulEsyaMiktari);
            command2.Parameters.AddWithValue("kullaniciPara", kulParaMiktari);

            command2.ExecuteNonQuery();



        }

        public void alanVeDateTimeAyarla(int oyunAlani, DateTime tarih)
        {
            SqlCommand command = new SqlCommand("UPDATE Oyun_Boyut_Ve_Tarih SET Oyun_Baslangic_Tarihi = @tarih , Oyun_Alan_Boyutu = @oyunAlani;", connection);

            command.Parameters.AddWithValue("@tarih", tarih);
            command.Parameters.AddWithValue("@oyunAlani", oyunAlani);

            command.ExecuteNonQuery();
        }

        public void baslangicEnvanterAyarla(int yemek, int para, int esya)
        {
            SqlCommand command = new SqlCommand("UPDATE Yonetici_Baslangic_Envanter SET Baslangic_Yemek_Miktari = @yemek , Baslangic_Para_Miktari = @para , Baslangic_Esya_Miktari = @esya;", connection);
            command.Parameters.AddWithValue("@yemek", yemek);
            command.Parameters.AddWithValue("@para", para);
            command.Parameters.AddWithValue("@esya", esya);

            command.ExecuteNonQuery();

        }

        public void gunlukGiderleriAyarla(int yiyecek, int esya, int para)
        {
            SqlCommand command = new SqlCommand("UPDATE Yonetici_Baslangic_Giderler SET Yonetici_Gunluk_Yiyecek_Gideri = @yiyecek , Yonetici_Gunluk_Esya_Gider = @esya , Yonetici_Gunluk_Para_Gideri = @para;", connection);
            command.Parameters.AddWithValue("@yiyecek", yiyecek);
            command.Parameters.AddWithValue("@esya", esya);
            command.Parameters.AddWithValue("@para", para);

            command.ExecuteNonQuery();

        }

        public void yoneticiUcretiAyarla(int market, int magaza, int emlak)
        {
            SqlCommand command = new SqlCommand("SELECT Alan_No, Isletme_Turu FROM Oyun_Alan WHERE Alan_Turu = 'Isletme' AND Isletme_Turu = 'Market' AND Alan_Sahibi = 1", connection);
            SqlDataReader read = command.ExecuteReader();

            int alanNo = 0;
            string isletmeTuru = " ";
            while (read.Read())
            {
                alanNo = Convert.ToInt32(read.GetValue(0));
                isletmeTuru = read.GetValue(1).ToString();
            }
            read.Close();

            command = new SqlCommand("SELECT * FROM Yonetici_Isletme_Ucretleri WHERE Alan_No = @alanNo AND Isletme_Turu = @ısletmeTuru;", connection);
            command.Parameters.AddWithValue("@alanNo", alanNo);
            command.Parameters.AddWithValue("ısletmeTuru", isletmeTuru);
            read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Yonetici_Isletme_Ucretleri SET Ucreti = @market WHERE Alan_No = @alanNo AND Isletme_Turu = @isletmeTuru;", connection);
                command.Parameters.AddWithValue("@market", market);
                command.Parameters.AddWithValue("@alanNo", alanNo);
                command.Parameters.AddWithValue("@isletmeTuru", isletmeTuru);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Yonetici_Isletme_Ucretleri VALUES (@alanNo, @isletmeTuru, @ucreti);", connection);
                command.Parameters.AddWithValue("alanNo", alanNo);
                command.Parameters.AddWithValue("isletmeTuru", isletmeTuru);
                command.Parameters.AddWithValue("ucreti", market);

                command.ExecuteNonQuery();
            }



            command = new SqlCommand("SELECT Alan_No, Isletme_Turu FROM Oyun_Alan WHERE Alan_Turu = 'Isletme' AND Isletme_Turu = 'Magaza' AND Alan_Sahibi = 1", connection);
            read = command.ExecuteReader();

            while (read.Read())
            {
                alanNo = Convert.ToInt32(read.GetValue(0));
                isletmeTuru = read.GetValue(1).ToString();
            }
            read.Close();

            command = new SqlCommand("SELECT * FROM Yonetici_Isletme_Ucretleri WHERE Alan_No = @alanNo AND Isletme_Turu = @ısletmeTuru;", connection);
            command.Parameters.AddWithValue("@alanNo", alanNo);
            command.Parameters.AddWithValue("ısletmeTuru", isletmeTuru);
            read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Yonetici_Isletme_Ucretleri SET Ucreti = @magaza WHERE Alan_No = @alanNo AND Isletme_Turu = @isletmeTuru;", connection);
                command.Parameters.AddWithValue("@magaza", magaza);
                command.Parameters.AddWithValue("@alanNo", alanNo);
                command.Parameters.AddWithValue("@isletmeTuru", isletmeTuru);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Yonetici_Isletme_Ucretleri VALUES (@alanNo, @isletmeTuru, @ucreti);", connection);
                command.Parameters.AddWithValue("alanNo", alanNo);
                command.Parameters.AddWithValue("isletmeTuru", isletmeTuru);
                command.Parameters.AddWithValue("ucreti", magaza);

                command.ExecuteNonQuery();
            }



            command = new SqlCommand("SELECT Alan_No, Isletme_Turu FROM Oyun_Alan WHERE Alan_Turu = 'Isletme' AND Isletme_Turu = 'Emlak' AND Alan_Sahibi = 1", connection);
            read = command.ExecuteReader();

            while (read.Read())
            {
                alanNo = Convert.ToInt32(read.GetValue(0));
                isletmeTuru = read.GetValue(1).ToString();
            }
            read.Close();

            command = new SqlCommand("SELECT * FROM Yonetici_Isletme_Ucretleri WHERE Alan_No = @alanNo AND Isletme_Turu = @ısletmeTuru;", connection);
            command.Parameters.AddWithValue("@alanNo", alanNo);
            command.Parameters.AddWithValue("ısletmeTuru", isletmeTuru);
            read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Yonetici_Isletme_Ucretleri SET Ucreti = @emlak WHERE Alan_No = @alanNo AND Isletme_Turu = @isletmeTuru;", connection);
                command.Parameters.AddWithValue("@emlak", emlak);
                command.Parameters.AddWithValue("@alanNo", alanNo);
                command.Parameters.AddWithValue("@isletmeTuru", isletmeTuru);
                command.ExecuteNonQuery();
            }
            else
            {
                command = new SqlCommand("INSERT INTO Yonetici_Isletme_Ucretleri VALUES (@alanNo, @isletmeTuru, @ucreti);", connection);
                command.Parameters.AddWithValue("alanNo", alanNo);
                command.Parameters.AddWithValue("isletmeTuru", isletmeTuru);
                command.Parameters.AddWithValue("ucreti", emlak);

                command.ExecuteNonQuery();
            }

        }

        public void yoneticiSabitGelirAyarla(int miktar, float oran)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Yonetici_Sabit_Gelirler;", connection);
            SqlDataReader read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Yonetici_Sabit_Gelirler SET Isletme_Sabit_Gelir_Miktari = @miktar, Isletme_Sabit_Gelir_Orani = @oran;", connection);
                command.Parameters.AddWithValue("@miktar", miktar);
                command.Parameters.AddWithValue("@oran", oran);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Yonetici_Sabit_Gelirler VALUES (@miktar, @oran);", connection);
                command.Parameters.AddWithValue("@miktar", miktar);
                command.Parameters.AddWithValue("@oran", oran);
                command.ExecuteNonQuery();
            }
        }

        public void yoneticiIsletmeFiyatAyarla(int kurmaUcreti, int kiralamaUcreti)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Yonetici_Isletme_Fiyatlari;", connection);
            SqlDataReader read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Yonetici_Isletme_Fiyatlari SET Isletme_Fiyati = @kurmaUcreti, Kiralık_Isletme_Fiyati = @kiralamaUcreti;", connection);
                command.Parameters.AddWithValue("@kurmaUcreti", kurmaUcreti);
                command.Parameters.AddWithValue("@kiralamaUcreti", kiralamaUcreti);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Yonetici_Isletme_Fiyatlari VALUES (@kurmaUcreti, @kiralamaUcreti);", connection);
                command.Parameters.AddWithValue("@kurmaUcreti", kurmaUcreti);
                command.Parameters.AddWithValue("@kiralamaUcreti", kiralamaUcreti);
                command.ExecuteNonQuery();
            }
        }

        public void yoneticiMarketFiyatlariAyarla(int yiyecekFiyat, int esyaFiyat, int emlakKomisyonu)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Yonetici_Market_Ucretleri;", connection);
            SqlDataReader read = command.ExecuteReader();

            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Yonetici_Market_Ucretleri SET Yiyecek_Ucreti = @yiyecek, Esya_Ucreti = @esya, Emlak_Komisyonu = @emlak;", connection);
                command.Parameters.AddWithValue("@yiyecek", yiyecekFiyat);
                command.Parameters.AddWithValue("@esya", esyaFiyat);
                command.Parameters.AddWithValue("@emlak", emlakKomisyonu);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Yonetici_Market_Ucretleri VALUES (@yiyecek, @esya, @emlak);", connection);
                command.Parameters.AddWithValue("@yiyecek", yiyecekFiyat);
                command.Parameters.AddWithValue("@esya", esyaFiyat);
                command.Parameters.AddWithValue("@emlak", emlakKomisyonu);
                command.ExecuteNonQuery();
            }
        }

        public int sabitGelirBul()
        {
            int gelir = 0;
            SqlCommand command = new SqlCommand("SELECT Isletme_Sabit_Gelir_Miktari FROM Yonetici_Sabit_Gelirler", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                gelir = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();
            return gelir;
        }

        public float sabitOranBul()
        {
            float gelir = 0;
            SqlCommand command = new SqlCommand("SELECT Isletme_Sabit_Gelir_Orani FROM Yonetici_Sabit_Gelirler", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                gelir = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();
            return gelir;
        }

        public int kullaniciNoBul(string kullaniciAdi, string kullaniciSifre)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_No FROM Kullanici WHERE Kullanici_Adi = @kullaniciAdi AND Kullanici_Sifre = @kullaniciSifre;", connection);
            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            command.Parameters.AddWithValue("@kullaniciSifre", kullaniciSifre);

            SqlDataReader read = command.ExecuteReader();
            int kullanici_no = 0;

            while (read.Read())
            {
                kullanici_no = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();

            return kullanici_no;
        }

        public int kullaniciEnvanterParaBul(int kullaniciNo)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

            SqlDataReader read = command.ExecuteReader();
            int para = 0;

            while (read.Read())
            {
                para = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();
            return para;
        }

        public int kullaniciEnvanterEsyaBul(int kullaniciNo)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_Esya_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

            SqlDataReader read = command.ExecuteReader();
            int esya = 0;

            while (read.Read())
            {
                esya = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();
            return esya;
        }

        public int kullaniciEnvanterYiyecekBul(int kullaniciNo)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_Yemek_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

            SqlDataReader read = command.ExecuteReader();
            int yiyecek = 0;

            while (read.Read())
            {
                yiyecek = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();
            return yiyecek;
        }

        public string kullaniciIsDurumuBul(int kullaniciNo)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_Is_Durumu FROM Kullanici_IS WHERE Kullanici_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

            SqlDataReader read = command.ExecuteReader();

            string isDurumu = " ";
            while (read.Read())
            {
                isDurumu = read.GetValue(0).ToString();
            }
            read.Close();
            return isDurumu;
        }

        public void kullaniciIsGuncelle(int kullaniciNo, int teklifNo, int teklifSahibi, int alanNo, DateTime tarih)
        {
            string isletmeTuru = " ";
            int ucret = 0;
            DateTime basTar = DateTime.Now;
            DateTime bitTar = DateTime.Now;
            bool calisiyorMu = false;
            string isDurumu = " ";

            int calisanSayisi = 0;
            int isletmeKapasitesi = 0;

            SqlCommand command = new SqlCommand("SELECT Kullanici_Is_Durumu FROM Kullanici_Is WHERE Kullanici_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                isDurumu = read.GetValue(0).ToString();
            }
            read.Close();

            command = new SqlCommand("SELECT Isletme_Kapasitesi, Isletme_Calisan_Sayisi FROM Oyun_Alan WHERE Alan_No = @alan AND Alan_Sahibi = @sahip;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.Parameters.AddWithValue("@sahip", teklifSahibi);
            read = command.ExecuteReader();
            while (read.Read())
            {
                isletmeKapasitesi = read.GetInt32(0);
                calisanSayisi = read.GetInt32(1);
            }
            read.Close();

            if (calisanSayisi < isletmeKapasitesi)
            {
                if (isDurumu == "Issiz" || isDurumu == " ")
                {
                    command = new SqlCommand("UPDATE Oyun_Alan SET Isletme_Calisan_Sayisi = @calisan WHERE Alan_No = @alan AND Alan_Sahibi = @sahip;", connection);
                    command.Parameters.AddWithValue("@calisan", calisanSayisi + 1);
                    command.Parameters.AddWithValue("@alan", alanNo);
                    command.Parameters.AddWithValue("@sahip", teklifSahibi);

                    command.ExecuteNonQuery();

                    command = new SqlCommand("SELECT Isletme_Turu, Ucret, Kullanici_Calisma_Baslangic_Tarihi, Kullanici_Calisma_Bitis_Tarihi FROM Oyun_Teklifler WHERE Teklif_No = @teklifNo;", connection);
                    command.Parameters.AddWithValue("@teklifNo", teklifNo);
                    read = command.ExecuteReader();

                    while (read.Read())
                    {
                        isletmeTuru = read.GetValue(0).ToString();
                        ucret = Convert.ToInt32(read.GetValue(1));
                        basTar = Convert.ToDateTime(read.GetValue(2));
                        bitTar = Convert.ToDateTime(read.GetValue(3));
                    }
                    read.Close();



                    command = new SqlCommand("UPDATE Kullanici_IS SET Kullanici_Is_Durumu = @is, Calisilan_Alan_No = @alan, Calisilan_Isletme_Turu = @isletme, Ucret = @Ucret, Baslangic_Tarihi = @basTar, Bitis_Tarihi = @bitTar WHERE Kullanici_No = @kullaniciNo;", connection);
                    command.Parameters.AddWithValue("@is", isletmeTuru);
                    command.Parameters.AddWithValue("@alan", alanNo);
                    command.Parameters.AddWithValue("@isletme", isletmeTuru);
                    command.Parameters.AddWithValue("@Ucret", ucret);
                    command.Parameters.AddWithValue("@basTar", basTar);
                    command.Parameters.AddWithValue("@bitTar", bitTar);
                    command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

                    command.ExecuteNonQuery();





                }
                else
                {
                    command = new SqlCommand("SELECT Bitis_Tarihi FROM Kullanici_Is WHERE Kullanici_No = @kullaniciNo;", connection);
                    command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

                    read = command.ExecuteReader();

                    while (read.Read())
                    {
                        bitTar = Convert.ToDateTime(read.GetValue(0));
                    }
                    read.Close();

                    if (tarih > bitTar)
                    {
                        command = new SqlCommand("SELECT Isletme_Turu, Ucret, Kullanici_Calisma_Baslangic_Tarihi, Kullanici_Calisma_Bitis_Tarihi FROM Oyun_Teklifler WHERE Teklif_No = @teklifNo;", connection);
                        command.Parameters.AddWithValue("@teklifNo", teklifNo);
                        read = command.ExecuteReader();

                        while (read.Read())
                        {
                            isletmeTuru = read.GetValue(0).ToString();
                            ucret = Convert.ToInt32(read.GetValue(1));
                            basTar = Convert.ToDateTime(read.GetValue(2));
                            bitTar = Convert.ToDateTime(read.GetValue(3));
                        }
                        read.Close();

                        command = new SqlCommand("UPDATE Kullanici_IS SET Kullanici_Is_Durumu = @is, Calisilan_Alan_No = @alan, Calisilan_Isletme_Turu = @isletme, Ucret = @Ucret, Baslangic_Tarihi = @basTar, Bitis_Tarihi = @bitTar WHERE Kullanici_No = @kullaniciNo;", connection);
                        command.Parameters.AddWithValue("@is", isletmeTuru);
                        command.Parameters.AddWithValue("@alan", alanNo);
                        command.Parameters.AddWithValue("@isletme", isletmeTuru);
                        command.Parameters.AddWithValue("@Ucret", ucret);
                        command.Parameters.AddWithValue("@basTar", basTar);
                        command.Parameters.AddWithValue("@bitTar", bitTar);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("En Fazla 1 İşte Çalışılabilir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("İşletmenin Kapasitesi Dolmuştur!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int oyunAlaniBul()
        {
            SqlCommand command = new SqlCommand("SELECT Oyun_Alan_Boyutu FROM Oyun_Boyut_Ve_Tarih;", connection);
            SqlDataReader read = command.ExecuteReader();

            int alan = 0;
            while (read.Read())
            {
                alan = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();
            return alan;
        }

        public void alanTablosunaEkle(List<Alan> alanList)
        {
            for (int i = 0; i < alanList.Count; i++)
            {

                if (alanList[i].Isletme_Turu != null)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Oyun_Alan VALUES (@alan_No, @alan_Sahibi, @alan_Turu, @isletme_Turu, @isletme_Seviyesi, @Isletme_Kapasitesi, @Isletme_Calisan_Sayisi, @Isletme_Sabit_Gelir_Miktari, @Isletme_Sabit_Gelir_Orani, @Isletme_Mevcut_Seviye_Baslangic_Tarihi, @Fiyat, @SatiliyorMu);", connection);
                    command.Parameters.AddWithValue("@alan_No", alanList[i].Alan_No);
                    command.Parameters.AddWithValue("@alan_Sahibi", alanList[i].Alan_Sahibi);
                    command.Parameters.AddWithValue("@alan_Turu", alanList[i].Alan_Turu);
                    command.Parameters.AddWithValue("@isletme_turu", alanList[i].Isletme_Turu);
                    command.Parameters.AddWithValue("@isletme_Seviyesi", alanList[i].Isletme_Seviyesi);
                    command.Parameters.AddWithValue("@Isletme_Kapasitesi", alanList[i].Isletme_Kapasitesi);
                    command.Parameters.AddWithValue("@Isletme_Calisan_Sayisi", alanList[i].Isletme_Calisan_Sayisi);
                    command.Parameters.AddWithValue("@Isletme_Sabit_Gelir_Miktari", alanList[i].Isletme_Sabit_Gelir_Miktari);
                    command.Parameters.AddWithValue("@Isletme_Sabit_Gelir_Orani", alanList[i].Isletme_Sabit_Gelir_Orani);
                    command.Parameters.AddWithValue("@Isletme_Mevcut_Seviye_Baslangic_Tarihi", alanList[i].Mevcut_Seviye_Baslangic_Tarihi);
                    command.Parameters.AddWithValue("@Fiyat", 999999);
                    command.Parameters.AddWithValue("@SatiliyorMu", alanList[i].SatiliyorMu);

                    command.ExecuteNonQuery();
                }
                else
                {
                    alanList[i].Isletme_Turu = " ";
                    SqlCommand command = new SqlCommand("INSERT INTO Oyun_Alan VALUES (@alan_No, @alan_Sahibi, @alan_Turu, @isletme_Turu, @isletme_Seviyesi, @Isletme_Kapasitesi, @Isletme_Calisan_Sayisi, @Isletme_Sabit_Gelir_Miktari, @Isletme_Sabit_Gelir_Orani, @Isletme_Mevcut_Seviye_Baslangic_Tarihi, @Fiyat, @SatiliyorMu);", connection);
                    command.Parameters.AddWithValue("@alan_No", alanList[i].Alan_No);
                    command.Parameters.AddWithValue("@alan_Sahibi", alanList[i].Alan_Sahibi);
                    command.Parameters.AddWithValue("@alan_Turu", alanList[i].Alan_Turu);
                    command.Parameters.AddWithValue("@isletme_turu", alanList[i].Isletme_Turu);
                    command.Parameters.AddWithValue("@isletme_Seviyesi", alanList[i].Isletme_Seviyesi);
                    command.Parameters.AddWithValue("@Isletme_Kapasitesi", alanList[i].Isletme_Kapasitesi);
                    command.Parameters.AddWithValue("@Isletme_Calisan_Sayisi", alanList[i].Isletme_Calisan_Sayisi);
                    command.Parameters.AddWithValue("@Isletme_Sabit_Gelir_Miktari", alanList[i].Isletme_Sabit_Gelir_Miktari);
                    command.Parameters.AddWithValue("@Isletme_Sabit_Gelir_Orani", alanList[i].Isletme_Sabit_Gelir_Orani);
                    command.Parameters.AddWithValue("@Isletme_Mevcut_Seviye_Baslangic_Tarihi", DateTime.Now);
                    command.Parameters.AddWithValue("@Fiyat", 5000);
                    command.Parameters.AddWithValue("@SatiliyorMu", alanList[i].SatiliyorMu);
                    command.ExecuteNonQuery();
                }

            }

        }

        public void alanTablosunuTemizle()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Oyun_Alan;", connection);
            command.ExecuteNonQuery();
        }

        public int alanTabloSatirSayisi()
        {
            int alanNo = 0;
            SqlCommand command = new SqlCommand("SELECT Alan_No FROM Oyun_Alan;", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                alanNo = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();

            return alanNo;
        }

        public DateTime suankiTarihiBul()
        {
            DateTime tarih = DateTime.Now;

            SqlCommand command = new SqlCommand("SELECT Oyun_Baslangic_Tarihi FROM Oyun_Boyut_Ve_Tarih;", connection);

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                tarih = read.GetDateTime(0);
            }
            read.Close();

            return tarih;
        }

        public void tarihiSar(DateTime yeniTarih)
        {
            SqlCommand command = new SqlCommand("UPDATE Oyun_Boyut_Ve_Tarih SET Oyun_Baslangic_Tarihi = @tarih;", connection);
            command.Parameters.AddWithValue("@tarih", yeniTarih);

            command.ExecuteNonQuery();
        }

        public void gunlukEnvanterEksiltmeYap(int gunSayisi)
        {
            int yiyecekGideri = 0;
            int esyaGideri = 0;
            int paraGideri = 0;

            int anlikYiyecek = 0;
            int anlikEsya = 0;
            int anlikPara = 0;

            string isDurumu = " ";

            int kullaniciNo = 0;
            List <int> kullaniciNoList = new List<int>();

            SqlCommand command = new SqlCommand("SELECT Kullanici_Envanter_No FROM Kullanici_Envanter;", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                kullaniciNoList.Add(read.GetInt32(0));
            }
            read.Close();

            
            command = new SqlCommand("SELECT * FROM Yonetici_Baslangic_Giderler;", connection);
            read = command.ExecuteReader();

            while (read.Read())
            {
                yiyecekGideri = Convert.ToInt32(read.GetValue(0));
                esyaGideri = Convert.ToInt32(read.GetValue(1));
                paraGideri = Convert.ToInt32(read.GetValue(2));
            }
            read.Close();

            foreach(var item in kullaniciNoList)
            {
                kullaniciNo = item;

                command = new SqlCommand("SELECT Kullanici_Is_Durumu FROM Kullanici_Is WHERE Kullanici_No = @kullaniciNo", connection);
                command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    isDurumu = read.GetValue(0).ToString();
                }
                read.Close();

                for (int i = 0; i < gunSayisi; i++)
                {
                    if (isDurumu == "Issiz")
                    {
                        command = new SqlCommand("SELECT * FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo", connection);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        read = command.ExecuteReader();

                        while (read.Read())
                        {
                            anlikYiyecek = Convert.ToInt32(read.GetValue(1));
                            anlikEsya = Convert.ToInt32(read.GetValue(2));
                            anlikPara = Convert.ToInt32(read.GetValue(3));
                        }
                        read.Close();

                        command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Yemek_Miktari = @yeniYiyecek , Kullanici_Esya_Miktari = @yeniEsya , Kullanici_Para_Miktari = @yeniPara WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
                        command.Parameters.AddWithValue("@yeniYiyecek", anlikYiyecek - yiyecekGideri);
                        command.Parameters.AddWithValue("@yeniEsya", anlikEsya - esyaGideri);
                        command.Parameters.AddWithValue("@yeniPara", anlikPara - paraGideri);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        command.ExecuteNonQuery();
                    }
                    else if (isDurumu == "Market")
                    {
                        command = new SqlCommand("SELECT * FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo", connection);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        read = command.ExecuteReader();

                        while (read.Read())
                        {
                            anlikYiyecek = Convert.ToInt32(read.GetValue(1));
                            anlikEsya = Convert.ToInt32(read.GetValue(2));
                            anlikPara = Convert.ToInt32(read.GetValue(3));
                        }
                        read.Close();

                        command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Yemek_Miktari = @yeniYiyecek , Kullanici_Esya_Miktari = @yeniEsya , Kullanici_Para_Miktari = @yeniPara WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
                        command.Parameters.AddWithValue("@yeniYiyecek", anlikYiyecek);
                        command.Parameters.AddWithValue("@yeniEsya", anlikEsya - esyaGideri);
                        command.Parameters.AddWithValue("@yeniPara", anlikPara - paraGideri);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        command.ExecuteNonQuery();
                    }
                    else if (isDurumu == "Magaza")
                    {
                        command = new SqlCommand("SELECT * FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo", connection);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        read = command.ExecuteReader();

                        while (read.Read())
                        {
                            anlikYiyecek = Convert.ToInt32(read.GetValue(1));
                            anlikEsya = Convert.ToInt32(read.GetValue(2));
                            anlikPara = Convert.ToInt32(read.GetValue(3));
                        }
                        read.Close();

                        command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Yemek_Miktari = @yeniYiyecek , Kullanici_Esya_Miktari = @yeniEsya , Kullanici_Para_Miktari = @yeniPara WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
                        command.Parameters.AddWithValue("@yeniYiyecek", anlikYiyecek - yiyecekGideri);
                        command.Parameters.AddWithValue("@yeniEsya", anlikEsya);
                        command.Parameters.AddWithValue("@yeniPara", anlikPara - paraGideri);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        command.ExecuteNonQuery();
                    }
                    else if (isDurumu == "Emlak")
                    {
                        command = new SqlCommand("SELECT * FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo", connection);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        read = command.ExecuteReader();

                        while (read.Read())
                        {
                            anlikYiyecek = Convert.ToInt32(read.GetValue(1));
                            anlikEsya = Convert.ToInt32(read.GetValue(2));
                            anlikPara = Convert.ToInt32(read.GetValue(3));
                        }
                        read.Close();

                        command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Yemek_Miktari = @yeniYiyecek , Kullanici_Esya_Miktari = @yeniEsya , Kullanici_Para_Miktari = @yeniPara WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
                        command.Parameters.AddWithValue("@yeniYiyecek", anlikYiyecek - yiyecekGideri);
                        command.Parameters.AddWithValue("@yeniEsya", anlikEsya - esyaGideri);
                        command.Parameters.AddWithValue("@yeniPara", anlikPara);
                        command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                        command.ExecuteNonQuery();
                    }
                }
            }
            
            
            maasEkle(gunSayisi, kullaniciNo);
            
        }

        public void maasEkle(int gunSayisi, int kullaniciNo)
        {
            for (int i = 0; i < gunSayisi; i++)
            {
                int maas = 0;
                int anlikPara = 0;
                SqlCommand command = new SqlCommand("SELECT Ucret FROM Kullanici_Is WHERE Kullanici_No = @kullaniciNo;", connection);
                command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    maas += Convert.ToInt32(read.GetValue(0));
                }
                read.Close();

                string isletmeTuru = " ";
                int sayi = 0;

                command = new SqlCommand("SELECT Isletme_Turu FROM Oyun_Alan WHERE Alan_Sahibi = @sahip;", connection);
                command.Parameters.AddWithValue("@sahip", kullaniciNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    isletmeTuru = read.GetString(0);
                    if (isletmeTuru != " " && isletmeTuru != null && isletmeTuru != "")
                    {
                        sayi++;
                    }
                }
                read.Close();

                if (sayi > 0)
                {
                    command = new SqlCommand("SELECT Isletme_Sabit_Gelir_Miktari FROM Oyun_Alan WHERE Alan_Sahibi = @sahip;", connection);
                    command.Parameters.AddWithValue("@sahip", kullaniciNo);
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        maas += read.GetInt32(0);
                    }
                    read.Close();
                }

                command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
                command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    anlikPara = Convert.ToInt32(read.GetValue(0));
                }
                read.Close();

                command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Para_Miktari = @maas WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
                command.Parameters.AddWithValue("@maas", anlikPara + maas);
                command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
                command.ExecuteNonQuery();



            }

        }

        public bool devamKontrol(int kullaniciNo)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();

            int yiyecek = 0;
            int esya = 0;
            int para = 0;

            while (read.Read())
            {
                yiyecek = Convert.ToInt32(read.GetValue(1));
                esya = Convert.ToInt32(read.GetValue(2));
                para = Convert.ToInt32(read.GetValue(3));
            }
            read.Close();

            if (esya <= 0 || yiyecek <= 0)
            {
                return false;
            }
            else
                return true;
        }

        public void oyuncuSil(int kullaniciNo)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Kullanici WHERE Kullanici_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            command.ExecuteNonQuery();

            command = new SqlCommand("DELETE FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            command.ExecuteNonQuery();

            command = new SqlCommand("DELETE FROM Kullanici_Is WHERE Kullanici_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            command.ExecuteNonQuery();

            command = new SqlCommand("DELETE FROM Kullanici_İsletme_Ucretleri WHERE Kullanici_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            command.ExecuteNonQuery();

        }

        public int sahipBul(int alanNo)
        {
            SqlCommand command = new SqlCommand("SELECT Alan_Sahibi FROM Oyun_Alan WHERE Alan_No = @alanNo;", connection);
            command.Parameters.AddWithValue("alanNo", alanNo);

            SqlDataReader read = command.ExecuteReader();
            int sahip = 0;

            while (read.Read())
            {
                sahip = Convert.ToInt32(read.GetValue(0));
            }
            read.Close();

            return sahip;

        }

        public void yoneticiTeklifOlustur()
        {
            string isletmeTuru = " ";
            int marketUcret = 0;

            string isletmeTuru2 = " ";
            int magazaUcret = 0;

            string isletmeTuru3 = " ";
            int emlakUcret = 0;

            DateTime basTarih = suankiTarihiBul();
            DateTime bitTarih = basTarih.AddDays(14);
            TimeSpan time = new TimeSpan(8, 0, 0);

            //market
            SqlCommand command = new SqlCommand("SELECT Isletme_Turu, Ucreti FROM Yonetici_Isletme_Ucretleri WHERE Alan_No = 1", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                isletmeTuru = read.GetValue(0).ToString();
                marketUcret = Convert.ToInt32(read.GetValue(1));
            }
            read.Close();

            command = new SqlCommand("SELECT * FROM Oyun_Teklifler WHERE Teklifi_Olusturan = 1 AND Isletme_Turu = 'Market';", connection);
            read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Oyun_Teklifler SET Ucret = @marketUcret, Kullanici_Calisma_Baslangic_Tarihi = @basTarih, Kullanici_Calisma_Bitis_Tarihi = @bitTarih WHERE Teklifi_Olusturan = 1 AND Isletme_Turu = 'Market';", connection);
                command.Parameters.AddWithValue("@marketUcret", marketUcret);
                command.Parameters.AddWithValue("@basTarih", basTarih);
                command.Parameters.AddWithValue("@bitTarih", bitTarih);

                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Oyun_Teklifler VALUES (@alan_No, @teklifiOlusturan, @isletmeTuru, @ucret, @kullaniciCalismaBaslangic, @kullaniciCalismaBitis, @kullaniciCalismaGun, @kullaniciCalismaSaat, @teklifiKabulEden);", connection);
                command.Parameters.AddWithValue("@alan_No", 1);
                command.Parameters.AddWithValue("@teklifiOlusturan", 1);
                command.Parameters.AddWithValue("@isletmeTuru", isletmeTuru);
                command.Parameters.AddWithValue("@ucret", marketUcret);
                command.Parameters.AddWithValue("@kullaniciCalismaBaslangic", basTarih);
                command.Parameters.AddWithValue("@kullaniciCalismaBitis", bitTarih);
                command.Parameters.AddWithValue("@kullaniciCalismaGun", 14);
                command.Parameters.AddWithValue("@kullaniciCalismaSaat", time);
                command.Parameters.AddWithValue("@teklifiKabulEden", 0);

                command.ExecuteNonQuery();
            }


            //magaza
            command = new SqlCommand("SELECT Isletme_Turu, Ucreti FROM Yonetici_Isletme_Ucretleri WHERE Alan_No = 2", connection);
            read = command.ExecuteReader();
            while (read.Read())
            {
                isletmeTuru2 = read.GetValue(0).ToString();
                magazaUcret = Convert.ToInt32(read.GetValue(1));
            }
            read.Close();

            command = new SqlCommand("SELECT * FROM Oyun_Teklifler WHERE Teklifi_Olusturan = 1 AND Isletme_Turu = 'Magaza';", connection);
            read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Oyun_Teklifler SET Ucret = @magazaUcret, Kullanici_Calisma_Baslangic_Tarihi = @basTarih, Kullanici_Calisma_Bitis_Tarihi = @bitTarih WHERE Teklifi_Olusturan = 1 AND Isletme_Turu = 'Magaza';", connection);
                command.Parameters.AddWithValue("@magazaUcret", magazaUcret);
                command.Parameters.AddWithValue("@basTarih", basTarih);
                command.Parameters.AddWithValue("@bitTarih", bitTarih);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Oyun_Teklifler VALUES (@alan_No, @teklifiOlusturan, @isletmeTuru, @ucret, @kullaniciCalismaBaslangic, @kullaniciCalismaBitis, @kullaniciCalismaGun, @kullaniciCalismaSaat, @teklifiKabulEden);", connection);
                command.Parameters.AddWithValue("@alan_No", 2);
                command.Parameters.AddWithValue("@teklifiOlusturan", 1);
                command.Parameters.AddWithValue("@isletmeTuru", isletmeTuru2);
                command.Parameters.AddWithValue("@ucret", magazaUcret);
                command.Parameters.AddWithValue("@kullaniciCalismaBaslangic", basTarih);
                command.Parameters.AddWithValue("@kullaniciCalismaBitis", bitTarih);
                command.Parameters.AddWithValue("@kullaniciCalismaGun", 14);
                command.Parameters.AddWithValue("@kullaniciCalismaSaat", time);
                command.Parameters.AddWithValue("@teklifiKabulEden", 0);


                command.ExecuteNonQuery();
            }



            //emlak
            command = new SqlCommand("SELECT Isletme_Turu, Ucreti FROM Yonetici_Isletme_Ucretleri WHERE Alan_No = 3", connection);
            read = command.ExecuteReader();

            while (read.Read())
            {
                isletmeTuru3 = read.GetValue(0).ToString();
                emlakUcret = Convert.ToInt32(read.GetValue(1));
            }
            read.Close();
            command = new SqlCommand("SELECT * FROM Oyun_Teklifler WHERE Teklifi_Olusturan = 1 AND Isletme_Turu = 'Emlak';", connection);
            read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Oyun_Teklifler SET Ucret = @emlakUcret, Kullanici_Calisma_Baslangic_Tarihi = @basTarih, Kullanici_Calisma_Bitis_Tarihi = @bitTarih WHERE Teklifi_Olusturan = 1 AND Isletme_Turu = 'Emlak';", connection);
                command.Parameters.AddWithValue("@emlakUcret", emlakUcret);
                command.Parameters.AddWithValue("@basTarih", basTarih);
                command.Parameters.AddWithValue("@bitTarih", bitTarih);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Oyun_Teklifler VALUES (@alan_No, @teklifiOlusturan, @isletmeTuru, @ucret, @kullaniciCalismaBaslangic, @kullaniciCalismaBitis, @kullaniciCalismaGun, @kullaniciCalismaSaat, @teklifiKabulEden);", connection);
                command.Parameters.AddWithValue("@alan_No", 3);
                command.Parameters.AddWithValue("@teklifiOlusturan", 1);
                command.Parameters.AddWithValue("@isletmeTuru", isletmeTuru3);
                command.Parameters.AddWithValue("@ucret", emlakUcret);
                command.Parameters.AddWithValue("@kullaniciCalismaBaslangic", basTarih);
                command.Parameters.AddWithValue("@kullaniciCalismaBitis", bitTarih);
                command.Parameters.AddWithValue("@kullaniciCalismaGun", 14);
                command.Parameters.AddWithValue("@kullaniciCalismaSaat", time);
                command.Parameters.AddWithValue("@teklifiKabulEden", 0);


                command.ExecuteNonQuery();
            }



        }

        public DataSet gridDoldur()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Oyun_Teklifler;", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet gridEmlakDoldur()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Alan_No, Alan_Sahibi, Alan_Turu, Isletme_Turu, Isletme_Seviyesi, SatiliyorMu, Fiyat FROM Oyun_Alan WHERE SatiliyorMu = 1 OR SatiliyorMu = 2;", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet satilikKiralikDoldur(int kullaniciNo)
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Alan_No, Alan_Sahibi, Alan_Turu, Isletme_Turu, Isletme_Seviyesi, SatiliyorMu, Fiyat FROM Oyun_Alan WHERE Alan_Sahibi = " + kullaniciNo + ";", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet giderDoldur(int kullaniciNo)
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Yonetici_Gunluk_Yiyecek_Gideri, Yonetici_Gunluk_Esya_Gider, Yonetici_Gunluk_Para_Gideri FROM Yonetici_Baslangic_Giderler;", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet satinAlmaDoldur(int kullaniciNo)
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Yapilan_Islem_Turu, Harcanan_Para FROM Kullanici_Satin_Almalar_ve_Giderler WHERE Kullanici_No = " + kullaniciNo + ";", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet varlikDoldur(int kullaniciNo)
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Alan_No, Alan_Turu, Isletme_Turu, Isletme_Seviyesi, Isletme_Kapasitesi, Isletme_Calisan_Sayisi, Fiyat FROM Oyun_Alan WHERE Alan_Sahibi = " + kullaniciNo + ";", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet envanterGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Kullanici_Envanter", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet gecmisGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Kullanici_Satin_Almalar_ve_Giderler", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet alanGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Oyun_Alan", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet isletmeUcretGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Kullanici_İsletme_Ucretleri", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet isGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Kullanici_Is", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet kullaniciGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT Kullanici_No, Kullanici_Adi, Kullanici_Soyadi FROM Kullanici", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }

        public DataSet emlakGoruntule()
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Oyun_Emlak_Islemler", connection);

            DataSet ds = new DataSet();

            data.Fill(ds);

            return ds;
        }



        public void alanSatilikYap(int alanNo)
        {
            SqlCommand command = new SqlCommand("UPDATE Oyun_Alan SET SatiliyorMu = 1 WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.ExecuteNonQuery();
        }

        public void alanKiralikYap(int alanNo)
        {
            SqlCommand command = new SqlCommand("UPDATE Oyun_Alan SET SatiliyorMu = 2 WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.ExecuteNonQuery();
        }

        public void alanIptalEt(int alanNo)
        {
            SqlCommand command = new SqlCommand("UPDATE Oyun_Alan SET SatiliyorMu = 0 WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.ExecuteNonQuery();
        }

        public void alanFiyatBelirle(int alanNo, int fiyat)
        {
            SqlCommand command = new SqlCommand("UPDATE Oyun_Alan SET Fiyat = @fiyat WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@fiyat", fiyat);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.ExecuteNonQuery();
        }

        public void arsaSatinAl(int alanNo, int kullaniciNo, int sahipNo)
        {
            int fiyat = 0;
            SqlCommand command = new SqlCommand("SELECT Fiyat FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                fiyat = read.GetInt32(0);
            }
            read.Close();


            int anlikPara = 0;
            command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @no;", connection);
            command.Parameters.AddWithValue("@no", kullaniciNo);
            read = command.ExecuteReader();
            while (read.Read())
            {
                anlikPara = read.GetInt32(0);
            }
            read.Close();

            int komisyon = 0;
            int anlikPara2 = 0;

            if (sahipNo != 1)
            {
                command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    anlikPara2 = read.GetInt32(0);
                }
                read.Close();
                command = new SqlCommand("SELECT Kullanici_Emlak_Komisyon FROM Kullanici_İsletme_Ucretleri WHERE Kullanici_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    komisyon = read.GetInt32(0);
                }
                read.Close();


                command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@para", anlikPara2 + (fiyat * komisyon) / 100);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);

                command.ExecuteNonQuery();

            }

            command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @no;", connection);
            command.Parameters.AddWithValue("@para", anlikPara - fiyat - (fiyat * komisyon) / 100);
            command.Parameters.AddWithValue("@no", kullaniciNo);
            command.ExecuteNonQuery();

            command = new SqlCommand("UPDATE Oyun_Alan SET Alan_Sahibi = @sahip WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@sahip", kullaniciNo);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.ExecuteNonQuery();

            satinAlmalarVeGiderler(kullaniciNo, 3, fiyat + (fiyat * komisyon) / 100);

        }

        public bool halaCalisiyorMu(int kullaniciNo, DateTime tarih)
        {
            DateTime bitisTarihi = DateTime.Now;

            SqlCommand command = new SqlCommand("SELECT Bitis_Tarihi FROM Kullanici_Is WHERE Kullanici_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                bitisTarihi = read.GetDateTime(0);
            }
            read.Close();

            if (tarih > bitisTarihi)
            {
                return false;
            }
            else
                return true;
        }

        public void issizYap(int kullaniciNo)
        {
            int alanNo = 0;
            int calisanSayisi = 0;

            SqlCommand command = new SqlCommand("SELECT Calisilan_Alan_No FROM Kullanici_Is WHERE Kullanici_No = @kullanici;", connection);
            command.Parameters.AddWithValue("@kullanici", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                alanNo = read.GetInt32(0);
            }
            read.Close();

            command = new SqlCommand("SELECT Isletme_Calisan_Sayisi FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            read = command.ExecuteReader();

            while (read.Read())
            {
                calisanSayisi = read.GetInt32(0);
            }
            read.Close();

            command = new SqlCommand("UPDATE Oyun_Alan SET Isletme_Calisan_Sayisi = @calisan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@calisan", calisanSayisi - 1);
            command.Parameters.AddWithValue("@alan", alanNo);
            command.ExecuteNonQuery();


            command = new SqlCommand("UPDATE Kullanici_Is SET Kullanici_Is_Durumu = 'Issiz', Calisilan_Alan_No = 0, Calisilan_Isletme_Turu = 'NULL', Ucret = 0, Baslangic_Tarihi = @baslangic, Bitis_Tarihi = @bitis WHERE Kullanici_No = @kullanici_No;", connection);
            command.Parameters.AddWithValue("@baslangic", DateTime.Now);
            command.Parameters.AddWithValue("@bitis", DateTime.Now);
            command.Parameters.AddWithValue("@kullanici_No", kullaniciNo);
            command.ExecuteNonQuery();
        }

        public int yiyecekFiyat()
        {
            int yiyecekFiyat = 0;
            SqlCommand command = new SqlCommand("SELECT Yiyecek_Ucreti FROM Yonetici_Market_Ucretleri;", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                yiyecekFiyat = read.GetInt32(0);
            }
            read.Close();

            return yiyecekFiyat;
        }

        public int kullaniciYiyecekFiyat(int sahipNo)
        {
            int yiyecekFiyat = 0;
            SqlCommand command = new SqlCommand("SELECT Kullanici_Market_Ucret FROM Kullanici_İsletme_Ucretleri WHERE Kullanici_No = @sahip;", connection);
            command.Parameters.AddWithValue("@sahip", sahipNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                yiyecekFiyat = read.GetInt32(0);
            }
            read.Close();

            return yiyecekFiyat;
        }

        public void yiyecekAl(int kullaniciNo, int miktar, int sahipNo)
        {
            int tutar = 0;
            if (sahipNo == 1)
            {
                tutar = esyaFiyat() * miktar;
            }
            else
            {
                tutar = kullaniciEsyaFiyat(sahipNo) * miktar;
            }
            int anlikYiyecek = 0;
            int anlikPara = 0;

            SqlCommand command = new SqlCommand("SELECT Kullanici_Yemek_Miktari,Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                anlikYiyecek = read.GetInt32(0);
                anlikPara = read.GetInt32(1);
            }
            read.Close();

            command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Yemek_Miktari = @miktar, Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@miktar", anlikYiyecek + miktar);
            command.Parameters.AddWithValue("@para", anlikPara - tutar);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

            command.ExecuteNonQuery();

            if (sahipNo != 1)
            {
                command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    anlikPara = read.GetInt32(0);
                }
                read.Close();

                command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@para", anlikPara + tutar);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);

                command.ExecuteNonQuery();
            }

            satinAlmalarVeGiderler(kullaniciNo, 1, tutar);
        }

        public int esyaFiyat()
        {
            int esyaFiyat = 0;
            SqlCommand command = new SqlCommand("SELECT Esya_Ucreti FROM Yonetici_Market_Ucretleri;", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                esyaFiyat = read.GetInt32(0);
            }
            read.Close();

            return esyaFiyat;
        }

        public int kullaniciEsyaFiyat(int sahipNo)
        {
            int esyaFiyat = 0;
            SqlCommand command = new SqlCommand("SELECT Kullanici_Magaza_Ucret FROM Kullanici_İsletme_Ucretleri WHERE Kullanici_No = @sahip;", connection);
            command.Parameters.AddWithValue("@sahip", sahipNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                esyaFiyat = read.GetInt32(0);
            }
            read.Close();

            return esyaFiyat;
        }

        public void esyaAl(int kullaniciNo, int miktar, int sahipNo)
        {
            int tutar = 0;
            if(sahipNo == 1)
            {
                tutar = esyaFiyat() * miktar;
            }
            else
            {
                tutar = kullaniciEsyaFiyat(sahipNo) * miktar;
            }
            
            int anlikesya = 0;
            int anlikPara = 0;

            SqlCommand command = new SqlCommand("SELECT Kullanici_Esya_Miktari,Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                anlikesya = read.GetInt32(0);
                anlikPara = read.GetInt32(1);
            }
            read.Close();

            command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Esya_Miktari = @miktar, Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @kullaniciNo;", connection);
            command.Parameters.AddWithValue("@miktar", anlikesya + miktar);
            command.Parameters.AddWithValue("@para", anlikPara - tutar);
            command.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);

            command.ExecuteNonQuery();

            if (sahipNo != 1)
            {
                command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    anlikPara = read.GetInt32(0);
                }
                read.Close();

                command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @sahipNo;", connection);
                command.Parameters.AddWithValue("@para", anlikPara + tutar);
                command.Parameters.AddWithValue("@sahipNo", sahipNo);

                command.ExecuteNonQuery();
            }

            satinAlmalarVeGiderler(kullaniciNo, 2, tutar);
        }

        public void satinAlmalarVeGiderler(int kullaniciNo, int index, int tutar)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Kullanici_Satin_Almalar_ve_Giderler VALUES (@Kullanici_No, @Yapilan_Islem_Turu, @Harcanan_Para);", connection);
            command.Parameters.AddWithValue("@Kullanici_No", kullaniciNo);
            if (index == 1)
            {
                command.Parameters.AddWithValue("@Yapilan_Islem_Turu", "Yiyecek Alimi");
            }
            else if(index == 2)
            {
                command.Parameters.AddWithValue("@Yapilan_Islem_Turu", "Esya Alimi");
            }
            else if(index == 3)
            {
                command.Parameters.AddWithValue("@Yapilan_Islem_Turu", "Arsa Alimi");
            }
            else if (index == 4)
            {
                command.Parameters.AddWithValue("@Yapilan_Islem_Turu", "Isletme Alimi");
            }
            command.Parameters.AddWithValue("@Harcanan_Para", tutar);
            command.ExecuteNonQuery();

        }

        public void pbSet(int alanNo, int X, int Y)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Oyun_PictureBox VALUES (@Alan_No, @X_Pos, @Y_Pos);", connection);
            command.Parameters.AddWithValue("@Alan_No", alanNo);
            command.Parameters.AddWithValue("@X_Pos", X);
            command.Parameters.AddWithValue("@Y_Pos", Y);

            command.ExecuteNonQuery();
        }

        public void pbSil()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Oyun_PictureBox", connection);
            command.ExecuteNonQuery();
        }

        public int pbXBul(int alanNo)
        {
            int xKord = 0;
            SqlCommand command = new SqlCommand("SELECT X_Pos FROM Oyun_PictureBox WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                xKord = read.GetInt32(0);
            }
            read.Close();
            return xKord;
        }

        public int pbYBul(int alanNo)
        {
            int yKord = 0;
            SqlCommand command = new SqlCommand("SELECT Y_Pos FROM Oyun_PictureBox WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                yKord = read.GetInt32(0);
            }
            read.Close();
            return yKord;
        }

        public bool kullaniciArsaAlabilirMi(int kullaniciNo)
        {
            int sayi = 0;
            SqlCommand command = new SqlCommand("SELECT Alan_Turu FROM Oyun_Alan WHERE Alan_Sahibi = @no;", connection);
            command.Parameters.AddWithValue("@no", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                if (read.GetString(0) == "Arsa")
                {
                    sayi++;
                }
            }
            read.Close();
            if (sayi >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kullaniciIsletmeKurabilirMi(int kullaniciNo)
        {
            int sayi = 0;
            SqlCommand command = new SqlCommand("SELECT Alan_Turu FROM Oyun_Alan WHERE Alan_Sahibi = @no;", connection);
            command.Parameters.AddWithValue("@no", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                if (read.GetString(0) == "Arsa")
                {
                    sayi++;
                }
            }
            read.Close();
            if (sayi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void isletmeAc(int kullaniciNo, int alanNo, string isletmeTuru)
        {
            int anlikPara = 0;
            int fiyat = 0;
            if (kullaniciNo == sahipBul(alanNo))
            {
                
                SqlCommand command = new SqlCommand("SELECT Isletme_Fiyati FROM Yonetici_Isletme_Fiyatlari;", connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    fiyat = read.GetInt32(0);
                }
                read.Close();

                
                command = new SqlCommand("SELECT Kullanici_Para_Miktari FROM Kullanici_Envanter WHERE Kullanici_Envanter_No = @no;", connection);
                command.Parameters.AddWithValue("@no", kullaniciNo);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    anlikPara = read.GetInt32(0);
                }
                read.Close();

                command = new SqlCommand("UPDATE Kullanici_Envanter SET Kullanici_Para_Miktari = @para WHERE Kullanici_Envanter_No = @no;", connection);
                command.Parameters.AddWithValue("@para", anlikPara - fiyat);
                command.Parameters.AddWithValue("@no", kullaniciNo);
                command.ExecuteNonQuery();

                int sabitMiktar = 0;
                float sabitOran = 0;
                command = new SqlCommand("SELECT * FROM Yonetici_Sabit_Gelirler;", connection);
                read = command.ExecuteReader();
                while (read.Read())
                {
                    sabitMiktar = read.GetInt32(0);
                    sabitOran = (float)read.GetDouble(1);
                }
                read.Close();


                command = new SqlCommand("UPDATE Oyun_Alan SET Alan_Turu = @tur, Isletme_Turu = @isletme, Isletme_Seviyesi = @seviye, Isletme_Kapasitesi = @kapasite, Isletme_Sabit_Gelir_Miktari = @miktar, Isletme_Sabit_Gelir_Orani = @oran ,Isletme_Mevcut_Seviye_Baslangic_Tarihi = @tarih WHERE Alan_No = @no;", connection);
                command.Parameters.AddWithValue("@tur", "Isletme");
                command.Parameters.AddWithValue("@isletme", isletmeTuru);
                command.Parameters.AddWithValue("@seviye", 1);
                command.Parameters.AddWithValue("@kapasite", 3);
                command.Parameters.AddWithValue("@miktar", sabitMiktar);
                command.Parameters.AddWithValue("@oran", sabitOran);
                command.Parameters.AddWithValue("@tarih", DateTime.Now);
                command.Parameters.AddWithValue("@no", alanNo);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Seçili Arsa Sizin Arsanız Olmadığından İşletme Kuramazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            satinAlmalarVeGiderler(kullaniciNo, 4, fiyat);
        }

        public int intAlanBul(int alanNo, int index)
        {
            int alanSahibi = 0;
            int isletmeSeviyesi = 0;
            int isletmeKapasitesi = 0;
            int isletmeCalisanSayisi = 0;
            int isletmeSabitGelirMiktari = 0;


            SqlCommand command = new SqlCommand("SELECT Alan_Sahibi,Alan_Turu,Isletme_Turu,Isletme_Seviyesi,Isletme_Kapasitesi,Isletme_Calisan_Sayisi,Isletme_Sabit_Gelir_Miktari,Isletme_Sabit_Gelir_Orani,Isletme_Mevcut_Seviye_Baslangic_Tarihi FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                alanSahibi = read.GetInt32(0);
                isletmeSeviyesi = read.GetInt32(3);
                isletmeKapasitesi = read.GetInt32(4);
                isletmeCalisanSayisi = read.GetInt32(5);
                isletmeSabitGelirMiktari = read.GetInt32(6);

            }
            read.Close();

            if (index == 0)
            {
                return alanSahibi;
            }
            else if (index == 3)
            {
                return isletmeSeviyesi;
            }
            else if (index == 4)
            {
                return isletmeKapasitesi;
            }
            else if (index == 5)
            {
                return isletmeCalisanSayisi;
            }
            else if (index == 6)
            {
                return isletmeSabitGelirMiktari;
            }
            else
            {
                return 0;
            }


        }

        public string stringAlanBul(int alanNo, int index)
        {
            string alanTuru = " ";
            string isletmeTuru = " ";

            SqlCommand command = new SqlCommand("SELECT Alan_Sahibi,Alan_Turu,Isletme_Turu,Isletme_Seviyesi,Isletme_Kapasitesi,Isletme_Calisan_Sayisi,Isletme_Sabit_Gelir_Miktari,Isletme_Sabit_Gelir_Orani,Isletme_Mevcut_Seviye_Baslangic_Tarihi FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                alanTuru = read.GetString(1);
                isletmeTuru = read.GetString(2);

            }
            read.Close();

            if (index == 1)
            {
                return alanTuru;
            }
            else if (index == 2)
            {
                return isletmeTuru;
            }
            else
            {
                return " ";
            }


        }

        public DateTime dateAlanBul(int alanNo, int index)
        {
            DateTime tarih = DateTime.Now;

            SqlCommand command = new SqlCommand("SELECT Alan_Sahibi,Alan_Turu,Isletme_Turu,Isletme_Seviyesi,Isletme_Kapasitesi,Isletme_Calisan_Sayisi,Isletme_Sabit_Gelir_Miktari,Isletme_Sabit_Gelir_Orani,Isletme_Mevcut_Seviye_Baslangic_Tarihi FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                tarih = read.GetDateTime(8);
            }
            read.Close();

            if (index == 8)
            {
                return tarih;
            }
            else
            {
                return DateTime.Now;
            }


        }

        public float floatAlanBul(int alanNo, int index)
        {

            float isletmeSabitGelirOrani = 0;

            SqlCommand command = new SqlCommand("SELECT Isletme_Sabit_Gelir_Orani FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                isletmeSabitGelirOrani = (float)read.GetDouble(0);
            }
            read.Close();

            if (index == 7)
            {
                return isletmeSabitGelirOrani;
            }
            else
            {
                return 1;
            }


        }

        public void kullaniciIsletmeUcretiAyarla(int kullaniciNo, int marketFiyat, int magazaFiyat, int emlakKomisyon)
        {
            SqlCommand command = new SqlCommand("SELECT Kullanici_No FROM Kullanici_İsletme_Ucretleri WHERE Kullanici_No = @no;", connection);
            command.Parameters.AddWithValue("@no", kullaniciNo);
            SqlDataReader read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                command = new SqlCommand("UPDATE Kullanici_İsletme_Ucretleri SET Kullanici_Market_Ucret = @market, Kullanici_Magaza_Ucret = @magaza, Kullanici_Emlak_Komisyon = @komisyon  WHERE Kullanici_No = @no;", connection);
                command.Parameters.AddWithValue("@market", marketFiyat);
                command.Parameters.AddWithValue("@magaza", magazaFiyat);
                command.Parameters.AddWithValue("@komisyon", emlakKomisyon);
                command.Parameters.AddWithValue("@no", kullaniciNo);
                command.ExecuteNonQuery();
            }
            else
            {
                read.Close();
                command = new SqlCommand("INSERT INTO Kullanici_İsletme_Ucretleri VALUES(@no, @market, @magaza, @komisyon);", connection);
                command.Parameters.AddWithValue("@no", kullaniciNo);
                command.Parameters.AddWithValue("@market", marketFiyat);
                command.Parameters.AddWithValue("@magaza", magazaFiyat);
                command.Parameters.AddWithValue("@komisyon", emlakKomisyon);
                command.ExecuteNonQuery();

            }
        }

        public void emlakIslemler(int index, int kullaniciNo, int sahipNo, int isletmeSahibi, int alanNo, DateTime basTarih)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Oyun_Emlak_Islemler VALUES (@Alan_No, @Islem_Turu, @Islemin_Yapildigi_Emlak, @Isletme_Sahibi, @Satin_Alan_veya_Kiraci, @Satis_Tarihi, @Kira_Baslangic_Tarihi, @Kira_Bitis_Tarihi, @Kira_Süresi);", connection);
            //1 satin alma
            if (index == 1)
            {
                command.Parameters.AddWithValue("@Alan_No", alanNo);
                command.Parameters.AddWithValue("@Islem_Turu", "Satis");
                command.Parameters.AddWithValue("@Islemin_Yapildigi_Emlak", sahipNo);
                command.Parameters.AddWithValue("@Isletme_Sahibi", isletmeSahibi);
                command.Parameters.AddWithValue("@Satin_Alan_veya_Kiraci", kullaniciNo);
                command.Parameters.AddWithValue("@Satis_Tarihi", basTarih);
                command.Parameters.AddWithValue("@Kira_Baslangic_Tarihi", " ");
                command.Parameters.AddWithValue("@Kira_Bitis_Tarihi", " ");
                command.Parameters.AddWithValue("@Kira_Süresi", " ");
                command.ExecuteNonQuery();
            }
            else
            {
                //2 kiralama 
                DateTime bitTarih = basTarih.AddDays(14);

                command.Parameters.AddWithValue("@Alan_No", alanNo);
                command.Parameters.AddWithValue("@Islem_Turu", "Kiralama");
                command.Parameters.AddWithValue("@Islemin_Yapildigi_Emlak", sahipNo);
                command.Parameters.AddWithValue("@Isletme_Sahibi", isletmeSahibi);
                command.Parameters.AddWithValue("@Satin_Alan_veya_Kiraci", kullaniciNo);
                command.Parameters.AddWithValue("@Satis_Tarihi", " ");
                command.Parameters.AddWithValue("@Kira_Baslangic_Tarihi", basTarih);
                command.Parameters.AddWithValue("@Kira_Bitis_Tarihi", bitTarih);
                command.Parameters.AddWithValue("@Kira_Süresi", 14);
                command.ExecuteNonQuery();

            }



        }

        public int satilikKiralikBul(int alanNo)
        {
            int isletmeSatilikKiralik = 0;

            SqlCommand command = new SqlCommand("SELECT SatiliyorMu FROM Oyun_Alan WHERE Alan_No = @alan;", connection);
            command.Parameters.AddWithValue("@alan", alanNo);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                isletmeSatilikKiralik = read.GetInt32(0);
            }
            read.Close();

            return isletmeSatilikKiralik;
        }


    }



}
