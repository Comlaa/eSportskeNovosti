using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESN_WinForm.Forms
{
    public partial class FixtureForm : Form
    {
        private CategoryDTO[] Categories { get; set; }
        public FixtureForm()
        {
            InitializeComponent();
            PopulateCategories();
            PopulateTable();
        }

        private async void DodajBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var categoryId = 1;
                foreach (var category in Categories)
                {
                    if (category.Name.Equals(Kategorije.SelectedItem.ToString()))
                        categoryId = category.Id;
                }

                FixtureDTO fixture = new FixtureDTO
                {
                    Team1 = Tim1.Text,
                    Team2 = Tim2.Text,
                    Result = Rezultat.Text,
                    CategoryId = categoryId,
                };
                await FixtureService.Add(fixture);
                PopulateTable();
                Tim1.Text = "";
                Tim2.Text = "";
                Rezultat.Text = "";
            }
        }

        private async void PopulateTable()
        {
            var response = await FixtureService.GetFixtures();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            RezultatiTabela.DataSource = dataTable;
            RezultatiTabela.AutoResizeColumns();
            RezultatiTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void PopulateCategories()
        {
            Categories = JsonConvert.DeserializeObject<CategoryDTO[]>(await CategoryService.GetAllCategories());
            foreach (var category in Categories)
            {
                Kategorije.Items.Add(category.Name);
            }
            Kategorije.SelectedIndex = 0;
        }

        private bool ValidateInputs()
        {
            if (ValidateInput.Text(Tim1, 3, "Naziv tima mora biti duži od 3 karaktera!", errorProvider1) &&
                ValidateInput.Text(Tim2, 3, "Naziv tima mora biti duži od 3 karaktera!", errorProvider1) &&
                ValidateInput.Text(Rezultat, 2, "Rezultat mora biti duži od 2 karaktera!", errorProvider1))
                return true;

            return false;
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
