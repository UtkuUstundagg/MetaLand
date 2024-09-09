namespace MetaLand
{
    partial class Isletme_Ucretleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Magaza = new System.Windows.Forms.TextBox();
            this.tb_Market = new System.Windows.Forms.TextBox();
            this.tb_Emlak = new System.Windows.Forms.TextBox();
            this.btn_Ayarla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Kur = new System.Windows.Forms.TextBox();
            this.tb_Kiralama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mağaza İşletme Ücreti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emlak İşletme Ücreti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Market İşletme Ücreti:";
            // 
            // tb_Magaza
            // 
            this.tb_Magaza.Location = new System.Drawing.Point(144, 12);
            this.tb_Magaza.Name = "tb_Magaza";
            this.tb_Magaza.Size = new System.Drawing.Size(100, 23);
            this.tb_Magaza.TabIndex = 3;
            // 
            // tb_Market
            // 
            this.tb_Market.Location = new System.Drawing.Point(144, 46);
            this.tb_Market.Name = "tb_Market";
            this.tb_Market.Size = new System.Drawing.Size(100, 23);
            this.tb_Market.TabIndex = 4;
            // 
            // tb_Emlak
            // 
            this.tb_Emlak.Location = new System.Drawing.Point(144, 79);
            this.tb_Emlak.Name = "tb_Emlak";
            this.tb_Emlak.Size = new System.Drawing.Size(100, 23);
            this.tb_Emlak.TabIndex = 5;
            // 
            // btn_Ayarla
            // 
            this.btn_Ayarla.Location = new System.Drawing.Point(144, 188);
            this.btn_Ayarla.Name = "btn_Ayarla";
            this.btn_Ayarla.Size = new System.Drawing.Size(100, 23);
            this.btn_Ayarla.TabIndex = 6;
            this.btn_Ayarla.Text = "Ayarla!";
            this.btn_Ayarla.UseVisualStyleBackColor = true;
            this.btn_Ayarla.Click += new System.EventHandler(this.btn_Ayarla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "İşletme Kurma Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "İşletme Kiralama Fiyatı:";
            // 
            // tb_Kur
            // 
            this.tb_Kur.Location = new System.Drawing.Point(144, 111);
            this.tb_Kur.Name = "tb_Kur";
            this.tb_Kur.Size = new System.Drawing.Size(100, 23);
            this.tb_Kur.TabIndex = 9;
            // 
            // tb_Kiralama
            // 
            this.tb_Kiralama.Location = new System.Drawing.Point(144, 145);
            this.tb_Kiralama.Name = "tb_Kiralama";
            this.tb_Kiralama.Size = new System.Drawing.Size(100, 23);
            this.tb_Kiralama.TabIndex = 10;
            // 
            // Isletme_Ucretleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 220);
            this.Controls.Add(this.tb_Kiralama);
            this.Controls.Add(this.tb_Kur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Ayarla);
            this.Controls.Add(this.tb_Emlak);
            this.Controls.Add(this.tb_Market);
            this.Controls.Add(this.tb_Magaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Isletme_Ucretleri";
            this.Text = "Isletme_Ucretleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_Magaza;
        private TextBox tb_Market;
        private TextBox tb_Emlak;
        private Button btn_Ayarla;
        private Label label4;
        private Label label5;
        private TextBox tb_Kur;
        private TextBox tb_Kiralama;
    }
}