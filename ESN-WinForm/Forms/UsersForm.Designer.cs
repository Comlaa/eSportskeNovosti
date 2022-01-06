namespace ESN_WinForm.Forms
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.PretraziBtn = new System.Windows.Forms.Button();
            this.PretraziSveBtn = new System.Windows.Forms.Button();
            this.KorisniciTabela = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.PictureBox();
            this.NazadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchBox.Location = new System.Drawing.Point(778, 51);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(326, 35);
            this.SearchBox.TabIndex = 23;
            // 
            // PretraziBtn
            // 
            this.PretraziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.PretraziBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PretraziBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PretraziBtn.Location = new System.Drawing.Point(280, 51);
            this.PretraziBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PretraziBtn.Name = "PretraziBtn";
            this.PretraziBtn.Size = new System.Drawing.Size(232, 35);
            this.PretraziBtn.TabIndex = 25;
            this.PretraziBtn.Text = "Pretrazi";
            this.PretraziBtn.UseVisualStyleBackColor = false;
            this.PretraziBtn.Click += new System.EventHandler(this.PretraziBtn_Click);
            // 
            // PretraziSveBtn
            // 
            this.PretraziSveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.PretraziSveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PretraziSveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PretraziSveBtn.Location = new System.Drawing.Point(23, 51);
            this.PretraziSveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PretraziSveBtn.Name = "PretraziSveBtn";
            this.PretraziSveBtn.Size = new System.Drawing.Size(232, 35);
            this.PretraziSveBtn.TabIndex = 26;
            this.PretraziSveBtn.Text = "Pretrazi sve";
            this.PretraziSveBtn.UseVisualStyleBackColor = false;
            // 
            // KorisniciTabela
            // 
            this.KorisniciTabela.AllowUserToAddRows = false;
            this.KorisniciTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.KorisniciTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KorisniciTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.KorisniciTabela.Location = new System.Drawing.Point(23, 124);
            this.KorisniciTabela.Name = "KorisniciTabela";
            this.KorisniciTabela.RowHeadersWidth = 51;
            this.KorisniciTabela.RowTemplate.Height = 24;
            this.KorisniciTabela.Size = new System.Drawing.Size(686, 424);
            this.KorisniciTabela.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESN_WinForm.Properties.Resources.users_banner;
            this.pictureBox1.Location = new System.Drawing.Point(742, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBtn.Image = global::ESN_WinForm.Properties.Resources.search;
            this.SearchBtn.Location = new System.Drawing.Point(742, 51);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(36, 35);
            this.SearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBtn.TabIndex = 24;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(872, 555);
            this.NazadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(232, 35);
            this.NazadBtn.TabIndex = 29;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KorisniciTabela);
            this.Controls.Add(this.PretraziSveBtn);
            this.Controls.Add(this.PretraziBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button PretraziBtn;
        private System.Windows.Forms.Button PretraziSveBtn;
        private System.Windows.Forms.DataGridView KorisniciTabela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NazadBtn;
    }
}