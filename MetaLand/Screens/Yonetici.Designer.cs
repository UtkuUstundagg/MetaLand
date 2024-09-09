namespace MetaLand
{
    partial class Yonetici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AlanVeTarih = new System.Windows.Forms.Button();
            this.btn_Envanter = new System.Windows.Forms.Button();
            this.btn_Giderler = new System.Windows.Forms.Button();
            this.btn_Isletme_Ucret = new System.Windows.Forms.Button();
            this.btn_Sabit = new System.Windows.Forms.Button();
            this.btn_ItemFiyat = new System.Windows.Forms.Button();
            this.btn_EnvanterGor = new System.Windows.Forms.Button();
            this.btn_Gecmis = new System.Windows.Forms.Button();
            this.btn_Alan = new System.Windows.Forms.Button();
            this.btn_Ucret = new System.Windows.Forms.Button();
            this.btn_IsDurumu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Kullanici = new System.Windows.Forms.Button();
            this.btn_Emlak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AlanVeTarih
            // 
            this.btn_AlanVeTarih.Location = new System.Drawing.Point(12, 12);
            this.btn_AlanVeTarih.Name = "btn_AlanVeTarih";
            this.btn_AlanVeTarih.Size = new System.Drawing.Size(75, 86);
            this.btn_AlanVeTarih.TabIndex = 0;
            this.btn_AlanVeTarih.Text = "Oyun Alanı ve Başlangıc Tarihi Ayarla";
            this.btn_AlanVeTarih.UseVisualStyleBackColor = true;
            this.btn_AlanVeTarih.Click += new System.EventHandler(this.btn_AlanVeTarih_Click);
            // 
            // btn_Envanter
            // 
            this.btn_Envanter.Location = new System.Drawing.Point(12, 104);
            this.btn_Envanter.Name = "btn_Envanter";
            this.btn_Envanter.Size = new System.Drawing.Size(75, 55);
            this.btn_Envanter.TabIndex = 1;
            this.btn_Envanter.Text = "Başlangıç Envanteri Ayarla";
            this.btn_Envanter.UseVisualStyleBackColor = true;
            this.btn_Envanter.Click += new System.EventHandler(this.btn_Envanter_Click);
            // 
            // btn_Giderler
            // 
            this.btn_Giderler.Location = new System.Drawing.Point(12, 165);
            this.btn_Giderler.Name = "btn_Giderler";
            this.btn_Giderler.Size = new System.Drawing.Size(75, 59);
            this.btn_Giderler.TabIndex = 2;
            this.btn_Giderler.Text = "Günlük Giderleri Ayarla";
            this.btn_Giderler.UseVisualStyleBackColor = true;
            this.btn_Giderler.Click += new System.EventHandler(this.btn_Giderler_Click);
            // 
            // btn_Isletme_Ucret
            // 
            this.btn_Isletme_Ucret.Location = new System.Drawing.Point(12, 230);
            this.btn_Isletme_Ucret.Name = "btn_Isletme_Ucret";
            this.btn_Isletme_Ucret.Size = new System.Drawing.Size(75, 53);
            this.btn_Isletme_Ucret.TabIndex = 3;
            this.btn_Isletme_Ucret.Text = "İşletme Ücretlerini Ayarla";
            this.btn_Isletme_Ucret.UseVisualStyleBackColor = true;
            this.btn_Isletme_Ucret.Click += new System.EventHandler(this.btn_Isletme_Ucret_Click);
            // 
            // btn_Sabit
            // 
            this.btn_Sabit.Location = new System.Drawing.Point(12, 289);
            this.btn_Sabit.Name = "btn_Sabit";
            this.btn_Sabit.Size = new System.Drawing.Size(75, 56);
            this.btn_Sabit.TabIndex = 4;
            this.btn_Sabit.Text = "Sabit Gelir Ve Oranı Ayarla";
            this.btn_Sabit.UseVisualStyleBackColor = true;
            this.btn_Sabit.Click += new System.EventHandler(this.btn_Sabit_Click);
            // 
            // btn_ItemFiyat
            // 
            this.btn_ItemFiyat.Location = new System.Drawing.Point(12, 351);
            this.btn_ItemFiyat.Name = "btn_ItemFiyat";
            this.btn_ItemFiyat.Size = new System.Drawing.Size(75, 87);
            this.btn_ItemFiyat.TabIndex = 5;
            this.btn_ItemFiyat.Text = "Market Magaza Emlak Fiyatı Ayarla";
            this.btn_ItemFiyat.UseVisualStyleBackColor = true;
            this.btn_ItemFiyat.Click += new System.EventHandler(this.btn_ItemFiyat_Click);
            // 
            // btn_EnvanterGor
            // 
            this.btn_EnvanterGor.Location = new System.Drawing.Point(681, 71);
            this.btn_EnvanterGor.Name = "btn_EnvanterGor";
            this.btn_EnvanterGor.Size = new System.Drawing.Size(107, 53);
            this.btn_EnvanterGor.TabIndex = 6;
            this.btn_EnvanterGor.Text = "Kullanıcı Envanterlerini Gör";
            this.btn_EnvanterGor.UseVisualStyleBackColor = true;
            this.btn_EnvanterGor.Click += new System.EventHandler(this.btn_EnvanterGor_Click);
            // 
            // btn_Gecmis
            // 
            this.btn_Gecmis.Location = new System.Drawing.Point(681, 130);
            this.btn_Gecmis.Name = "btn_Gecmis";
            this.btn_Gecmis.Size = new System.Drawing.Size(107, 53);
            this.btn_Gecmis.TabIndex = 7;
            this.btn_Gecmis.Text = "Kullanıcı İşlem Geçmişi Gör";
            this.btn_Gecmis.UseVisualStyleBackColor = true;
            this.btn_Gecmis.Click += new System.EventHandler(this.btn_Gecmis_Click);
            // 
            // btn_Alan
            // 
            this.btn_Alan.Location = new System.Drawing.Point(681, 189);
            this.btn_Alan.Name = "btn_Alan";
            this.btn_Alan.Size = new System.Drawing.Size(107, 53);
            this.btn_Alan.TabIndex = 8;
            this.btn_Alan.Text = "Oyun Alanını Gör";
            this.btn_Alan.UseVisualStyleBackColor = true;
            this.btn_Alan.Click += new System.EventHandler(this.btn_Alan_Click);
            // 
            // btn_Ucret
            // 
            this.btn_Ucret.Location = new System.Drawing.Point(681, 307);
            this.btn_Ucret.Name = "btn_Ucret";
            this.btn_Ucret.Size = new System.Drawing.Size(107, 53);
            this.btn_Ucret.TabIndex = 9;
            this.btn_Ucret.Text = "Kullanıcı İşletme Ücretlerini Gör";
            this.btn_Ucret.UseVisualStyleBackColor = true;
            this.btn_Ucret.Click += new System.EventHandler(this.btn_Ucret_Click);
            // 
            // btn_IsDurumu
            // 
            this.btn_IsDurumu.Location = new System.Drawing.Point(681, 248);
            this.btn_IsDurumu.Name = "btn_IsDurumu";
            this.btn_IsDurumu.Size = new System.Drawing.Size(107, 53);
            this.btn_IsDurumu.TabIndex = 10;
            this.btn_IsDurumu.Text = "Kullanıcı İş Durumu Gör";
            this.btn_IsDurumu.UseVisualStyleBackColor = true;
            this.btn_IsDurumu.Click += new System.EventHandler(this.btn_IsDurumu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(582, 426);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_Kullanici
            // 
            this.btn_Kullanici.Location = new System.Drawing.Point(681, 12);
            this.btn_Kullanici.Name = "btn_Kullanici";
            this.btn_Kullanici.Size = new System.Drawing.Size(107, 53);
            this.btn_Kullanici.TabIndex = 12;
            this.btn_Kullanici.Text = "Kullanıcıları Gör";
            this.btn_Kullanici.UseVisualStyleBackColor = true;
            this.btn_Kullanici.Click += new System.EventHandler(this.btn_Kullanici_Click);
            // 
            // btn_Emlak
            // 
            this.btn_Emlak.Location = new System.Drawing.Point(681, 366);
            this.btn_Emlak.Name = "btn_Emlak";
            this.btn_Emlak.Size = new System.Drawing.Size(107, 53);
            this.btn_Emlak.TabIndex = 13;
            this.btn_Emlak.Text = "Emlak Geçmişi Gör";
            this.btn_Emlak.UseVisualStyleBackColor = true;
            this.btn_Emlak.Click += new System.EventHandler(this.btn_Emlak_Click);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Emlak);
            this.Controls.Add(this.btn_Kullanici);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_IsDurumu);
            this.Controls.Add(this.btn_Ucret);
            this.Controls.Add(this.btn_Alan);
            this.Controls.Add(this.btn_Gecmis);
            this.Controls.Add(this.btn_EnvanterGor);
            this.Controls.Add(this.btn_ItemFiyat);
            this.Controls.Add(this.btn_Sabit);
            this.Controls.Add(this.btn_Isletme_Ucret);
            this.Controls.Add(this.btn_Giderler);
            this.Controls.Add(this.btn_Envanter);
            this.Controls.Add(this.btn_AlanVeTarih);
            this.Name = "Yonetici";
            this.Text = "Yonetici";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_AlanVeTarih;
        private Button btn_Envanter;
        private Button btn_Giderler;
        private Button btn_Isletme_Ucret;
        private Button btn_Sabit;
        private Button btn_ItemFiyat;
        private Button btn_EnvanterGor;
        private Button btn_Gecmis;
        private Button btn_Alan;
        private Button btn_Ucret;
        private Button btn_IsDurumu;
        private DataGridView dataGridView1;
        private Button btn_Kullanici;
        private Button btn_Emlak;
    }
}