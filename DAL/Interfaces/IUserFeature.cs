using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserFeature
    {
        bool UpdateEmail(int id, string email);
        bool UpdatePassword(int id, string password);
        bool UpdateUserName(int id, string userName);
    }
}
