using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Categories
{
    public partial class EditCategory : Form
    {
        public EditCategory()
        {
            InitializeComponent();
            PopulateForm();
        }

        private async void DodajBtn_Click(object sender, EventArgs e)
        {
            CategoryDTO category = new CategoryDTO
            {
                Name = Naziv.Text,
                Description = Description.Text,
                Id = CategoriesForm.CategoryId
            };
            await CategoryService.Edit(category);
            NazadBtn_Click(null, null);
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private async void PopulateForm()
        {
            var response = await CategoryService.GetCategoryById(CategoriesForm.CategoryId);
            if (response != null)
            {
                var category = JsonConvert.DeserializeObject<CategoryDTO>(response);
                Naziv.Text = category.Name;
                Description.Text = category.Description;
            }
        }
    }
}