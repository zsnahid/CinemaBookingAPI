using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }

        public static IUserFeature UserFeature()
        {
            return new UserRepo();
        }
    }
}
