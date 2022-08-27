using Salon_WebAPI.Repository.Concrete;
using Salon_WebAPI.Repository.Interface;
using Salon_WebAPI.Service.Concrete;
using Salon_WebAPI.Service.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Salon_WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IUserRepo, UserRepo>();
            container.RegisterType<IUserService, UserService>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}