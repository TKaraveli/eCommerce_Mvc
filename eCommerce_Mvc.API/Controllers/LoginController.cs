using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eCommerce_Mvc.Services;

namespace eCommerce_Mvc.API.Controllers
{
    //[EnableCors("*", "*", "*")]
    public class LoginController : ApiController
    {
        private readonly LoginService _loginService;

        public LoginController()
        {
            _loginService = new LoginService();
        }

        [HttpGet]
        public IHttpActionResult Get(string id, string pass)
        {
            var result = _loginService.IsExistLogin(id, pass);

            return Ok(result);
        }
    }
}
