using Salon_WebAPI.Repository.Concrete;
using Salon_WebAPI.Repository.Interface;
using Salon_WebAPI.Service.Concrete;
using Salon_WebAPI.Service.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Salon_WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRepo, UserRepo>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}