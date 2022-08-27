using Salon_WebAPI.BusinessEntity.RequestResponse;
using Salon_WebAPI.DomainEntities;
using Salon_WebAPI.Helper.TokenManager;
using Salon_WebAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_WebAPI.Repository.Concrete
{
    public class UserRepo : IUserRepo
    {
        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool AddUserDetails(UserDetail userDetail)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public ResponseVM UserLogin(User user)
        {
            var data = new User();
            using (SalonAppEntities salonAppEntities = new SalonAppEntities())
            {
                data = salonAppEntities.Users.Where(y => y.Username == user.Username && y.Password == user.Password).FirstOrDefault();


            }

            if (data == null)
                return new ResponseVM { Status = "Invalid", Message = "Invalid User." };
            //if (objlst.Status == 2)
            //    return new ResponseVM { Status = "Invalid", Message = "Already Logged In." };

            else
                return new ResponseVM { Status = "Success", Message = TokenManager.GenerateToken(user.Username) };
        }
    }
}
