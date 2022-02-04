using ESN_WinForm.Services;
using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms;

namespace ESN_WinForm.Forms
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        private async void PopulateTable()
        {
            var response = await UserService.GetSupportTickets();
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(response, (typeof(DataTable)));
            SupportTicketsTabela.DataSource = dataTable;
        }

        private void NazadBtn_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
