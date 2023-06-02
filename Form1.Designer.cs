namespace GelismisATM
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenuUsername = new System.Windows.Forms.Label();
            this.lblMenuWelcome = new System.Windows.Forms.Label();
            this.btnMenuStock = new System.Windows.Forms.Button();
            this.btnMenuAccounts = new System.Windows.Forms.Button();
            this.btnMenuWitdraw = new System.Windows.Forms.Button();
            this.btnMenuDeposit = new System.Windows.Forms.Button();
            this.btnMenuTransfer = new System.Windows.Forms.Button();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.btnMenuCurrency = new System.Windows.Forms.Button();
            this.userControlWithdraw1 = new GelismisATM.UserControlWithdraw();
            this.userControlDeposit1 = new GelismisATM.UserControlDeposit();
            this.userControlAccountDetails1 = new GelismisATM.UserControlAccountDetails();
            this.userControlAdminPage1 = new GelismisATM.UserControlAdminPage();
            this.userControlAccounts1 = new GelismisATM.UserControlAccounts();
            this.userControlLogin1 = new GelismisATM.UserControlLogin();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMenuUsername);
            this.panel1.Controls.Add(this.lblMenuWelcome);
            this.panel1.Controls.Add(this.btnMenuStock);
            this.panel1.Controls.Add(this.btnMenuAccounts);
            this.panel1.Controls.Add(this.btnMenuWitdraw);
            this.panel1.Controls.Add(this.btnMenuDeposit);
            this.panel1.Controls.Add(this.btnMenuTransfer);
            this.panel1.Controls.Add(this.btnMenuSettings);
            this.panel1.Controls.Add(this.btnMenuExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 768);
            this.panel1.TabIndex = 0;
            // 
            // lblMenuUsername
            // 
            this.lblMenuUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuUsername.ForeColor = System.Drawing.Color.White;
            this.lblMenuUsername.Location = new System.Drawing.Point(0, 45);
            this.lblMenuUsername.Name = "lblMenuUsername";
            this.lblMenuUsername.Size = new System.Drawing.Size(278, 50);
            this.lblMenuUsername.TabIndex = 9;
            this.lblMenuUsername.Text = "user.name";
            this.lblMenuUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMenuWelcome
            // 
            this.lblMenuWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuWelcome.ForeColor = System.Drawing.Color.White;
            this.lblMenuWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblMenuWelcome.Name = "lblMenuWelcome";
            this.lblMenuWelcome.Size = new System.Drawing.Size(278, 45);
            this.lblMenuWelcome.TabIndex = 8;
            this.lblMenuWelcome.Text = "Hoş Geldin";
            this.lblMenuWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnMenuStock
            // 
            this.btnMenuStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuStock.Enabled = false;
            this.btnMenuStock.FlatAppearance.BorderSize = 0;
            this.btnMenuStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuStock.ForeColor = System.Drawing.Color.White;
            this.btnMenuStock.Location = new System.Drawing.Point(15, 475);
            this.btnMenuStock.Name = "btnMenuStock";
            this.btnMenuStock.Size = new System.Drawing.Size(250, 60);
            this.btnMenuStock.TabIndex = 7;
            this.btnMenuStock.Text = "HİSSE İŞLEMLERİ";
            this.btnMenuStock.UseVisualStyleBackColor = false;
            // 
            // btnMenuAccounts
            // 
            this.btnMenuAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuAccounts.FlatAppearance.BorderSize = 0;
            this.btnMenuAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuAccounts.ForeColor = System.Drawing.Color.White;
            this.btnMenuAccounts.Location = new System.Drawing.Point(15, 100);
            this.btnMenuAccounts.Name = "btnMenuAccounts";
            this.btnMenuAccounts.Size = new System.Drawing.Size(250, 60);
            this.btnMenuAccounts.TabIndex = 5;
            this.btnMenuAccounts.Text = "HESAPLARIM";
            this.btnMenuAccounts.UseVisualStyleBackColor = false;
            this.btnMenuAccounts.Click += new System.EventHandler(this.btnMenuAccounts_Click);
            // 
            // btnMenuWitdraw
            // 
            this.btnMenuWitdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuWitdraw.FlatAppearance.BorderSize = 0;
            this.btnMenuWitdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuWitdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuWitdraw.ForeColor = System.Drawing.Color.White;
            this.btnMenuWitdraw.Location = new System.Drawing.Point(15, 175);
            this.btnMenuWitdraw.Name = "btnMenuWitdraw";
            this.btnMenuWitdraw.Size = new System.Drawing.Size(250, 60);
            this.btnMenuWitdraw.TabIndex = 4;
            this.btnMenuWitdraw.Text = "PARA ÇEK";
            this.btnMenuWitdraw.UseVisualStyleBackColor = false;
            this.btnMenuWitdraw.Click += new System.EventHandler(this.btnMenuWitdraw_Click);
            // 
            // btnMenuDeposit
            // 
            this.btnMenuDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuDeposit.FlatAppearance.BorderSize = 0;
            this.btnMenuDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuDeposit.ForeColor = System.Drawing.Color.White;
            this.btnMenuDeposit.Location = new System.Drawing.Point(15, 250);
            this.btnMenuDeposit.Name = "btnMenuDeposit";
            this.btnMenuDeposit.Size = new System.Drawing.Size(250, 60);
            this.btnMenuDeposit.TabIndex = 3;
            this.btnMenuDeposit.Text = "PARA YATIR";
            this.btnMenuDeposit.UseVisualStyleBackColor = false;
            this.btnMenuDeposit.Click += new System.EventHandler(this.btnMenuDeposit_Click);
            // 
            // btnMenuTransfer
            // 
            this.btnMenuTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuTransfer.FlatAppearance.BorderSize = 0;
            this.btnMenuTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuTransfer.ForeColor = System.Drawing.Color.White;
            this.btnMenuTransfer.Location = new System.Drawing.Point(15, 325);
            this.btnMenuTransfer.Name = "btnMenuTransfer";
            this.btnMenuTransfer.Size = new System.Drawing.Size(250, 60);
            this.btnMenuTransfer.TabIndex = 2;
            this.btnMenuTransfer.Text = "PARA TRANSFERİ";
            this.btnMenuTransfer.UseVisualStyleBackColor = false;
            this.btnMenuTransfer.Click += new System.EventHandler(this.btnMenuTransfer_Click);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuSettings.ForeColor = System.Drawing.Color.White;
            this.btnMenuSettings.Location = new System.Drawing.Point(15, 550);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(250, 60);
            this.btnMenuSettings.TabIndex = 1;
            this.btnMenuSettings.Text = "AYARLAR";
            this.btnMenuSettings.UseVisualStyleBackColor = false;
            this.btnMenuSettings.Visible = false;
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuExit.FlatAppearance.BorderSize = 0;
            this.btnMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuExit.ForeColor = System.Drawing.Color.White;
            this.btnMenuExit.Location = new System.Drawing.Point(15, 656);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(250, 60);
            this.btnMenuExit.TabIndex = 0;
            this.btnMenuExit.Text = "ÇIKIŞ";
            this.btnMenuExit.UseVisualStyleBackColor = false;
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // btnMenuCurrency
            // 
            this.btnMenuCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.btnMenuCurrency.FlatAppearance.BorderSize = 0;
            this.btnMenuCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuCurrency.ForeColor = System.Drawing.Color.White;
            this.btnMenuCurrency.Location = new System.Drawing.Point(15, 400);
            this.btnMenuCurrency.Name = "btnMenuCurrency";
            this.btnMenuCurrency.Size = new System.Drawing.Size(250, 60);
            this.btnMenuCurrency.TabIndex = 6;
            this.btnMenuCurrency.Text = "DÖVİZ İŞLEMLERİ";
            this.btnMenuCurrency.UseVisualStyleBackColor = false;
            // 
            // userControlWithdraw1
            // 
            this.userControlWithdraw1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlWithdraw1.Location = new System.Drawing.Point(286, 0);
            this.userControlWithdraw1.Name = "userControlWithdraw1";
            this.userControlWithdraw1.Size = new System.Drawing.Size(1024, 768);
            this.userControlWithdraw1.TabIndex = 7;
            // 
            // userControlDeposit1
            // 
            this.userControlDeposit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlDeposit1.Location = new System.Drawing.Point(286, 0);
            this.userControlDeposit1.Name = "userControlDeposit1";
            this.userControlDeposit1.Size = new System.Drawing.Size(1024, 768);
            this.userControlDeposit1.TabIndex = 8;
            // 
            // userControlAccountDetails1
            // 
            this.userControlAccountDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlAccountDetails1.Location = new System.Drawing.Point(286, 0);
            this.userControlAccountDetails1.Name = "userControlAccountDetails1";
            this.userControlAccountDetails1.Size = new System.Drawing.Size(1024, 768);
            this.userControlAccountDetails1.TabIndex = 9;
            // 
            // userControlAdminPage1
            // 
            this.userControlAdminPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlAdminPage1.Location = new System.Drawing.Point(286, 0);
            this.userControlAdminPage1.Name = "userControlAdminPage1";
            this.userControlAdminPage1.Size = new System.Drawing.Size(1024, 768);
            this.userControlAdminPage1.TabIndex = 10;
            // 
            // userControlAccounts1
            // 
            this.userControlAccounts1.BackColor = System.Drawing.Color.White;
            this.userControlAccounts1.Location = new System.Drawing.Point(286, 0);
            this.userControlAccounts1.Name = "userControlAccounts1";
            this.userControlAccounts1.Size = new System.Drawing.Size(1024, 768);
            this.userControlAccounts1.TabIndex = 11;
            // 
            // userControlLogin1
            // 
            this.userControlLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlLogin1.Location = new System.Drawing.Point(286, 0);
            this.userControlLogin1.Name = "userControlLogin1";
            this.userControlLogin1.Size = new System.Drawing.Size(1024, 768);
            this.userControlLogin1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1314, 768);
            this.Controls.Add(this.userControlLogin1);
            this.Controls.Add(this.userControlAccounts1);
            this.Controls.Add(this.userControlAdminPage1);
            this.Controls.Add(this.userControlAccountDetails1);
            this.Controls.Add(this.userControlDeposit1);
            this.Controls.Add(this.userControlWithdraw1);
            this.Controls.Add(this.btnMenuCurrency);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public GelismisATM.UserControlWithdraw userControlWithdraw1;
        public GelismisATM.UserControlDeposit userControlDeposit1;
        public GelismisATM.UserControlAccounts userControlAccounts1;

        public GelismisATM.UserControlAdminPage userControlAdminPage1;


        public GelismisATM.UserControlAccountDetails userControlAccountDetails1;

        public GelismisATM.UserControlLogin userControlLogin1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuExit;
        private System.Windows.Forms.Button btnMenuAccounts;
        private System.Windows.Forms.Button btnMenuWitdraw;
        private System.Windows.Forms.Button btnMenuDeposit;
        private System.Windows.Forms.Button btnMenuTransfer;
        private System.Windows.Forms.Button btnMenuSettings;
        private System.Windows.Forms.Button btnMenuStock;
        private System.Windows.Forms.Button btnMenuCurrency;
        private System.Windows.Forms.Label lblMenuWelcome;
        public System.Windows.Forms.Label lblMenuUsername;
    }
}