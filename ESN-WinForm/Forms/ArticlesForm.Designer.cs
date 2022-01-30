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
            this.VijestiTabela.Location = new System.Drawing.Point(304, 107);
            this.VijestiTabela.Margin = new System.Windows.Forms.Padding(2);
            this.VijestiTabela.Name = "VijestiTabela";
            this.VijestiTabela.RowHeadersWidth = 51;
            this.VijestiTabela.RowTemplate.Height = 24;
            this.VijestiTabela.Size = new System.Drawing.Size(514, 292);
            this.VijestiTabela.TabIndex = 31;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(21, 142);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(211, 47);
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
            this.PretraziBtn.Location = new System.Drawing.Point(304, 37);
            this.PretraziBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PretraziBtn.Name = "PretraziBtn";
            this.PretraziBtn.Size = new System.Drawing.Size(28, 29);
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
            this.SearchBox.Location = new System.Drawing.Point(331, 37);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(488, 29);
            this.SearchBox.TabIndex = 28;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Članci";
            // 
            // UrediBtn
            // 
            this.UrediBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.UrediBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UrediBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UrediBtn.Location = new System.Drawing.Point(21, 231);
            this.UrediBtn.Name = "UrediBtn";
            this.UrediBtn.Size = new System.Drawing.Size(211, 47);
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
            this.ObrisiBtn.Location = new System.Drawing.Point(21, 314);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(211, 47);
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
            this.NazadBtn.Location = new System.Drawing.Point(608, 422);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(211, 47);
            this.NazadBtn.TabIndex = 36;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // ArticlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.UrediBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VijestiTabela);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.PretraziBtn);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}