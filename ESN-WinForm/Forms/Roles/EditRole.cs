using ESN_WinForm.DTO;
using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace ESN_WinForm.Forms.Roles
{
    public partial class EditRole : Form
    {
        public EditRole()
        {
            InitializeComponent();
            PopulateForm();
        }

        private async void PopulateForm()
        {
            var response = await RoleService.GetRoleById(RolesForm.RoleId);
            if (response != null)
            {
                var role = JsonConvert.DeserializeObject<RoleDTO>(response);
                Naziv.Text = role.Name;
                Permisije.Text = role.Description;
            }
        }

        private bool ValidateInputs()
        {
            if (ValidateInput.Text(Naziv, 3, "Naziv role mora biti duži od 3 karaktera!", errorProvider1) &&
                ValidateInput.Text(Permisije, 3, "Permisije moraju biti duže od 3 karaktera!", errorProvider1))
                return true;

            return false;
        }

        private void NazadBtn_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private async void DodajBtn_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                RoleDTO role = new RoleDTO
                {
                    Name = Naziv.Text,
                    Description = Permisije.Text,
                    Id = RolesForm.RoleId
                };
                await RoleService.Edit(role);
                NazadBtn_Click_1(null, null);
            }
        }
    }
}
