namespace MetaLand.Screens
{
    partial class SabitGelirVeOran
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
            this.tb_Miktar = new System.Windows.Forms.TextBox();
            this.tb_Oran = new System.Windows.Forms.TextBox();
            this.btn_Ayarla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabit Gelir Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sabit Gelir Oranı:";
            // 
            // tb_Miktar
            // 
            this.tb_Miktar.Location = new System.Drawing.Point(135, 17);
            this.tb_Miktar.Name = "tb_Miktar";
            this.tb_Miktar.Size = new System.Drawing.Size(100, 23);
            this.tb_Miktar.TabIndex = 2;
            // 
            // tb_Oran
            // 
            this.tb_Oran.Location = new System.Drawing.Point(135, 52);
            this.tb_Oran.Name = "tb_Oran";
            this.tb_Oran.Size = new System.Drawing.Size(100, 23);
            this.tb_Oran.TabIndex = 3;
            // 
            // btn_Ayarla
            // 
            this.btn_Ayarla.Location = new System.Drawing.Point(135, 97);
            this.btn_Ayarla.Name = "btn_Ayarla";
            this.btn_Ayarla.Size = new System.Drawing.Size(100, 23);
            this.btn_Ayarla.TabIndex = 4;
            this.btn_Ayarla.Text = "Ayarla!";
            this.btn_Ayarla.UseVisualStyleBackColor = true;
            this.btn_Ayarla.Click += new System.EventHandler(this.btn_Ayarla_Click);
            // 
            // SabitGelirVeOran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 146);
            this.Controls.Add(this.btn_Ayarla);
            this.Controls.Add(this.tb_Oran);
            this.Controls.Add(this.tb_Miktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SabitGelirVeOran";
            this.Text = "SabitGelirVeOran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_Miktar;
        private TextBox tb_Oran;
        private Button btn_Ayarla;
    }
}