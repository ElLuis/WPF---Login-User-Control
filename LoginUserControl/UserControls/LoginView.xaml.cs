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
        private string username;
        private string password;
  
        public LoginUC()
        {
            InitializeComponent();
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = userNameTB.Text;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                username = passwordTB.Password;
            }
        }
    } 
}
