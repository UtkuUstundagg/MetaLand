namespace MetaLand.Screens
{
    partial class Detaylar
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
            this.btn_Giderler = new System.Windows.Forms.Button();
            this.btn_Varlik = new System.Windows.Forms.Button();
            this.btn_SatinAlma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Giderler
            // 
            this.btn_Giderler.Location = new System.Drawing.Point(12, 257);
            this.btn_Giderler.Name = "btn_Giderler";
            this.btn_Giderler.Size = new System.Drawing.Size(84, 36);
            this.btn_Giderler.TabIndex = 1;
            this.btn_Giderler.Text = "Giderler";
            this.btn_Giderler.UseVisualStyleBackColor = true;
            this.btn_Giderler.Click += new System.EventHandler(this.btn_Giderler_Click);
            // 
            // btn_Varlik
            // 
            this.btn_Varlik.Location = new System.Drawing.Point(192, 257);
            this.btn_Varlik.Name = "btn_Varlik";
            this.btn_Varlik.Size = new System.Drawing.Size(84, 36);
            this.btn_Varlik.TabIndex = 2;
            this.btn_Varlik.Text = "Varlıklar";
            this.btn_Varlik.UseVisualStyleBackColor = true;
            this.btn_Varlik.Click += new System.EventHandler(this.btn_Varlik_Click);
            // 
            // btn_SatinAlma
            // 
            this.btn_SatinAlma.Location = new System.Drawing.Point(102, 257);
            this.btn_SatinAlma.Name = "btn_SatinAlma";
            this.btn_SatinAlma.Size = new System.Drawing.Size(84, 36);
            this.btn_SatinAlma.TabIndex = 3;
            this.btn_SatinAlma.Text = "Satın Alımlar";
            this.btn_SatinAlma.UseVisualStyleBackColor = true;
            this.btn_SatinAlma.Click += new System.EventHandler(this.btn_SatinAlma_Click);
            // 
            // Detaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.btn_SatinAlma);
            this.Controls.Add(this.btn_Varlik);
            this.Controls.Add(this.btn_Giderler);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Detaylar";
            this.Text = "Detaylar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Giderler;
        private Button btn_Varlik;
        private Button btn_SatinAlma;
    }
}