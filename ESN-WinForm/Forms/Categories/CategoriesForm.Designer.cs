namespace ESN_WinForm.Forms.Categories
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.NazadBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.UrediBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KategorijaTabela = new System.Windows.Forms.DataGridView();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.PretraziBtn = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KategorijaTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretraziBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(615, 415);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(211, 47);
            this.NazadBtn.TabIndex = 45;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ObrisiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ObrisiBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ObrisiBtn.Location = new System.Drawing.Point(28, 203);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(211, 47);
            this.ObrisiBtn.TabIndex = 43;
            this.ObrisiBtn.Text = "Obriši";
            this.ObrisiBtn.UseVisualStyleBackColor = false;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // UrediBtn
            // 
            this.UrediBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.UrediBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UrediBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UrediBtn.Location = new System.Drawing.Point(28, 128);
            this.UrediBtn.Name = "UrediBtn";
            this.UrediBtn.Size = new System.Drawing.Size(211, 47);
            this.UrediBtn.TabIndex = 42;
            this.UrediBtn.Text = "Uredi";
            this.UrediBtn.UseVisualStyleBackColor = false;
            this.UrediBtn.Click += new System.EventHandler(this.UrediBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kategorije";
            // 
            // KategorijaTabela
            // 
            this.KategorijaTabela.AllowUserToAddRows = false;
            this.KategorijaTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.KategorijaTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KategorijaTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.KategorijaTabela.Location = new System.Drawing.Point(311, 100);
            this.KategorijaTabela.Margin = new System.Windows.Forms.Padding(2);
            this.KategorijaTabela.Name = "KategorijaTabela";
            this.KategorijaTabela.RowHeadersWidth = 51;
            this.KategorijaTabela.RowTemplate.Height = 24;
            this.KategorijaTabela.Size = new System.Drawing.Size(514, 292);
            this.KategorijaTabela.TabIndex = 40;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(311, 415);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(211, 47);
            this.DodajBtn.TabIndex = 39;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // PretraziBtn
            // 
            this.PretraziBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PretraziBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PretraziBtn.Image = global::ESN_WinForm.Properties.Resources.search;
            this.PretraziBtn.Location = new System.Drawing.Point(311, 30);
            this.PretraziBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PretraziBtn.Name = "PretraziBtn";
            this.PretraziBtn.Size = new System.Drawing.Size(28, 29);
            this.PretraziBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PretraziBtn.TabIndex = 38;
            this.PretraziBtn.TabStop = false;
            this.PretraziBtn.Click += new System.EventHandler(this.PretraziBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchBox.Location = new System.Drawing.Point(338, 30);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(488, 29);
            this.SearchBox.TabIndex = 37;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Naziv
            // 
            this.Naziv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Naziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Naziv.Location = new System.Drawing.Point(28, 292);
            this.Naziv.Margin = new System.Windows.Forms.Padding(2);
            this.Naziv.Multiline = true;
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(211, 26);
            this.Naziv.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Opis";
            // 
            // Opis
            // 
            this.Opis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Opis.Location = new System.Drawing.Point(28, 346);
            this.Opis.Multiline = true;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(208, 116);
            this.Opis.TabIndex = 50;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.UrediBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KategorijaTabela);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.PretraziBtn);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.KategorijaTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretraziBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button UrediBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KategorijaTabela;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.PictureBox PretraziBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Opis;
    }
}