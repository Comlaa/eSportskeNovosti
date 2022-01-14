using System.Windows.Forms;

namespace ESN_WinForm.Helpers
{
    public static class ValidateInput
    {
        public static bool Text(Control control, int characters, string text, ErrorProvider errorProvider)
        {
            var response = control.Text.Length < characters ? text : "";

            errorProvider.SetError(control, response);

            return !(control.Text.Length < characters);
        }
    }
}
