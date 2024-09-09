namespace MetaLand.Screens
{
    partial class Emlak
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
            this.btn_SatinAl = new System.Windows.Forms.Button();
            this.btn_Market = new System.Windows.Forms.Button();
            this.btn_Magaza = new System.Windows.Forms.Button();
            this.btn_Emlak = new System.Windows.Forms.Button();
            this.btn_Kirala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(745, 306);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_SatinAl
            // 
            this.btn_SatinAl.Location = new System.Drawing.Point(12, 324);
            this.btn_SatinAl.Name = "btn_SatinAl";
            this.btn_SatinAl.Size = new System.Drawing.Size(123, 41);
            this.btn_SatinAl.TabIndex = 4;
            this.btn_SatinAl.Text = "Satın Al!";
            this.btn_SatinAl.UseVisualStyleBackColor = true;
            this.btn_SatinAl.Click += new System.EventHandler(this.btn_SatinAl_Click);
            // 
            // btn_Market
            // 
            this.btn_Market.Location = new System.Drawing.Point(478, 325);
            this.btn_Market.Name = "btn_Market";
            this.btn_Market.Size = new System.Drawing.Size(89, 41);
            this.btn_Market.TabIndex = 5;
            this.btn_Market.Text = "Market Kur!";
            this.btn_Market.UseVisualStyleBackColor = true;
            this.btn_Market.Click += new System.EventHandler(this.btn_Market_Click);
            // 
            // btn_Magaza
            // 
            this.btn_Magaza.Location = new System.Drawing.Point(573, 325);
            this.btn_Magaza.Name = "btn_Magaza";
            this.btn_Magaza.Size = new System.Drawing.Size(89, 41);
            this.btn_Magaza.TabIndex = 6;
            this.btn_Magaza.Text = "Mağaza Kur!";
            this.btn_Magaza.UseVisualStyleBackColor = true;
            this.btn_Magaza.Click += new System.EventHandler(this.btn_Magaza_Click);
            // 
            // btn_Emlak
            // 
            this.btn_Emlak.Location = new System.Drawing.Point(668, 325);
            this.btn_Emlak.Name = "btn_Emlak";
            this.btn_Emlak.Size = new System.Drawing.Size(89, 41);
            this.btn_Emlak.TabIndex = 7;
            this.btn_Emlak.Text = "Emlak Kur!";
            this.btn_Emlak.UseVisualStyleBackColor = true;
            this.btn_Emlak.Click += new System.EventHandler(this.btn_Emlak_Click);
            // 
            // btn_Kirala
            // 
            this.btn_Kirala.Location = new System.Drawing.Point(141, 325);
            this.btn_Kirala.Name = "btn_Kirala";
            this.btn_Kirala.Size = new System.Drawing.Size(123, 40);
            this.btn_Kirala.TabIndex = 8;
            this.btn_Kirala.Text = "Kirala!";
            this.btn_Kirala.UseVisualStyleBackColor = true;
            this.btn_Kirala.Click += new System.EventHandler(this.btn_Kirala_Click);
            // 
            // Emlak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 375);
            this.Controls.Add(this.btn_Kirala);
            this.Controls.Add(this.btn_Emlak);
            this.Controls.Add(this.btn_Magaza);
            this.Controls.Add(this.btn_Market);
            this.Controls.Add(this.btn_SatinAl);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Emlak";
            this.Text = "Emlak";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private Button btn_SatinAl;
        private Button btn_Market;
        private Button btn_Magaza;
        private Button btn_Emlak;
        private Button btn_Kirala;
    }
}