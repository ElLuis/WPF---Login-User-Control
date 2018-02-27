using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUserControl.Models
{
    public class CredentialsSource
    {
        private string password, username;

        //Properties

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }


        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public CredentialsSource(string _username, string _password)
        {
            this.username = _username;
            this.password = _password;
        }
    }
}
