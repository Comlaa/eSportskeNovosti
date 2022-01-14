using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Articles
{
    public partial class EditArticle : Form
    {
        private ArticleDTO article { get; set; }
        private CategoryDTO[] categories { get; set; }
        public EditArticle()
        {
            InitializeComponent();
            PopulateForm();
        }

        private async void PopulateForm()
        {
            var response = await ArticleService.GetArticleById(ArticlesForm.ArticleId);
            if (response != null)
            {
                article = JsonConvert.DeserializeObject<ArticleDTO>(response);
                Naziv.Text = article.Title;
                Tekst.Text = article.Text;
                Datum.Value = article.Date;
                Tagovi.Text = article.Tags;
                Komentari.Checked = article.AllowComments;
                slika.Image = ConvertImage.ConvertBase64ToImage(article.Picture);

                categories = JsonConvert.DeserializeObject<CategoryDTO[]>(await CategoryService.GetAllCategories());
                foreach (var category in categories)
                {
                    Kategorije.Items.Add(category.Name);
                    if (category.Id.Equals(article.CategoryId))
                        Kategorije.SelectedItem = category.Name;
                }

            }
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
                ArticleDTO _article = new ArticleDTO
                {
                    Id = article.Id,
                    Title = Naziv.Text,
                    Text = Tekst.Text,
                    Tags = Tagovi.Text,
                    AllowComments = Komentari.Checked,
                    Date = Datum.Value,
                    CategoryId = categoryId,
                    Picture = ConvertImage.ConvertImageToBase64(slika.Image)
                };
                await ArticleService.Edit(_article);
                NazadBtn_Click_1(null, null);
            }
        }

        private void NazadBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
