using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Articles
{
    public partial class AddArticles : Form
    {
        private CategoryDTO[] categories { get; set; }
        public AddArticles()
        {
            InitializeComponent();
            Tekst_Leave(null, null);
            Naziv_Leave(null, null);
            Tagovi_Leave(null, null);
            PopulateCategories();
            Datum.Text = DateTime.Now.ToString();
        }

        private async void PopulateCategories()
        {
            categories = JsonConvert.DeserializeObject<CategoryDTO[]>(await CategoryService.GetAllCategories());
            foreach (var category in categories)
            {
                Kategorije.Items.Add(category.Name);
            }
            Kategorije.SelectedIndex = 0;
        }

        private async void DodajBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var categoryId = 1;
                foreach (var category in categories)
                {
                    if (category.Name.Equals(Kategorije.SelectedItem.ToString()))
                        categoryId = category.Id;
                }

                ArticleDTO article = new ArticleDTO
                {
                    Title = Naziv.Text,
                    Text = Tekst.Text,
                    Tags = Tagovi.Text,
                    AllowComments = Komentari.Checked,
                    Date = Datum.Value,
                    CategoryId = categoryId,
                    Picture = ConvertImage.ConvertImageToBase64(slika.Image)
                };
                await ArticleService.Add(article);
                NazadBtn_Click(null, null);
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
            this.DialogResult = DialogResult.OK;
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

        private bool ValidateInputs()
        {
            if (ValidateInput.Text(Naziv, 3, "Naziv članka mora biti duži od 3 karaktera!", errorProvider1) &&
                ValidateInput.Text(Tekst, 10, "Tekst članka mora biti duži od 10 karaktera!", errorProvider1) &&
                ValidateInput.Text(Tagovi, 3, "Naziv taga mora biti duži od 3 karaktera!", errorProvider1))
                return true;

            return false;
        }
    }
}
