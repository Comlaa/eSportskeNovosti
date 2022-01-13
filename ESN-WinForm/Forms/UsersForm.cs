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

        private void PretraziBtn_Click(object sender, EventArgs e)
        {
            SearchBox_TextChanged(null, null);
        }

        private async void PopulateTable()
        {
            var response = await UserService.GetAllUsers();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            KorisniciTabela.DataSource = dataTable;
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBox_TextChanged(null, null);
        }

        private async void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                var response = await UserService.GetAllUsersByUsername(SearchBox.Text);
                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
                KorisniciTabela.DataSource = dataTable;
            }
            else
            {
                PopulateTable();
            }
        }
    }
}
