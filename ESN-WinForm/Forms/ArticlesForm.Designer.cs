namespace ESN_WinForm.Forms
{
    partial class ArticlesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticlesForm));
            this.KorisniciTabela = new System.Windows.Forms.DataGridView();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrediBtn = new System.Windows.Forms.Button();
            this.KomentariBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.NazadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // KorisniciTabela
            // 
            this.KorisniciTabela.AllowUserToAddRows = false;
            this.KorisniciTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.KorisniciTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KorisniciTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.KorisniciTabela.Location = new System.Drawing.Point(405, 132);
            this.KorisniciTabela.Name = "KorisniciTabela";
            this.KorisniciTabela.RowHeadersWidth = 51;
            this.KorisniciTabela.RowTemplate.Height = 24;
            this.KorisniciTabela.Size = new System.Drawing.Size(686, 360);
            this.KorisniciTabela.TabIndex = 31;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(27, 152);
            this.DodajBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(281, 58);
            this.DodajBtn.TabIndex = 30;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ESN_WinForm.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(405, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchBox.Location = new System.Drawing.Point(441, 45);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(650, 35);
            this.SearchBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Novosti";
            // 
            // UrediBtn
            // 
            this.UrediBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.UrediBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UrediBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UrediBtn.Location = new System.Drawing.Point(27, 246);
            this.UrediBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UrediBtn.Name = "UrediBtn";
            this.UrediBtn.Size = new System.Drawing.Size(281, 58);
            this.UrediBtn.TabIndex = 33;
            this.UrediBtn.Text = "Uredi";
            this.UrediBtn.UseVisualStyleBackColor = false;
            // 
            // KomentariBtn
            // 
            this.KomentariBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.KomentariBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.KomentariBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KomentariBtn.Location = new System.Drawing.Point(27, 422);
            this.KomentariBtn.Margin = new System.Windows.Forms.Padding(4);
            this.KomentariBtn.Name = "KomentariBtn";
            this.KomentariBtn.Size = new System.Drawing.Size(281, 58);
            this.KomentariBtn.TabIndex = 35;
            this.KomentariBtn.Text = "Komentari";
            this.KomentariBtn.UseVisualStyleBackColor = false;
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ObrisiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ObrisiBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ObrisiBtn.Location = new System.Drawing.Point(27, 328);
            this.ObrisiBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(281, 58);
            this.ObrisiBtn.TabIndex = 34;
            this.ObrisiBtn.Text = "Obrisi";
            this.ObrisiBtn.UseVisualStyleBackColor = false;
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(810, 520);
            this.NazadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(281, 58);
            this.NazadBtn.TabIndex = 36;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // ArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.KomentariBtn);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.UrediBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KorisniciTabela);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticlesForm";
            this.Text = "ArticlesForm";
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView KorisniciTabela;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UrediBtn;
        private System.Windows.Forms.Button KomentariBtn;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button NazadBtn;
    }
}