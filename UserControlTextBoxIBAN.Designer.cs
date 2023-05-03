namespace GelismisATM
{
    partial class UserControlTextBoxIBAN
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Mask = "TR99 9999 9999 9999 9999 9999 99";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 17);
            this.textBox1.TabIndex = 0;
            // 
            // UserControlTextBoxIBAN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "UserControlTextBoxIBAN";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // UserControlTextBoxIBAN
        //    // 
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        //    this.Name = "UserControlTextBoxIBAN";
        //    this.Padding = new System.Windows.Forms.Padding(7);
        //    this.Size = new System.Drawing.Size(250, 30);
        //    this.ResumeLayout(false);

        //}

        #endregion
        private System.Windows.Forms.MaskedTextBox textBox1;
    }
}
