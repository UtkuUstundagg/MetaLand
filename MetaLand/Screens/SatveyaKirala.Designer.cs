namespace MetaLand.Screens
{
    partial class SatveyaKirala
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sat = new System.Windows.Forms.Button();
            this.btn_Kirala = new System.Windows.Forms.Button();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.btn_Belirle = new System.Windows.Forms.Button();
            this.tb_Fiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(740, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Sat
            // 
            this.btn_Sat.Location = new System.Drawing.Point(12, 260);
            this.btn_Sat.Name = "btn_Sat";
            this.btn_Sat.Size = new System.Drawing.Size(75, 23);
            this.btn_Sat.TabIndex = 1;
            this.btn_Sat.Text = "Sat!";
            this.btn_Sat.UseVisualStyleBackColor = true;
            this.btn_Sat.Click += new System.EventHandler(this.btn_Sat_Click);
            // 
            // btn_Kirala
            // 
            this.btn_Kirala.Location = new System.Drawing.Point(93, 260);
            this.btn_Kirala.Name = "btn_Kirala";
            this.btn_Kirala.Size = new System.Drawing.Size(75, 23);
            this.btn_Kirala.TabIndex = 2;
            this.btn_Kirala.Text = "Kirala!";
            this.btn_Kirala.UseVisualStyleBackColor = true;
            this.btn_Kirala.Click += new System.EventHandler(this.btn_Kirala_Click);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Location = new System.Drawing.Point(174, 260);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_Iptal.TabIndex = 3;
            this.btn_Iptal.Text = "İptal Et!";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // btn_Belirle
            // 
            this.btn_Belirle.Location = new System.Drawing.Point(677, 260);
            this.btn_Belirle.Name = "btn_Belirle";
            this.btn_Belirle.Size = new System.Drawing.Size(75, 23);
            this.btn_Belirle.TabIndex = 4;
            this.btn_Belirle.Text = "Belirle!";
            this.btn_Belirle.UseVisualStyleBackColor = true;
            this.btn_Belirle.Click += new System.EventHandler(this.btn_Belirle_Click);
            // 
            // tb_Fiyat
            // 
            this.tb_Fiyat.Location = new System.Drawing.Point(571, 260);
            this.tb_Fiyat.Name = "tb_Fiyat";
            this.tb_Fiyat.Size = new System.Drawing.Size(100, 23);
            this.tb_Fiyat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seçtiğiniz Alanın Fiyatı:";
            // 
            // SatveyaKirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Fiyat);
            this.Controls.Add(this.btn_Belirle);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_Kirala);
            this.Controls.Add(this.btn_Sat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatveyaKirala";
            this.Text = "SatveyaKirala";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Sat;
        private Button btn_Kirala;
        private Button btn_Iptal;
        private Button btn_Belirle;
        private TextBox tb_Fiyat;
        private Label label1;
    }
}