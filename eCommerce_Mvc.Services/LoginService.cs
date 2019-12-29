using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce_Mvc.Services
{
    public class LoginService
    {
        private static readonly string _email = "tayfunkaraveli@hotmail.com";
        private static readonly string _password = "1234";

        public bool IsExistLogin(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) | string.IsNullOrWhiteSpace(password))
                return false;

            if (_email != email)
                return false;

            if (_password != password)
                return false;
            return true;
        }
    }
}
