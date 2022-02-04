using ESN_WinForm.Forms.Categories;
using System;
using System.Windows.Forms;

namespace ESN_WinForm.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            var datum = DateTime.Now.ToString("f");
            Datum.Text = datum.Remove(datum.Length - 5);
        }

        private void VijestiBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ArticlesForm form = new ArticlesForm();
            form.ShowDialog();
            Show();
        }

        private void KorisniciBtn_Click(object sender, EventArgs e)
        {
            Hide();
            UsersForm form = new UsersForm();
            form.ShowDialog();
            Show();
        }

        private void RoleBtn_Click(object sender, EventArgs e)
        {
            Hide();
            RolesForm form = new RolesForm();
            form.ShowDialog();
            Show();
        }

        private void KategorijeBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CategoriesForm form = new CategoriesForm();
            form.ShowDialog();
            Show();
        }

        private void OdjaviBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.DialogResult = DialogResult.OK;
        }
    }
}
