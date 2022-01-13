using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
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
                CategoryId = categoryId
            };
            await ArticleService.Edit(_article);
            NazadBtn_Click_1(null, null);
        }

        private void NazadBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
