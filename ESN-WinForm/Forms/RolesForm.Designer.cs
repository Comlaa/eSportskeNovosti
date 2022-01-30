namespace ESN_WinForm.Forms
{
    partial class RolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Permisije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.UrediBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RolaTabela = new System.Windows.Forms.DataGridView();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PretraziBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RolaTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretraziBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-100, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-97, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(-101, -33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Kategorije";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SearchBox.Location = new System.Drawing.Point(214, -32);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(488, 29);
            this.SearchBox.TabIndex = 51;
            // 
            // Permisije
            // 
            this.Permisije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Permisije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Permisije.Location = new System.Drawing.Point(36, 326);
            this.Permisije.Multiline = true;
            this.Permisije.Name = "Permisije";
            this.Permisije.Size = new System.Drawing.Size(208, 116);
            this.Permisije.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Permisije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Naziv";
            // 
            // Naziv
            // 
            this.Naziv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Naziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Naziv.Location = new System.Drawing.Point(36, 269);
            this.Naziv.Margin = new System.Windows.Forms.Padding(2);
            this.Naziv.Multiline = true;
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(211, 26);
            this.Naziv.TabIndex = 70;
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(623, 429);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(211, 47);
            this.NazadBtn.TabIndex = 69;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click_1);
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ObrisiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ObrisiBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ObrisiBtn.Location = new System.Drawing.Point(36, 180);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(211, 47);
            this.ObrisiBtn.TabIndex = 68;
            this.ObrisiBtn.Text = "Obriši";
            this.ObrisiBtn.UseVisualStyleBackColor = false;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click_1);
            // 
            // UrediBtn
            // 
            this.UrediBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.UrediBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.UrediBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UrediBtn.Location = new System.Drawing.Point(36, 105);
            this.UrediBtn.Name = "UrediBtn";
            this.UrediBtn.Size = new System.Drawing.Size(211, 47);
            this.UrediBtn.TabIndex = 67;
            this.UrediBtn.Text = "Uredi";
            this.UrediBtn.UseVisualStyleBackColor = false;
            this.UrediBtn.Click += new System.EventHandler(this.UrediBtn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(41, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 66;
            this.label6.Text = "Role";
            // 
            // RolaTabela
            // 
            this.RolaTabela.AllowUserToAddRows = false;
            this.RolaTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.RolaTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolaTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.RolaTabela.Location = new System.Drawing.Point(320, 105);
            this.RolaTabela.Margin = new System.Windows.Forms.Padding(2);
            this.RolaTabela.Name = "RolaTabela";
            this.RolaTabela.RowHeadersWidth = 51;
            this.RolaTabela.RowTemplate.Height = 24;
            this.RolaTabela.Size = new System.Drawing.Size(514, 292);
            this.RolaTabela.TabIndex = 65;
            // 
            // DodajBtn
            // 
            this.DodajBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.DodajBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DodajBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DodajBtn.Location = new System.Drawing.Point(320, 429);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(211, 47);
            this.DodajBtn.TabIndex = 64;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = false;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PretraziBtn
            // 
            this.PretraziBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PretraziBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PretraziBtn.Image = global::ESN_WinForm.Properties.Resources.search;
            this.PretraziBtn.Location = new System.Drawing.Point(187, -32);
            this.PretraziBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PretraziBtn.Name = "PretraziBtn";
            this.PretraziBtn.Size = new System.Drawing.Size(28, 29);
            this.PretraziBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PretraziBtn.TabIndex = 52;
            this.PretraziBtn.TabStop = false;
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 490);
            this.Controls.Add(this.Permisije);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.ObrisiBtn);
            this.Controls.Add(this.UrediBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolaTabela);
            this.Controls.Add(this.DodajBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PretraziBtn);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RolesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RolesForm";
            ((System.ComponentModel.ISupportInitialize)(this.RolaTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PretraziBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PretraziBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox Permisije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button UrediBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RolaTabela;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}