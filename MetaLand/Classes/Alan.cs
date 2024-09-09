using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Classes
{
    internal class Alan
    {
        private int alan_No;
        private int alan_Sahibi;
        private string alan_Turu;
        private string isletme_Turu;
        private int isletme_Seviyesi;
        private int isletme_Kapasitesi;
        private int isletme_Calisan_Sayisi;
        private int isletme_Sabit_Gelir_Miktari;
        private float isletme_Sabit_Gelir_Orani;
        private DateTime mevcut_Seviye_Baslangic_Tarihi;

        private int satiliyorMu;





        private int satir;
        private int sutun;
        private int x;
        private int y;



        public int Alan_No { get => alan_No; set => alan_No = value; }
        public string Alan_Turu { get => alan_Turu; set => alan_Turu = value; }
        public int Alan_Sahibi { get => alan_Sahibi; set => alan_Sahibi = value; }
        public int Satir { get => satir; set => satir = value; }
        public int Sutun { get => sutun; set => sutun = value; }
        public string Isletme_Turu { get => isletme_Turu; set => isletme_Turu = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Isletme_Seviyesi { get => isletme_Seviyesi; set => isletme_Seviyesi = value; }
        public int Isletme_Kapasitesi { get => isletme_Kapasitesi; set => isletme_Kapasitesi = value; }
        public int Isletme_Calisan_Sayisi { get => isletme_Calisan_Sayisi; set => isletme_Calisan_Sayisi = value; }
        public int Isletme_Sabit_Gelir_Miktari { get => isletme_Sabit_Gelir_Miktari; set => isletme_Sabit_Gelir_Miktari = value; }
        public float Isletme_Sabit_Gelir_Orani { get => isletme_Sabit_Gelir_Orani; set => isletme_Sabit_Gelir_Orani = value; }
        public DateTime Mevcut_Seviye_Baslangic_Tarihi { get => mevcut_Seviye_Baslangic_Tarihi; set => mevcut_Seviye_Baslangic_Tarihi = value; }
        public int SatiliyorMu { get => satiliyorMu; set => satiliyorMu = value; }
    }
}
