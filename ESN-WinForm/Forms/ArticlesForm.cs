using System;
using System.Windows.Forms;

namespace ESN_WinForm.Forms
{
    public partial class ArticlesForm : Form
    {
        public ArticlesForm()
        {
            InitializeComponent();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            var form = new HomeForm();
            form.ShowDialog();

            Close();
        }
    }
}
