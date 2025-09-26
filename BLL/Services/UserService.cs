using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();
            });
            return new Mapper(config);
        }

        public static List<UserDTO> Get()
        {
            var users = DataAccessFactory.UserData().Get();
            return GetMapper().Map<List<UserDTO>>(users);
        }

        public static UserDTO Get(int id)
        {
            var user = DataAccessFactory.UserData().Get(id);
            return GetMapper().Map<UserDTO>(user);
        }

        public static bool Create(UserDTO obj)
        {
            var user = GetMapper().Map<User>(obj);
            return DataAccessFactory.UserData().Create(user);
        }

        public static bool UpdateEmail(int id, string email)
        {
            return DataAccessFactory.UserFeature().UpdateEmail(id, email);
        }

        public static bool UpdatePassword(int id, string password)
        {
            return DataAccessFactory.UserFeature().UpdatePassword(id, password);
        }

        public static bool UpdateUserName(int id, string userName)
        {
            return DataAccessFactory.UserFeature().UpdateUserName(id, userName);
        }
    }
}
