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
            this.VijestiTabela = new System.Windows.Forms.DataGridView();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.PretraziBtn = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrediBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.DodajNotifikaciju = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.Success = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VijestiTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretraziBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // VijestiTabela
            // 
            this.VijestiTabela.AllowUserToAddRows = false;
            this.VijestiTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.VijestiTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VijestiTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.VijestiTabela.Location = new System.Drawing.Point(456, 165);
            this.VijestiTabela.Name = "VijestiTabela";
            this.VijestiTabela.RowHeadersWidth = 51;
            this.VijestiTabela.RowTemplate.Height = 24;
            this.VijestiTabela.Size = new System.Drawing.Size(771, 449);
            this.VijestiTabela.TabIndex = 31;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(31, 165);
            this.DodajBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(316, 72);
            this.DodajBtn.TabIndex = 30;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // PretraziBtn
            // 
            this.PretraziBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PretraziBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PretraziBtn.Image = global::ESN_WinForm.Properties.Resources.search;
            this.PretraziBtn.Location = new System.Drawing.Point(456, 57);
            this.PretraziBtn.Name = "PretraziBtn";
            this.PretraziBtn.Size = new System.Drawing.Size(41, 44);
            this.PretraziBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PretraziBtn.TabIndex = 29;
            this.PretraziBtn.TabStop = false;
            this.PretraziBtn.Click += new System.EventHandler(this.PretraziBtn_Click_1);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchBox.Location = new System.Drawing.Point(496, 57);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(731, 44);
            this.SearchBox.TabIndex = 28;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "Članci";
            // 
            // UrediBtn
            // 
            this.UrediBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.UrediBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UrediBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UrediBtn.Location = new System.Drawing.Point(31, 292);
            this.UrediBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UrediBtn.Name = "UrediBtn";
            this.UrediBtn.Size = new System.Drawing.Size(316, 72);
            this.UrediBtn.TabIndex = 33;
            this.UrediBtn.Text = "Uredi";
            this.UrediBtn.UseVisualStyleBackColor = false;
            this.UrediBtn.Click += new System.EventHandler(this.UrediBtn_Click);
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ObrisiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ObrisiBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ObrisiBtn.Location = new System.Drawing.Point(31, 418);
            this.ObrisiBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(316, 72);
            this.ObrisiBtn.TabIndex = 34;
            this.ObrisiBtn.Text = "Obrisi";
            this.ObrisiBtn.UseVisualStyleBackColor = false;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(912, 649);
            this.NazadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(316, 72);
            this.NazadBtn.TabIndex = 36;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // DodajNotifikaciju
            // 
            this.DodajNotifikaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajNotifikaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajNotifikaciju.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajNotifikaciju.Location = new System.Drawing.Point(31, 542);
            this.DodajNotifikaciju.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodajNotifikaciju.Name = "DodajNotifikaciju";
            this.DodajNotifikaciju.Size = new System.Drawing.Size(316, 72);
            this.DodajNotifikaciju.TabIndex = 37;
            this.DodajNotifikaciju.Text = "Notifikuj članak";
            this.DodajNotifikaciju.UseVisualStyleBackColor = false;
            this.DodajNotifikaciju.Click += new System.EventHandler(this.DodajNotifikaciju_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error.Location = new System.Drawing.Point(27, 649);
            this.Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(608, 30);
            this.Error.TabIndex = 38;
            this.Error.Text = "Dodavanje notifikacije nije uspjelo. Pokušajte ponovo.";
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Success.ForeColor = System.Drawing.Color.Black;
            this.Success.Location = new System.Drawing.Point(27, 629);
            this.Success.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(345, 30);
            this.Success.TabIndex = 39;
            this.Success.Text = "Notifikacija uspješno poslana.";
            // 
            // ArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 754);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.DodajNotifikaciju);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.UrediBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VijestiTabela);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.PretraziBtn);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticlesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticlesForm";
            ((System.ComponentModel.ISupportInitialize)(this.VijestiTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretraziBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VijestiTabela;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.PictureBox PretraziBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UrediBtn;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.Button DodajNotifikaciju;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label Success;
    }
}