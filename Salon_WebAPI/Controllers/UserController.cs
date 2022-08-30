using Salon_WebAPI.BusinessEntity;
using Salon_WebAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Salon_WebAPI.Controllers
{
    public class UserController : ApiController
    {
        public IUserService userService { get; set; }
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        // GET: Product
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("getUser")]
        public UserViewModel getUser([FromUri] int userId)
        {
            if (ModelState.IsValid)
            {
                //return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return userService.GetUser(userId);
        }

        //[System.Web.Http.HttpPost]
        //[System.Web.Http.Route("addUser")]
        //public void addProduct([FromBody] UserViewModel userViewModel)
        //{
        //     userService.AddUser(userViewModel);
        //}

        //[System.Web.Http.HttpDelete]
        //[System.Web.Http.Route("deleteProduct")]
        //public bool deleteProduct(int productId)
        //{
        //    return productService.DeleteProduct(productId);
        //}

        //[System.Web.Http.HttpPut]
        //[System.Web.Http.Route("updateProduct")]
        //public bool updateProduct([FromUri] int productId, [FromBody] ProductViewModel productViewModel)
        //{
        //    return productService.UpdateProduct(productId, productViewModel);
        //}
    }
}
