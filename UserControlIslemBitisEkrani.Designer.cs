namespace GelismisATM
{
    partial class UserControlIslemBitisEkrani
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlIslemBitisEkrani));
            this.userControlTextBox1 = new GelismisATM.UserControlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classPanel1 = new GelismisATM.ClassPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classButton2 = new GelismisATM.ClassButton();
            this.classButton1 = new GelismisATM.ClassButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.classPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlTextBox1
            // 
            this.userControlTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlTextBox1.BorderColor = System.Drawing.Color.White;
            this.userControlTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userControlTextBox1.BorderRadius = 0;
            this.userControlTextBox1.BorderSize = 2;
            this.userControlTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlTextBox1.ForeColor = System.Drawing.Color.White;
            this.userControlTextBox1.Location = new System.Drawing.Point(275, 550);
            this.userControlTextBox1.Multiline = false;
            this.userControlTextBox1.Name = "userControlTextBox1";
            this.userControlTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.userControlTextBox1.PasswordChar = false;
            this.userControlTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userControlTextBox1.PlaceholderText = "";
            this.userControlTextBox1.Size = new System.Drawing.Size(464, 44);
            this.userControlTextBox1.TabIndex = 20;
            this.userControlTextBox1.Texts = "BAŞKA İŞLEM YAPMAK İSTER MİSİNİZ ?";
            this.userControlTextBox1.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞTİ !";
            // 
            // classPanel1
            // 
            this.classPanel1.BackColor = System.Drawing.Color.White;
            this.classPanel1.BorderRadius = 30;
            this.classPanel1.Controls.Add(this.pictureBox1);
            this.classPanel1.Controls.Add(this.label1);
            this.classPanel1.ForeColor = System.Drawing.Color.Black;
            this.classPanel1.GradientAngle = 90F;
            this.classPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.classPanel1.GradientTopColor = System.Drawing.Color.White;
            this.classPanel1.Location = new System.Drawing.Point(150, 129);
            this.classPanel1.Name = "classPanel1";
            this.classPanel1.Size = new System.Drawing.Size(725, 275);
            this.classPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // classButton2
            // 
            this.classButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classButton2.BorderColor = System.Drawing.Color.White;
            this.classButton2.BorderRadius = 7;
            this.classButton2.BorderSize = 3;
            this.classButton2.FlatAppearance.BorderSize = 0;
            this.classButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classButton2.ForeColor = System.Drawing.Color.White;
            this.classButton2.Location = new System.Drawing.Point(3, 700);
            this.classButton2.Name = "classButton2";
            this.classButton2.Size = new System.Drawing.Size(300, 65);
            this.classButton2.TabIndex = 22;
            this.classButton2.Text = "GERİ";
            this.classButton2.UseVisualStyleBackColor = false;
            this.classButton2.Click += new System.EventHandler(this.classButton2_Click);
            // 
            // classButton1
            // 
            this.classButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classButton1.BorderColor = System.Drawing.Color.White;
            this.classButton1.BorderRadius = 7;
            this.classButton1.BorderSize = 3;
            this.classButton1.FlatAppearance.BorderSize = 0;
            this.classButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classButton1.ForeColor = System.Drawing.Color.White;
            this.classButton1.Location = new System.Drawing.Point(724, 700);
            this.classButton1.Name = "classButton1";
            this.classButton1.Size = new System.Drawing.Size(300, 65);
            this.classButton1.TabIndex = 21;
            this.classButton1.Text = "İLERİ";
            this.classButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.panel1.Location = new System.Drawing.Point(147, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 6);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.panel2.Location = new System.Drawing.Point(150, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 6);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.panel3.Location = new System.Drawing.Point(138, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 304);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.panel4.Location = new System.Drawing.Point(881, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 304);
            this.panel4.TabIndex = 25;
            // 
            // UserControlIslemBitisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classButton2);
            this.Controls.Add(this.classButton1);
            this.Controls.Add(this.userControlTextBox1);
            this.Controls.Add(this.classPanel1);
            this.Name = "UserControlIslemBitisEkrani";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.UserControlIslemBitisEkrani_Load);
            this.classPanel1.ResumeLayout(false);
            this.classPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTextBox userControlTextBox1;
        private System.Windows.Forms.Label label1;
        private ClassPanel classPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ClassButton classButton2;
        private ClassButton classButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
