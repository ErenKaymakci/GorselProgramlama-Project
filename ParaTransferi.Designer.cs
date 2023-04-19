namespace GelismisATM
{
    partial class ParaTransferi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userControlTextBoxIBAN1 = new GelismisATM.UserControlTextBoxIBAN();
            this.userControlTextBoxTutar = new GelismisATM.UserControlTextBox();
            this.classComboBoxOdemeTipi = new GelismisATM.ClassComboBox();
            this.classButtonGeri = new GelismisATM.ClassButton();
            this.classButtonIleri = new GelismisATM.ClassButton();
            this.classComboBoxHesapTuru = new GelismisATM.ClassComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ödeme Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alıcı IBAN Bilgisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hesap Türü";
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
            this.userControlTextBoxIBAN1.Location = new System.Drawing.Point(85, 229);
            this.userControlTextBoxIBAN1.Multiline = false;
            this.userControlTextBoxIBAN1.Name = "userControlTextBoxIBAN1";
            this.userControlTextBoxIBAN1.Padding = new System.Windows.Forms.Padding(15, 19, 7, 7);
            this.userControlTextBoxIBAN1.PasswordChar = false;
            this.userControlTextBoxIBAN1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userControlTextBoxIBAN1.PlaceholderText = "";
            this.userControlTextBoxIBAN1.Size = new System.Drawing.Size(800, 56);
            this.userControlTextBoxIBAN1.TabIndex = 21;
            this.userControlTextBoxIBAN1.Texts = "TR                            ";
            this.userControlTextBoxIBAN1.UnderlinedStyle = false;
            // 
            // userControlTextBoxTutar
            // 
            this.userControlTextBoxTutar.BackColor = System.Drawing.SystemColors.Window;
            this.userControlTextBoxTutar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.userControlTextBoxTutar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userControlTextBoxTutar.BorderRadius = 10;
            this.userControlTextBoxTutar.BorderSize = 3;
            this.userControlTextBoxTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userControlTextBoxTutar.ForeColor = System.Drawing.Color.Black;
            this.userControlTextBoxTutar.Location = new System.Drawing.Point(85, 351);
            this.userControlTextBoxTutar.Multiline = true;
            this.userControlTextBoxTutar.Name = "userControlTextBoxTutar";
            this.userControlTextBoxTutar.Padding = new System.Windows.Forms.Padding(15, 18, 7, 7);
            this.userControlTextBoxTutar.PasswordChar = false;
            this.userControlTextBoxTutar.PlaceholderColor = System.Drawing.Color.Black;
            this.userControlTextBoxTutar.PlaceholderText = "";
            this.userControlTextBoxTutar.Size = new System.Drawing.Size(800, 55);
            this.userControlTextBoxTutar.TabIndex = 15;
            this.userControlTextBoxTutar.Texts = "";
            this.userControlTextBoxTutar.UnderlinedStyle = false;
            // 
            // classComboBoxOdemeTipi
            // 
            this.classComboBoxOdemeTipi.AutoCompleteCustomSource.AddRange(new string[] {
            "Eğitim",
            "Kira",
            "E-Ticaret",
            "Bireysel",
            "Diğer"});
            this.classComboBoxOdemeTipi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classComboBoxOdemeTipi.BorderColor = System.Drawing.Color.DimGray;
            this.classComboBoxOdemeTipi.BorderRadius = 1;
            this.classComboBoxOdemeTipi.BorderSize = 3;
            this.classComboBoxOdemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.classComboBoxOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classComboBoxOdemeTipi.ForeColor = System.Drawing.Color.Black;
            this.classComboBoxOdemeTipi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classComboBoxOdemeTipi.Items.AddRange(new object[] {
            "Eğitim",
            "Kira",
            "E-Ticaret",
            "Bireysel",
            "Diğer"});
            this.classComboBoxOdemeTipi.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.classComboBoxOdemeTipi.ListTextColor = System.Drawing.Color.DimGray;
            this.classComboBoxOdemeTipi.Location = new System.Drawing.Point(85, 495);
            this.classComboBoxOdemeTipi.MinimumSize = new System.Drawing.Size(200, 30);
            this.classComboBoxOdemeTipi.Name = "classComboBoxOdemeTipi";
            this.classComboBoxOdemeTipi.Padding = new System.Windows.Forms.Padding(3);
            this.classComboBoxOdemeTipi.Size = new System.Drawing.Size(800, 55);
            this.classComboBoxOdemeTipi.TabIndex = 13;
            this.classComboBoxOdemeTipi.Texts = "";
            // 
            // classButtonGeri
            // 
            this.classButtonGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classButtonGeri.BorderColor = System.Drawing.Color.White;
            this.classButtonGeri.BorderRadius = 7;
            this.classButtonGeri.BorderSize = 3;
            this.classButtonGeri.FlatAppearance.BorderSize = 0;
            this.classButtonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButtonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classButtonGeri.ForeColor = System.Drawing.Color.White;
            this.classButtonGeri.Location = new System.Drawing.Point(1, 656);
            this.classButtonGeri.Name = "classButtonGeri";
            this.classButtonGeri.Size = new System.Drawing.Size(300, 65);
            this.classButtonGeri.TabIndex = 12;
            this.classButtonGeri.Text = "GERİ";
            this.classButtonGeri.UseVisualStyleBackColor = false;
            this.classButtonGeri.Click += new System.EventHandler(this.classButton2_Click);
            // 
            // classButtonIleri
            // 
            this.classButtonIleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classButtonIleri.BorderColor = System.Drawing.Color.White;
            this.classButtonIleri.BorderRadius = 7;
            this.classButtonIleri.BorderSize = 3;
            this.classButtonIleri.FlatAppearance.BorderSize = 0;
            this.classButtonIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButtonIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classButtonIleri.ForeColor = System.Drawing.Color.White;
            this.classButtonIleri.Location = new System.Drawing.Point(706, 656);
            this.classButtonIleri.Name = "classButtonIleri";
            this.classButtonIleri.Size = new System.Drawing.Size(300, 65);
            this.classButtonIleri.TabIndex = 11;
            this.classButtonIleri.Text = "İLERİ";
            this.classButtonIleri.UseVisualStyleBackColor = false;
            this.classButtonIleri.Click += new System.EventHandler(this.classButton1_Click);
            // 
            // classComboBoxHesapTuru
            // 
            this.classComboBoxHesapTuru.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classComboBoxHesapTuru.BorderColor = System.Drawing.Color.DimGray;
            this.classComboBoxHesapTuru.BorderRadius = 1;
            this.classComboBoxHesapTuru.BorderSize = 3;
            this.classComboBoxHesapTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.classComboBoxHesapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classComboBoxHesapTuru.ForeColor = System.Drawing.Color.DimGray;
            this.classComboBoxHesapTuru.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.classComboBoxHesapTuru.Items.AddRange(new object[] {
            "Vadeli",
            "Vadesiz",
            "Döviz"});
            this.classComboBoxHesapTuru.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.classComboBoxHesapTuru.ListTextColor = System.Drawing.Color.DimGray;
            this.classComboBoxHesapTuru.Location = new System.Drawing.Point(85, 83);
            this.classComboBoxHesapTuru.MinimumSize = new System.Drawing.Size(200, 30);
            this.classComboBoxHesapTuru.Name = "classComboBoxHesapTuru";
            this.classComboBoxHesapTuru.Padding = new System.Windows.Forms.Padding(3);
            this.classComboBoxHesapTuru.Size = new System.Drawing.Size(800, 55);
            this.classComboBoxHesapTuru.TabIndex = 10;
            this.classComboBoxHesapTuru.Texts = "";
            // 
            // ParaTransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.userControlTextBoxIBAN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlTextBoxTutar);
            this.Controls.Add(this.classComboBoxOdemeTipi);
            this.Controls.Add(this.classButtonGeri);
            this.Controls.Add(this.classButtonIleri);
            this.Controls.Add(this.classComboBoxHesapTuru);
            this.Name = "ParaTransferi";
            this.Text = "ParaTransferi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParaTransferi_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControlTextBox userControlTextBoxTutar;
        private ClassComboBox classComboBoxOdemeTipi;
        private ClassButton classButtonGeri;
        private ClassButton classButtonIleri;
        private ClassComboBox classComboBoxHesapTuru;
        private UserControlTextBoxIBAN userControlTextBoxIBAN1;
    }
}