using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Categories
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            var form = new HomeForm();
            form.ShowDialog();
            this.Visible = false;
        }

        private async void PopulateTable()
        {
            var response = await ArticleService.GetAllArticles();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            VijestiTabela.DataSource = dataTable;
        }

        private void PretraziBtn_Click(object sender, EventArgs e)
        {
            SearchBox_TextChanged(null, null);
        }

        private async void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                var response = await ArticleService.GetAllArticlesByTitle(SearchBox.Text);
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
                VijestiTabela.DataSource = dataTable;
            }
        }

        private async void ObrisiBtn_Click(object sender, EventArgs e)
        {
            var selectedArticle = VijestiTabela.SelectedRows[0].DataBoundItem as DataRowView;
            var articleId = selectedArticle.Row.ItemArray[0].ToString();
            await ArticleService.Delete(int.Parse(articleId));
            PopulateTable();
        }

        private void UrediBtn_Click(object sender, EventArgs e)
        {
            //var selectedArticle = VijestiTabela.SelectedRows[0].DataBoundItem as DataRowView;
            //ArticleId = int.Parse(selectedArticle.Row.ItemArray[0].ToString());

            //EditArticle editArticle = new EditArticle();
            //editArticle.ShowDialog();
        }

    }
}
