using Salon_WebAPI.BusinessEntity;
using Salon_WebAPI.BusinessEntity.RequestResponse;
using Salon_WebAPI.DomainEntities;
using Salon_WebAPI.Repository.Interface;
using Salon_WebAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_WebAPI.Service.Concrete
{
    public class UserService : IUserService
    {
        public IUserRepo userRepo { get; set; }
        public UserService(IUserRepo _userRepo)
        {
            userRepo = _userRepo;
        }
        public bool AddUser(UserViewModel user)
        {
            throw new NotImplementedException();
        }

        public bool AddUserDetails(UserDetailViewModel userDetail)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public ResponseVM UserLogin(UserViewModel userViewModel)
        {
            var user = new User();
            user.Username = userViewModel.UserName;
            user.Password = userViewModel.Paswword;
            return userRepo.UserLogin(user);
        }
    }
}
