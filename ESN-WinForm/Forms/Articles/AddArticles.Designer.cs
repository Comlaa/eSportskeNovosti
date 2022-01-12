namespace ESN_WinForm.Forms.Articles
{
    partial class AddArticles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticles));
            this.label1 = new System.Windows.Forms.Label();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.Tekst = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.Komentari = new System.Windows.Forms.CheckBox();
            this.PretraziSliku = new System.Windows.Forms.OpenFileDialog();
            this.slika = new System.Windows.Forms.PictureBox();
            this.Kategorije = new System.Windows.Forms.ComboBox();
            this.Tagovi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Dodaj članak";
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(615, 420);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(211, 47);
            this.DodajBtn.TabIndex = 35;
            this.DodajBtn.Text = "Snimi";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(387, 420);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(211, 47);
            this.NazadBtn.TabIndex = 37;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // Naziv
            // 
            this.Naziv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Naziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Naziv.Location = new System.Drawing.Point(28, 89);
            this.Naziv.Margin = new System.Windows.Forms.Padding(2);
            this.Naziv.Multiline = true;
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(355, 26);
            this.Naziv.TabIndex = 38;
            this.Naziv.Click += new System.EventHandler(this.Naziv_Click);
            this.Naziv.Leave += new System.EventHandler(this.Naziv_Leave);
            // 
            // Tekst
            // 
            this.Tekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Tekst.Location = new System.Drawing.Point(28, 180);
            this.Tekst.Multiline = true;
            this.Tekst.Name = "Tekst";
            this.Tekst.Size = new System.Drawing.Size(355, 192);
            this.Tekst.TabIndex = 39;
            this.Tekst.Click += new System.EventHandler(this.Tekst_Click);
            this.Tekst.Leave += new System.EventHandler(this.Tekst_Leave);
            // 
            // Datum
            // 
            this.Datum.CustomFormat = "dddd dd.MM.yyyy HH:mm";
            this.Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datum.Location = new System.Drawing.Point(28, 133);
            this.Datum.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Datum.MinimumSize = new System.Drawing.Size(29, 29);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(355, 29);
            this.Datum.TabIndex = 40;
            this.Datum.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // Komentari
            // 
            this.Komentari.AutoSize = true;
            this.Komentari.BackColor = System.Drawing.SystemColors.Control;
            this.Komentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Komentari.Location = new System.Drawing.Point(462, 391);
            this.Komentari.Name = "Komentari";
            this.Komentari.Size = new System.Drawing.Size(91, 21);
            this.Komentari.TabIndex = 42;
            this.Komentari.Text = "Komentari";
            this.Komentari.UseVisualStyleBackColor = false;
            // 
            // PretraziSliku
            // 
            this.PretraziSliku.FileName = "PretraziSliku";
            // 
            // slika
            // 
            this.slika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slika.Image = global::ESN_WinForm.Properties.Resources.post_photo;
            this.slika.Location = new System.Drawing.Point(462, 180);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(355, 192);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika.TabIndex = 41;
            this.slika.TabStop = false;
            this.slika.Click += new System.EventHandler(this.slika_Click);
            // 
            // Kategorije
            // 
            this.Kategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Kategorije.FormattingEnabled = true;
            this.Kategorije.ItemHeight = 17;
            this.Kategorije.Location = new System.Drawing.Point(462, 133);
            this.Kategorije.MaxDropDownItems = 20;
            this.Kategorije.MinimumSize = new System.Drawing.Size(29, 0);
            this.Kategorije.Name = "Kategorije";
            this.Kategorije.Size = new System.Drawing.Size(355, 25);
            this.Kategorije.TabIndex = 44;
            // 
            // Tagovi
            // 
            this.Tagovi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Tagovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tagovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Tagovi.Location = new System.Drawing.Point(462, 89);
            this.Tagovi.Margin = new System.Windows.Forms.Padding(2);
            this.Tagovi.Multiline = true;
            this.Tagovi.Name = "Tagovi";
            this.Tagovi.Size = new System.Drawing.Size(355, 26);
            this.Tagovi.TabIndex = 45;
            this.Tagovi.Click += new System.EventHandler(this.Tagovi_Click);
            this.Tagovi.Leave += new System.EventHandler(this.Tagovi_Leave);
            // 
            // AddArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.Tagovi);
            this.Controls.Add(this.Kategorije);
            this.Controls.Add(this.Komentari);
            this.Controls.Add(this.slika);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.Tekst);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj vijest";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.TextBox Tekst;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.CheckBox Komentari;
        private System.Windows.Forms.OpenFileDialog PretraziSliku;
        private System.Windows.Forms.ComboBox Kategorije;
        private System.Windows.Forms.TextBox Tagovi;
    }
}