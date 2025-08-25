using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session05_Solution.Authentication
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "admin";
        private string storedPassword = "1234";
        private string storedRole = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
