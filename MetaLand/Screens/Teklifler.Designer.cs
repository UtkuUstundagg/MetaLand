namespace MetaLand.Screens
{
    partial class Teklifler
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
            this.brn_Sec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(734, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // brn_Sec
            // 
            this.brn_Sec.Location = new System.Drawing.Point(752, 12);
            this.brn_Sec.Name = "brn_Sec";
            this.brn_Sec.Size = new System.Drawing.Size(39, 426);
            this.brn_Sec.TabIndex = 1;
            this.brn_Sec.Text = "Seç";
            this.brn_Sec.UseVisualStyleBackColor = true;
            this.brn_Sec.Click += new System.EventHandler(this.brn_Sec_Click);
            // 
            // Teklifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brn_Sec);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Teklifler";
            this.Text = "Teklifler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button brn_Sec;
    }
}