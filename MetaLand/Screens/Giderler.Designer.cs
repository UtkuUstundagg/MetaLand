﻿namespace MetaLand
{
    partial class Giderler
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
            this.tb_Yiyecek = new System.Windows.Forms.TextBox();
            this.tb_Esya = new System.Windows.Forms.TextBox();
            this.tb_Para = new System.Windows.Forms.TextBox();
            this.btn_Ayarla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Yiyecek Gideri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Günlük Esya Gideri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Günlük Para Gideri:";
            // 
            // tb_Yiyecek
            // 
            this.tb_Yiyecek.Location = new System.Drawing.Point(168, 16);
            this.tb_Yiyecek.Name = "tb_Yiyecek";
            this.tb_Yiyecek.Size = new System.Drawing.Size(100, 23);
            this.tb_Yiyecek.TabIndex = 3;
            // 
            // tb_Esya
            // 
            this.tb_Esya.Location = new System.Drawing.Point(168, 44);
            this.tb_Esya.Name = "tb_Esya";
            this.tb_Esya.Size = new System.Drawing.Size(100, 23);
            this.tb_Esya.TabIndex = 4;
            // 
            // tb_Para
            // 
            this.tb_Para.Location = new System.Drawing.Point(168, 70);
            this.tb_Para.Name = "tb_Para";
            this.tb_Para.Size = new System.Drawing.Size(100, 23);
            this.tb_Para.TabIndex = 5;
            // 
            // btn_Ayarla
            // 
            this.btn_Ayarla.Location = new System.Drawing.Point(138, 116);
            this.btn_Ayarla.Name = "btn_Ayarla";
            this.btn_Ayarla.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayarla.TabIndex = 6;
            this.btn_Ayarla.Text = "Ayarla";
            this.btn_Ayarla.UseVisualStyleBackColor = true;
            this.btn_Ayarla.Click += new System.EventHandler(this.btn_Ayarla_Click);
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 165);
            this.Controls.Add(this.btn_Ayarla);
            this.Controls.Add(this.tb_Para);
            this.Controls.Add(this.tb_Esya);
            this.Controls.Add(this.tb_Yiyecek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_Yiyecek;
        private TextBox tb_Esya;
        private TextBox tb_Para;
        private Button btn_Ayarla;
    }
}