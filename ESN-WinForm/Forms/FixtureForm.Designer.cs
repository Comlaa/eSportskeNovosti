namespace ESN_WinForm.Forms
{
    partial class FixtureForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.Tim1 = new System.Windows.Forms.TextBox();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RezultatiTabela = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Tim2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Kategorije = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NazadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RezultatiTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tim 1";
            // 
            // Tim1
            // 
            this.Tim1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Tim1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Tim1.Location = new System.Drawing.Point(43, 241);
            this.Tim1.Multiline = true;
            this.Tim1.Name = "Tim1";
            this.Tim1.Size = new System.Drawing.Size(316, 39);
            this.Tim1.TabIndex = 78;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(43, 556);
            this.DodajBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(316, 62);
            this.DodajBtn.TabIndex = 76;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(52, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 40);
            this.label6.TabIndex = 75;
            this.label6.Text = "Rezultati";
            // 
            // RezultatiTabela
            // 
            this.RezultatiTabela.AllowUserToAddRows = false;
            this.RezultatiTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.RezultatiTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezultatiTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.RezultatiTabela.Location = new System.Drawing.Point(474, 198);
            this.RezultatiTabela.Name = "RezultatiTabela";
            this.RezultatiTabela.RowHeadersWidth = 51;
            this.RezultatiTabela.RowTemplate.Height = 24;
            this.RezultatiTabela.Size = new System.Drawing.Size(771, 449);
            this.RezultatiTabela.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Tim 2";
            // 
            // Tim2
            // 
            this.Tim2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Tim2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Tim2.Location = new System.Drawing.Point(43, 321);
            this.Tim2.Multiline = true;
            this.Tim2.Name = "Tim2";
            this.Tim2.Size = new System.Drawing.Size(316, 39);
            this.Tim2.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Rezultat";
            // 
            // Rezultat
            // 
            this.Rezultat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Rezultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Rezultat.Location = new System.Drawing.Point(43, 407);
            this.Rezultat.Multiline = true;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(316, 39);
            this.Rezultat.TabIndex = 84;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Kategorije
            // 
            this.Kategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Kategorije.FormattingEnabled = true;
            this.Kategorije.ItemHeight = 25;
            this.Kategorije.Location = new System.Drawing.Point(43, 493);
            this.Kategorije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Kategorije.MaxDropDownItems = 20;
            this.Kategorije.MinimumSize = new System.Drawing.Size(42, 0);
            this.Kategorije.Name = "Kategorije";
            this.Kategorije.Size = new System.Drawing.Size(316, 33);
            this.Kategorije.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 458);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Kategorija";
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(929, 682);
            this.NazadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(316, 62);
            this.NazadBtn.TabIndex = 88;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // FixtureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 772);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kategorije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tim2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tim1);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RezultatiTabela);
            this.Name = "FixtureForm";
            this.Text = "FixtureForm";
            ((System.ComponentModel.ISupportInitialize)(this.RezultatiTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tim1;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RezultatiTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tim2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Kategorije;
        private System.Windows.Forms.Button NazadBtn;
    }
}