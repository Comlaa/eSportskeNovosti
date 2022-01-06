using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESN_WinForm.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        private async void PretraziBtn_Click(object sender, EventArgs e)
        {
            var response = await UserService.GetAllUsersByUsername(SearchBox.Text);
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            KorisniciTabela.DataSource = dataTable;
        }

        private async void PopulateTable()
        {
            var response = await UserService.GetAllUsers();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            KorisniciTabela.DataSource = dataTable;
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            var form = new HomeForm();
            form.ShowDialog();

            Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PretraziBtn_Click(sender, e);
        }
    }
}
