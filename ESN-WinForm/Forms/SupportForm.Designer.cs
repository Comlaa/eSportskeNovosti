namespace ESN_WinForm.Forms
{
    partial class SupportForm
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
            this.NazadBtn = new System.Windows.Forms.Button();
            this.SupportTicketsTabela = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SupportTicketsTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NazadBtn
            // 
            this.NazadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.NazadBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NazadBtn.Location = new System.Drawing.Point(665, 437);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(174, 40);
            this.NazadBtn.TabIndex = 32;
            this.NazadBtn.Text = "Nazad";
            this.NazadBtn.UseVisualStyleBackColor = false;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // SupportTicketsTabela
            // 
            this.SupportTicketsTabela.AllowUserToAddRows = false;
            this.SupportTicketsTabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupportTicketsTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupportTicketsTabela.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupportTicketsTabela.Location = new System.Drawing.Point(29, 74);
            this.SupportTicketsTabela.Margin = new System.Windows.Forms.Padding(2);
            this.SupportTicketsTabela.Name = "SupportTicketsTabela";
            this.SupportTicketsTabela.RowHeadersWidth = 51;
            this.SupportTicketsTabela.RowTemplate.Height = 24;
            this.SupportTicketsTabela.Size = new System.Drawing.Size(556, 344);
            this.SupportTicketsTabela.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESN_WinForm.Properties.Resources.users_banner;
            this.pictureBox1.Location = new System.Drawing.Point(601, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Korisnička podrška";
            // 
            // SupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SupportTicketsTabela);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupportForm";
            ((System.ComponentModel.ISupportInitialize)(this.SupportTicketsTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView SupportTicketsTabela;
        private System.Windows.Forms.Label label1;
    }
}