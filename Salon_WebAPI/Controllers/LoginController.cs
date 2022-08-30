using Salon_WebAPI.BusinessEntity;
using Salon_WebAPI.BusinessEntity.RequestResponse;
using Salon_WebAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Salon_WebAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        public IUserService userService { get; set; }
       
        public LoginController(IUserService _userService)
        {
            userService = _userService;
        }

        // GET: Login
        [System.Web.Http.Route("UserLogin")]
        [System.Web.Http.HttpPost]
        public ResponseVM Index([FromBody] UserViewModel userVM)
        {
            var data= userService.UserLogin(userVM);
            return data;
        }
    }
}