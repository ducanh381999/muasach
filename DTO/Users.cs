using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {
        private string Username;

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
        private string Password;

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

    }
}
