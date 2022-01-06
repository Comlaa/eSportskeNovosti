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
    }
}
