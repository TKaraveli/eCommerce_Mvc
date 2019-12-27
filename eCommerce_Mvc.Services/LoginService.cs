using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce_Mvc.Services
{
    public class LoginService
    {
        private static readonly string _username = "tayfun";
        private static readonly string _password = "1234";

        public bool IsExistLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) | string.IsNullOrWhiteSpace(password))
                return false;

            if (_username != username)
                return false;

            if (_password != password)
                return false;
            return true;
        }
    }
}
