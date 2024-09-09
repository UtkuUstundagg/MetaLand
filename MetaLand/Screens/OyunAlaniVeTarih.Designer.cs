namespace MetaLand
{
    partial class OyunAlaniVeTarih
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
            this.tb_OyunAlani = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_OyunAlaniVeTarihAyarla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Alanı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih: ";
            // 
            // tb_OyunAlani
            // 
            this.tb_OyunAlani.Location = new System.Drawing.Point(101, 27);
            this.tb_OyunAlani.Name = "tb_OyunAlani";
            this.tb_OyunAlani.Size = new System.Drawing.Size(191, 23);
            this.tb_OyunAlani.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btn_OyunAlaniVeTarihAyarla
            // 
            this.btn_OyunAlaniVeTarihAyarla.Location = new System.Drawing.Point(124, 115);
            this.btn_OyunAlaniVeTarihAyarla.Name = "btn_OyunAlaniVeTarihAyarla";
            this.btn_OyunAlaniVeTarihAyarla.Size = new System.Drawing.Size(75, 23);
            this.btn_OyunAlaniVeTarihAyarla.TabIndex = 4;
            this.btn_OyunAlaniVeTarihAyarla.Text = "Ayarla";
            this.btn_OyunAlaniVeTarihAyarla.UseVisualStyleBackColor = true;
            this.btn_OyunAlaniVeTarihAyarla.Click += new System.EventHandler(this.btn_OyunAlaniVeTarihAyarla_Click);
            // 
            // OyunAlaniVeTarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 150);
            this.Controls.Add(this.btn_OyunAlaniVeTarihAyarla);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_OyunAlani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "OyunAlaniVeTarih";
            this.Text = "OyunAlaniVeTarih";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_OyunAlani;
        private DateTimePicker dateTimePicker1;
        private Button btn_OyunAlaniVeTarihAyarla;
    }
}