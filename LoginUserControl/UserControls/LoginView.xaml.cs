using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginUserControl.UserControls
{
    /// <summary>
    /// Interaction logic for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        private static List<Models.CredentialsSource> credentials;
        public LoginUC()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            passwordTB.Password = String.Empty;
            userNameTB.Text = String.Empty;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string password = passwordTB.Password.ToString();
            string username = userNameTB.Text;
            credentials.Add(new Models.CredentialsSource(username,password));
        }

        public static List<Models.CredentialsSource> GetCredentials()
        {
            var result = credentials.ToList<Models.CredentialsSource>();
            return result;
        }
     } 
}
