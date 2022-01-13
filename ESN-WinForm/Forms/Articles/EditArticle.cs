using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Articles
{
    public partial class EditArticle : Form
    {
        private ArticleDTO article { get; set; }
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
            }
        }

        private async void DodajBtn_Click(object sender, EventArgs e)
        {
            ArticleDTO _article = new ArticleDTO
            {
                Id = article.Id,
                Title = Naziv.Text,
                Text = Tekst.Text,
                Tags = Tagovi.Text,
                AllowComments = Komentari.Checked,
                Date = Datum.Value,
                CategoryId = 1
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
