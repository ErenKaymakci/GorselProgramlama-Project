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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonAccountDetails = new System.Windows.Forms.Button();
            this.userControlMenu = new GelismisATM.UserControlMenu();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.buttonMenu.Location = new System.Drawing.Point(76, 175);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(300, 65);
            this.buttonMenu.TabIndex = 16;
            this.buttonMenu.Text = "MENÜ";
            this.buttonMenu.UseVisualStyleBackColor = false;
            // 
            // buttonAccountDetails
            // 
            this.buttonAccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.buttonAccountDetails.FlatAppearance.BorderSize = 0;
            this.buttonAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.buttonAccountDetails.Location = new System.Drawing.Point(76, 295);
            this.buttonAccountDetails.Name = "buttonAccountDetails";
            this.buttonAccountDetails.Size = new System.Drawing.Size(300, 65);
            this.buttonAccountDetails.TabIndex = 17;
            this.buttonAccountDetails.Text = "HESAP DETAYLARI";
            this.buttonAccountDetails.UseVisualStyleBackColor = false;
            // 
            // userControlMenu
            // 
            this.userControlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.userControlMenu.Location = new System.Drawing.Point(-5, -30);
            this.userControlMenu.Name = "userControlMenu";
            this.userControlMenu.Size = new System.Drawing.Size(1024, 768);
            this.userControlMenu.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.userControlMenu);
            this.Controls.Add(this.buttonAccountDetails);
            this.Controls.Add(this.buttonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonAccountDetails;
        private UserControlMenu userControlMenu;
    }
}