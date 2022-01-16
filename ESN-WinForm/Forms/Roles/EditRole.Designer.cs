namespace ESN_WinForm.Forms.Roles
{
    partial class EditRole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRole));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Permisije = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::ESN_WinForm.Properties.Resources.edit_photo;
            this.pictureBox1.Location = new System.Drawing.Point(438, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // Permisije
            // 
            this.Permisije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Permisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Permisije.Location = new System.Drawing.Point(25, 164);
            this.Permisije.Multiline = true;
            this.Permisije.Name = "Permisije";
            this.Permisije.Size = new System.Drawing.Size(355, 223);
            this.Permisije.TabIndex = 66;
            // 
            // Naziv
            // 
            this.Naziv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Naziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Naziv.Location = new System.Drawing.Point(25, 116);
            this.Naziv.Margin = new System.Windows.Forms.Padding(2);
            this.Naziv.Multiline = true;
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(355, 26);
            this.Naziv.TabIndex = 65;
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(385, 420);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(211, 47);
            this.NazadBtn.TabIndex = 64;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Uredi rolu";
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(613, 420);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(211, 47);
            this.DodajBtn.TabIndex = 62;
            this.DodajBtn.Text = "Snimi";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Permisije);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Permisije;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}