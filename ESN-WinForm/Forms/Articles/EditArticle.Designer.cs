namespace ESN_WinForm.Forms.Articles
{
    partial class EditArticle
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
            this.Tagovi = new System.Windows.Forms.TextBox();
            this.Kategorije = new System.Windows.Forms.ComboBox();
            this.Komentari = new System.Windows.Forms.CheckBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.Tekst = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.slika = new System.Windows.Forms.PictureBox();
            this.PretraziSliku = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tagovi
            // 
            this.Tagovi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Tagovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tagovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Tagovi.Location = new System.Drawing.Point(692, 128);
            this.Tagovi.Multiline = true;
            this.Tagovi.Name = "Tagovi";
            this.Tagovi.Size = new System.Drawing.Size(532, 39);
            this.Tagovi.TabIndex = 55;
            // 
            // Kategorije
            // 
            this.Kategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Kategorije.FormattingEnabled = true;
            this.Kategorije.ItemHeight = 25;
            this.Kategorije.Location = new System.Drawing.Point(692, 195);
            this.Kategorije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Kategorije.MaxDropDownItems = 20;
            this.Kategorije.MinimumSize = new System.Drawing.Size(42, 0);
            this.Kategorije.Name = "Kategorije";
            this.Kategorije.Size = new System.Drawing.Size(530, 33);
            this.Kategorije.TabIndex = 54;
            // 
            // Komentari
            // 
            this.Komentari.AutoSize = true;
            this.Komentari.BackColor = System.Drawing.SystemColors.Control;
            this.Komentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Komentari.Location = new System.Drawing.Point(692, 592);
            this.Komentari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Komentari.Name = "Komentari";
            this.Komentari.Size = new System.Drawing.Size(135, 29);
            this.Komentari.TabIndex = 53;
            this.Komentari.Text = "Komentari";
            this.Komentari.UseVisualStyleBackColor = false;
            // 
            // Datum
            // 
            this.Datum.CustomFormat = "dddd dd.MM.yyyy HH:mm";
            this.Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datum.Location = new System.Drawing.Point(40, 195);
            this.Datum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Datum.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Datum.MinimumSize = new System.Drawing.Size(42, 29);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(530, 31);
            this.Datum.TabIndex = 51;
            this.Datum.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // Tekst
            // 
            this.Tekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Tekst.Location = new System.Drawing.Point(40, 268);
            this.Tekst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tekst.Multiline = true;
            this.Tekst.Name = "Tekst";
            this.Tekst.Size = new System.Drawing.Size(532, 294);
            this.Tekst.TabIndex = 50;
            // 
            // Naziv
            // 
            this.Naziv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Naziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Naziv.Location = new System.Drawing.Point(40, 128);
            this.Naziv.Multiline = true;
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(532, 39);
            this.Naziv.TabIndex = 49;
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(579, 637);
            this.NazadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(316, 72);
            this.NazadBtn.TabIndex = 48;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 40);
            this.label1.TabIndex = 47;
            this.label1.Text = "Uredi članak";
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(921, 637);
            this.DodajBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(316, 72);
            this.DodajBtn.TabIndex = 46;
            this.DodajBtn.Text = "Snimi";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // slika
            // 
            this.slika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slika.Image = global::ESN_WinForm.Properties.Resources.post_photo;
            this.slika.Location = new System.Drawing.Point(692, 268);
            this.slika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(532, 294);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika.TabIndex = 52;
            this.slika.TabStop = false;
            this.slika.Click += new System.EventHandler(this.slika_Click);
            // 
            // PretraziSliku
            // 
            this.PretraziSliku.FileName = "PretraziSliku";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 754);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditArticle";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tagovi;
        private System.Windows.Forms.ComboBox Kategorije;
        private System.Windows.Forms.CheckBox Komentari;
        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TextBox Tekst;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.OpenFileDialog PretraziSliku;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}