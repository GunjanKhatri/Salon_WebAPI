﻿using Salon_WebAPI.BusinessEntity;
using Salon_WebAPI.BusinessEntity.RequestResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_WebAPI.Service.Interface
{
    public interface IUserService
    {
        bool AddUser(UserViewModel user);
        bool AddUserDetails(UserDetailViewModel userDetail);
        UserViewModel GetUser(int userId);
        ResponseVM UserLogin(UserViewModel user);
    }
}
