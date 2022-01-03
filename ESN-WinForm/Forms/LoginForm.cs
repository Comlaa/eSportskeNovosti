﻿using ESN_WinForm.Services;
using System;
using System.Windows.Forms;

namespace ESN_WinForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            var response = await UserService.Login(Username.Text, Password.Text);
        }
    }
}