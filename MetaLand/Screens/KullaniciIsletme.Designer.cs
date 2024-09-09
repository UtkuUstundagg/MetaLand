namespace MetaLand.Screens
{
    partial class KullaniciIsletme
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
            this.tb_Market = new System.Windows.Forms.TextBox();
            this.tb_Magaza = new System.Windows.Forms.TextBox();
            this.tb_Emlak = new System.Windows.Forms.TextBox();
            this.btn_Ayarla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Ücreti: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Magaza Ücreti: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emlak Komisyonu %:";
            // 
            // tb_Market
            // 
            this.tb_Market.Location = new System.Drawing.Point(140, 18);
            this.tb_Market.Name = "tb_Market";
            this.tb_Market.Size = new System.Drawing.Size(100, 23);
            this.tb_Market.TabIndex = 3;
            // 
            // tb_Magaza
            // 
            this.tb_Magaza.Location = new System.Drawing.Point(140, 53);
            this.tb_Magaza.Name = "tb_Magaza";
            this.tb_Magaza.Size = new System.Drawing.Size(100, 23);
            this.tb_Magaza.TabIndex = 4;
            // 
            // tb_Emlak
            // 
            this.tb_Emlak.Location = new System.Drawing.Point(163, 92);
            this.tb_Emlak.Name = "tb_Emlak";
            this.tb_Emlak.Size = new System.Drawing.Size(100, 23);
            this.tb_Emlak.TabIndex = 5;
            // 
            // btn_Ayarla
            // 
            this.btn_Ayarla.Location = new System.Drawing.Point(163, 140);
            this.btn_Ayarla.Name = "btn_Ayarla";
            this.btn_Ayarla.Size = new System.Drawing.Size(100, 23);
            this.btn_Ayarla.TabIndex = 6;
            this.btn_Ayarla.Text = "Ayarla!";
            this.btn_Ayarla.UseVisualStyleBackColor = true;
            this.btn_Ayarla.Click += new System.EventHandler(this.btn_Ayarla_Click);
            // 
            // KullaniciIsletme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 176);
            this.Controls.Add(this.btn_Ayarla);
            this.Controls.Add(this.tb_Emlak);
            this.Controls.Add(this.tb_Magaza);
            this.Controls.Add(this.tb_Market);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "KullaniciIsletme";
            this.Text = "KullaniciIsletme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_Market;
        private TextBox tb_Magaza;
        private TextBox tb_Emlak;
        private Button btn_Ayarla;
    }
}