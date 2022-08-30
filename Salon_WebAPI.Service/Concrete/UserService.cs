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
        public void AddUser(UserViewModel userViewModel)
        {
            var user = new User();
            user.Username = userViewModel.UserName;
            user.Password = userViewModel.Password;
            userRepo.AddUser(user);
        }

        public void AddUserDetails(UserDetailViewModel userDetailVM)
        {
            var userDetail = new UserDetail();
            userDetail.FirstName = userDetailVM.FirstName;
            userDetail.LastName = userDetailVM.LastName;
            userDetail.ContactNo = userDetailVM.ContactNo;
            userDetail.EmailId = userDetailVM.EmailId;
            //userDetail.UserId = userDetailVM.us
            userRepo.AddUserDetails(userDetail);
        }

        public UserViewModel GetUser(int userId)
        {
            var user = userRepo.GetUser(userId);
            var userVM = new UserViewModel();
            userVM.Id = user.Id;
            userVM.UserName = user.Username;
            userVM.Password = user.Password;

            return userVM;
        }

        public ResponseVM UserLogin(UserViewModel userViewModel)
        {
            var user = new User();
            user.Id = userViewModel.Id;
            user.Username = userViewModel.UserName;
            user.Password = userViewModel.Password;
            return userRepo.UserLogin(user);
        }
    }
}
