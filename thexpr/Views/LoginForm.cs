using System;
using System.Windows.Forms;
using ThExpr.Models;
using ThExpr.Services;
using ThExpr.Utility;

namespace thexpr.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsUtility.Basic_Username = input_username.Text;
            SettingsUtility.Basic_Password = input_password.Text;
            User user = UserService.getUser();
            if (user != null)
            {
                Console.WriteLine(user.id);
            }
            else
            {
                
            }
        }
    }
}
