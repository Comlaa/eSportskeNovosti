using ESN_WinForm.Forms;
using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using System;
using System.Windows.Forms;

namespace ESN_WinForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Error.Visible = false;
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            var response = await UserService.Login(Username.Text, Password.Text);
            if (response.Equals(Constants.Success))
            {
                Error.Visible = false;
                Username.Text = "";
                Password.Text = "";
                Hide();
                var form = new HomeForm();
                form.ShowDialog();
                Show();
            }
            else
            {
                Error.Visible = true;
            }
        }
    }
}
