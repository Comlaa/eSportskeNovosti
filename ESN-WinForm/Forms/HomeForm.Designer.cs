namespace ESN_WinForm.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.VijestiBtn = new System.Windows.Forms.Button();
            this.KorisniciBtn = new System.Windows.Forms.Button();
            this.RoleBtn = new System.Windows.Forms.Button();
            this.KategorijeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.OdjaviBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "e";
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.AppName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AppName.Location = new System.Drawing.Point(54, 43);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(214, 31);
            this.AppName.TabIndex = 2;
            this.AppName.Text = "SportskeNovosti";
            // 
            // VijestiBtn
            // 
            this.VijestiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.VijestiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.VijestiBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VijestiBtn.Location = new System.Drawing.Point(60, 150);
            this.VijestiBtn.Name = "VijestiBtn";
            this.VijestiBtn.Size = new System.Drawing.Size(289, 49);
            this.VijestiBtn.TabIndex = 9;
            this.VijestiBtn.Text = "Članci";
            this.VijestiBtn.UseVisualStyleBackColor = false;
            this.VijestiBtn.Click += new System.EventHandler(this.VijestiBtn_Click);
            // 
            // KorisniciBtn
            // 
            this.KorisniciBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.KorisniciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.KorisniciBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KorisniciBtn.Location = new System.Drawing.Point(60, 218);
            this.KorisniciBtn.Name = "KorisniciBtn";
            this.KorisniciBtn.Size = new System.Drawing.Size(289, 51);
            this.KorisniciBtn.TabIndex = 10;
            this.KorisniciBtn.Text = "Korisnici";
            this.KorisniciBtn.UseVisualStyleBackColor = false;
            this.KorisniciBtn.Click += new System.EventHandler(this.KorisniciBtn_Click);
            // 
            // RoleBtn
            // 
            this.RoleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.RoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.RoleBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RoleBtn.Location = new System.Drawing.Point(60, 291);
            this.RoleBtn.Name = "RoleBtn";
            this.RoleBtn.Size = new System.Drawing.Size(289, 51);
            this.RoleBtn.TabIndex = 11;
            this.RoleBtn.Text = "Role";
            this.RoleBtn.UseVisualStyleBackColor = false;
            this.RoleBtn.Click += new System.EventHandler(this.RoleBtn_Click);
            // 
            // KategorijeBtn
            // 
            this.KategorijeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.KategorijeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.KategorijeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KategorijeBtn.Location = new System.Drawing.Point(60, 363);
            this.KategorijeBtn.Name = "KategorijeBtn";
            this.KategorijeBtn.Size = new System.Drawing.Size(289, 50);
            this.KategorijeBtn.TabIndex = 12;
            this.KategorijeBtn.Text = "Kategorije";
            this.KategorijeBtn.UseVisualStyleBackColor = false;
            this.KategorijeBtn.Click += new System.EventHandler(this.KategorijeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(566, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dobrodošao, ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(683, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Admin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Datum
            // 
            this.Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Datum.Location = new System.Drawing.Point(526, 379);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(259, 24);
            this.Datum.TabIndex = 18;
            this.Datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OdjaviBtn
            // 
            this.OdjaviBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.OdjaviBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OdjaviBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OdjaviBtn.Location = new System.Drawing.Point(662, 443);
            this.OdjaviBtn.Name = "OdjaviBtn";
            this.OdjaviBtn.Size = new System.Drawing.Size(174, 37);
            this.OdjaviBtn.TabIndex = 19;
            this.OdjaviBtn.Text = "Odjavi se";
            this.OdjaviBtn.UseVisualStyleBackColor = false;
            this.OdjaviBtn.Click += new System.EventHandler(this.OdjaviBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ESN_WinForm.Properties.Resources.male_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(526, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.OdjaviBtn);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KategorijeBtn);
            this.Controls.Add(this.RoleBtn);
            this.Controls.Add(this.KorisniciBtn);
            this.Controls.Add(this.VijestiBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button VijestiBtn;
        private System.Windows.Forms.Button KorisniciBtn;
        private System.Windows.Forms.Button RoleBtn;
        private System.Windows.Forms.Button KategorijeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Button OdjaviBtn;
    }
}