namespace GelismisATM
{
    partial class UserControlMoneyTransfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControlTextBox2 = new GelismisATM.UserControlTextBox();
            this.classComboBox2 = new GelismisATM.ClassComboBox();
            this.classButton2 = new GelismisATM.ClassButton();
            this.classButton1 = new GelismisATM.ClassButton();
            this.classComboBox1 = new GelismisATM.ClassComboBox();
            this.userControlIslemBitisEkrani1 = new GelismisATM.UserControlIslemBitisEkrani();
            this.userControlTextBoxIBAN1 = new GelismisATM.UserControlTextBoxIBAN();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hesap Türü";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alıcı IBAN Bilgisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ödeme Tipi";
            // 
            // userControlTextBox2
            // 
            this.userControlTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.userControlTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.userControlTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userControlTextBox2.BorderRadius = 10;
            this.userControlTextBox2.BorderSize = 3;
            this.userControlTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.userControlTextBox2.Location = new System.Drawing.Point(95, 396);
            this.userControlTextBox2.Multiline = true;
            this.userControlTextBox2.Name = "userControlTextBox2";
            this.userControlTextBox2.Padding = new System.Windows.Forms.Padding(10, 18, 7, 7);
            this.userControlTextBox2.PasswordChar = false;
            this.userControlTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userControlTextBox2.PlaceholderText = "";
            this.userControlTextBox2.Size = new System.Drawing.Size(800, 55);
            this.userControlTextBox2.TabIndex = 5;
            this.userControlTextBox2.Texts = "";
            this.userControlTextBox2.UnderlinedStyle = false;
            // 
            // classComboBox2
            // 
            this.classComboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classComboBox2.BorderColor = System.Drawing.Color.DimGray;
            this.classComboBox2.BorderRadius = 1;
            this.classComboBox2.BorderSize = 3;
            this.classComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.classComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.classComboBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classComboBox2.Items.AddRange(new object[] {
            "Eğitim",
            "Kira",
            "E-Ticaret",
            "Bireysel",
            "Diğer"});
            this.classComboBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.classComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            this.classComboBox2.Location = new System.Drawing.Point(95, 540);
            this.classComboBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.classComboBox2.Name = "classComboBox2";
            this.classComboBox2.Padding = new System.Windows.Forms.Padding(3);
            this.classComboBox2.Size = new System.Drawing.Size(800, 55);
            this.classComboBox2.TabIndex = 3;
            this.classComboBox2.Texts = "";
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
            this.classButton2.Location = new System.Drawing.Point(1, 702);
            this.classButton2.Name = "classButton2";
            this.classButton2.Size = new System.Drawing.Size(300, 65);
            this.classButton2.TabIndex = 2;
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
            this.classButton1.Location = new System.Drawing.Point(704, 700);
            this.classButton1.Name = "classButton1";
            this.classButton1.Size = new System.Drawing.Size(300, 65);
            this.classButton1.TabIndex = 1;
            this.classButton1.Text = "İLERİ";
            this.classButton1.UseVisualStyleBackColor = false;
            this.classButton1.Click += new System.EventHandler(this.classButton1_Click);
            // 
            // classComboBox1
            // 
            this.classComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classComboBox1.BorderColor = System.Drawing.Color.DimGray;
            this.classComboBox1.BorderRadius = 1;
            this.classComboBox1.BorderSize = 3;
            this.classComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.classComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.classComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classComboBox1.Items.AddRange(new object[] {
            "Vadeli",
            "Vadesiz",
            "Döviz"});
            this.classComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.classComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.classComboBox1.Location = new System.Drawing.Point(95, 128);
            this.classComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.classComboBox1.Name = "classComboBox1";
            this.classComboBox1.Padding = new System.Windows.Forms.Padding(3);
            this.classComboBox1.Size = new System.Drawing.Size(800, 55);
            this.classComboBox1.TabIndex = 0;
            this.classComboBox1.Texts = "";
            // 
            // userControlIslemBitisEkrani1
            // 
            this.userControlIslemBitisEkrani1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlIslemBitisEkrani1.Location = new System.Drawing.Point(1010, 549);
            this.userControlIslemBitisEkrani1.Name = "userControlIslemBitisEkrani1";
            this.userControlIslemBitisEkrani1.Size = new System.Drawing.Size(1024, 768);
            this.userControlIslemBitisEkrani1.TabIndex = 10;
            // 
            // userControlTextBoxIBAN1
            // 
            this.userControlTextBoxIBAN1.BackColor = System.Drawing.SystemColors.Window;
            this.userControlTextBoxIBAN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.userControlTextBoxIBAN1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userControlTextBoxIBAN1.BorderRadius = 10;
            this.userControlTextBoxIBAN1.BorderSize = 3;
            this.userControlTextBoxIBAN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlTextBoxIBAN1.ForeColor = System.Drawing.Color.Black;
            this.userControlTextBoxIBAN1.Location = new System.Drawing.Point(95, 272);
            this.userControlTextBoxIBAN1.Multiline = false;
            this.userControlTextBoxIBAN1.Name = "userControlTextBoxIBAN1";
            this.userControlTextBoxIBAN1.Padding = new System.Windows.Forms.Padding(15, 19, 7, 7);
            this.userControlTextBoxIBAN1.PasswordChar = false;
            this.userControlTextBoxIBAN1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userControlTextBoxIBAN1.PlaceholderText = "";
            this.userControlTextBoxIBAN1.Size = new System.Drawing.Size(800, 57);
            this.userControlTextBoxIBAN1.TabIndex = 22;
            this.userControlTextBoxIBAN1.Texts = "TR                            ";
            this.userControlTextBoxIBAN1.UnderlinedStyle = false;
            // 
            // UserControlMoneyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.userControlTextBoxIBAN1);
            this.Controls.Add(this.userControlIslemBitisEkrani1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlTextBox2);
            this.Controls.Add(this.classComboBox2);
            this.Controls.Add(this.classButton2);
            this.Controls.Add(this.classButton1);
            this.Controls.Add(this.classComboBox1);
            this.Name = "UserControlMoneyTransfer";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassComboBox classComboBox1;
        private ClassButton classButton1;
        private ClassButton classButton2;
        private ClassComboBox classComboBox2;
        private UserControlTextBox userControlTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private UserControlIslemBitisEkrani userControlIslemBitisEkrani1;
        private UserControlTextBoxIBAN userControlTextBoxIBAN1;
    }
}
