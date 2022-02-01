namespace ESN_WinForm
{
    partial class LoginForm
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
            this.AppName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.AppName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppName.Location = new System.Drawing.Point(81, 42);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(214, 31);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "SportskeNovosti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(174, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "AdminPortal";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Window;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(66, 245);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(269, 20);
            this.Username.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Korisnicko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lozinka";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Window;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(66, 297);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(269, 20);
            this.Password.TabIndex = 6;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.Location = new System.Drawing.Point(180, 335);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(155, 34);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Prijava";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ESN_WinForm.Properties.Resources.Login_banner;
            this.pictureBox1.Location = new System.Drawing.Point(361, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error.Location = new System.Drawing.Point(57, 381);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(278, 13);
            this.Error.TabIndex = 9;
            this.Error.Text = "*Pogrešan password ili korisničko ime. Pokušajte ponovo.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppName);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESN - Login ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label Error;
    }
}

