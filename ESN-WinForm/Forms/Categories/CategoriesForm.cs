using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Categories
{
    public partial class CategoriesForm : Form
    {
        public static int CategoryId { get; set; }
        public CategoriesForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private async void PopulateTable()
        {
            var response = await CategoryService.GetAllCategories();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            KategorijaTabela.DataSource = dataTable;
            KategorijaTabela.AutoResizeColumns();
            KategorijaTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PretraziBtn_Click(object sender, EventArgs e)
        {
            SearchBox_TextChanged(null, null);
        }

        private async void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                var response = await CategoryService.GetAllCategorysByName(SearchBox.Text);
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
                KategorijaTabela.DataSource = dataTable;
            }
            else
            {
                PopulateTable();
            }
        }

        private async void ObrisiBtn_Click(object sender, EventArgs e)
        {
            if (KategorijaTabela.SelectedRows.Count > 0)
            {
                var selectedCategory = KategorijaTabela.SelectedRows[0].DataBoundItem as DataRowView;
                var categoryId = selectedCategory.Row.ItemArray[2].ToString();
                await CategoryService.Delete(int.Parse(categoryId));
                PopulateTable();
            }
        }

        private void UrediBtn_Click(object sender, EventArgs e)
        {
            if (KategorijaTabela.SelectedRows.Count > 0)
            {
                var selectedArticle = KategorijaTabela.SelectedRows[0].DataBoundItem as DataRowView;
                CategoryId = int.Parse(selectedArticle.Row.ItemArray[2].ToString());

                Hide();
                EditCategory editCategory = new EditCategory();
                editCategory.ShowDialog();
                PopulateTable();
                Show();
            }
        }

        private async void DodajBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                CategoryDTO category = new CategoryDTO
                {
                    Name = Naziv.Text,
                    Description = Opis.Text,
                };
                await CategoryService.Add(category);
                PopulateTable();
                Naziv.Text = "";
                Opis.Text = "";
            }
        }

        private bool ValidateInputs()
        {
            if (ValidateInput.Text(Naziv, 3, "Naziv kategorije mora biti duži od 3 karaktera!", errorProvider1) &&
                ValidateInput.Text(Opis, 10, "Opis kategorije mora biti duži od 10 karaktera!", errorProvider1))
                return true;

            return false;
        }
    }
}
