namespace MetaLand
{
    partial class KayitOl
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
            this.tb_KulAdi = new System.Windows.Forms.TextBox();
            this.tb_Soyadi = new System.Windows.Forms.TextBox();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Şifresi:";
            // 
            // tb_KulAdi
            // 
            this.tb_KulAdi.Location = new System.Drawing.Point(130, 48);
            this.tb_KulAdi.Name = "tb_KulAdi";
            this.tb_KulAdi.Size = new System.Drawing.Size(100, 23);
            this.tb_KulAdi.TabIndex = 3;
            // 
            // tb_Soyadi
            // 
            this.tb_Soyadi.Location = new System.Drawing.Point(130, 82);
            this.tb_Soyadi.Name = "tb_Soyadi";
            this.tb_Soyadi.Size = new System.Drawing.Size(100, 23);
            this.tb_Soyadi.TabIndex = 4;
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Location = new System.Drawing.Point(130, 114);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(100, 23);
            this.tb_Sifre.TabIndex = 5;
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Location = new System.Drawing.Point(130, 165);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(100, 23);
            this.btn_Kayit.TabIndex = 6;
            this.btn_Kayit.Text = "Kayıt Ol!";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 246);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_Soyadi);
            this.Controls.Add(this.tb_KulAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_KulAdi;
        private TextBox tb_Soyadi;
        private TextBox tb_Sifre;
        private Button btn_Kayit;
    }
}