using Salon_WebAPI.BusinessEntity.RequestResponse;
using Salon_WebAPI.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_WebAPI.Repository.Interface
{
    public interface IUserRepo
    {
        bool AddUser(User user);
        bool AddUserDetails(UserDetail userDetail);
        User GetUser(int userId);
        ResponseVM UserLogin(User user);
    }
}
