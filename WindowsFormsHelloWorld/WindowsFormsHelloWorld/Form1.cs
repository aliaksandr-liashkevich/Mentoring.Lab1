using System;
using System.Windows.Forms;
using ClassLibraryNetStandard;

namespace WindowsFormsHelloWorld
{
    public partial class Form : System.Windows.Forms.Form
    {
        public const string Title = "Hello";

        public Form()
        {
            InitializeComponent();
        }

        private void HiButton_Click(object sender, EventArgs e)
        {
            var userName = UserNameTextBox.Text;
            MessageBox.Show(User.SayHello(userName));
        }
    }
}
