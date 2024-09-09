namespace MetaLand
{
    partial class Login
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
            this.btn_Giris = new System.Windows.Forms.Button();
            this.tb_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(120, 154);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(86, 35);
            this.btn_Giris.TabIndex = 0;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // tb_KullaniciAdi
            // 
            this.tb_KullaniciAdi.Location = new System.Drawing.Point(202, 63);
            this.tb_KullaniciAdi.Name = "tb_KullaniciAdi";
            this.tb_KullaniciAdi.Size = new System.Drawing.Size(100, 23);
            this.tb_KullaniciAdi.TabIndex = 2;
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Location = new System.Drawing.Point(202, 104);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(100, 23);
            this.tb_Sifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.Location = new System.Drawing.Point(216, 154);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(86, 35);
            this.btn_KayitOl.TabIndex = 6;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = true;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 249);
            this.Controls.Add(this.btn_KayitOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_KullaniciAdi);
            this.Controls.Add(this.btn_Giris);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Giris;
        private TextBox tb_KullaniciAdi;
        private TextBox tb_Sifre;
        private Label label1;
        private Label label2;
        private Button btn_KayitOl;
    }
}