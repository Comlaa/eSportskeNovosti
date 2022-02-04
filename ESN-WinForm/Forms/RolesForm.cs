using ESN_WinForm.DTO;
using ESN_WinForm.Forms.Roles;
using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace ESN_WinForm.Forms
{
    public partial class RolesForm : Form
    {
        public static int RoleId { get; set; }
        public RolesForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        private async void PopulateTable()
        {
            var response = await RoleService.GetAllRoles();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            RolaTabela.DataSource = dataTable;
            RolaTabela.AutoResizeColumns();
            RolaTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool ValidateInputs()
        {
            if (ValidateInput.Text(Naziv, 3, "Naziv role mora biti duži od 3 karaktera!", errorProvider1) &&
                ValidateInput.Text(Permisije, 3, "Permisije moraju biti duže od 3 karaktera!", errorProvider1))
                return true;

            return false;
        }

        private async void DodajBtn_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                RoleDTO role = new RoleDTO
                {
                    Name = Naziv.Text,
                    Description = Permisije.Text,
                };
                var response = await RoleService.Add(role);
                PopulateTable();
                Naziv.Text = "";
                Permisije.Text = "";
            }
        }

        private void NazadBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void UrediBtn_Click_1(object sender, EventArgs e)
        {
            if (RolaTabela.SelectedRows.Count > 0)
            {
                var selectedRole = RolaTabela.SelectedRows[0].DataBoundItem as DataRowView;
                RoleId = int.Parse(selectedRole.Row.ItemArray[2].ToString());

                Hide();
                EditRole editRole = new EditRole();
                editRole.ShowDialog();
                PopulateTable();
                Show();
            }
        }

        private async void ObrisiBtn_Click_1(object sender, EventArgs e)
        {
            if (RolaTabela.SelectedRows.Count > 0)
            {
                var selectedRole = RolaTabela.SelectedRows[0].DataBoundItem as DataRowView;
                var roleId = selectedRole.Row.ItemArray[2].ToString();
                await RoleService.Delete(int.Parse(roleId));
                PopulateTable();
            }
        }
    }
}
