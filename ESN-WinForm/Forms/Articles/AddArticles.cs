using ESN_WinForm.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Articles
{
    public partial class AddArticles : Form
    {
        public AddArticles()
        {
            InitializeComponent();
            Tekst_Leave(null, null);
            Naziv_Leave(null, null);
            Tagovi_Leave(null, null);
            Datum.Text = DateTime.Now.ToString();
        }

        private async void DodajBtn_Click(object sender, EventArgs e)
        {
            ArticleDTO article = new ArticleDTO { 
                Title = Naziv.Text,
                Text = Tekst.Text,
                Tags = Tagovi.Text,
                AllowComments = Komentari.Checked,
                Date = Datum.Value,
                CategoryId = 1
            };
            var response = await ArticleService.Add(article);
            NazadBtn_Click(null, null);
        }

        private void Tekst_Leave(object sender, EventArgs e)
        {
            if (Tekst.Text.Trim() == "")
            {
                Tekst.Text = "Molimo unesite tekst clanka";
            }
        }

        private void Tekst_Click(object sender, EventArgs e)
        {
            if (Tekst.Text == "Molimo unesite tekst clanka")
            {
                Tekst.Text = "";
            }
        }

        private void Naziv_Click(object sender, EventArgs e)
        {
            if (Naziv.Text == "Molimo unesite naslov clanka")
            {
                Naziv.Text = "";
            }
        }

        private void Naziv_Leave(object sender, EventArgs e)
        {
            if (Naziv.Text.Trim() == "")
            {
                Naziv.Text = "Molimo unesite naslov clanka";
            }
        }

        private void Tagovi_Click(object sender, EventArgs e)
        {
            if (Tagovi.Text == "Molimo unesite tagove clanka")
            {
                Tagovi.Text = "";
            }
        }

        private void Tagovi_Leave(object sender, EventArgs e)
        {
            if (Tagovi.Text.Trim() == "")
            {
                Tagovi.Text = "Molimo unesite tagove clanka";
            }
        }

        private void slika_Click(object sender, EventArgs e)
        {
            PretraziSliku.Title = "Open Image file";
            PretraziSliku.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            if (PretraziSliku.ShowDialog() == DialogResult.OK)
            {
                slika.Image = Image.FromFile(PretraziSliku.FileName);
            }
            PretraziSliku.Dispose();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ArticlesForm articles = new ArticlesForm();
            articles.ShowDialog();
        }
    }
}
