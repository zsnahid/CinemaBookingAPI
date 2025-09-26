using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;

namespace DAL.Repos
{
    internal class UserRepo : IRepo<User, int, bool>, IUserFeature
    {
        BMSContext db;

        public UserRepo()
        {
            db = new BMSContext();
        }

        public bool Create(User obj)
        {
            obj.IsAdmin = false;
            obj.CreatedAt = DateTime.Now;
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var existingUser = db.Users.Find(id);
            if (existingUser == null)
                return false;

            db.Users.Remove(existingUser);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmail(int id, string email)
        {
            var user = db.Users.Find(id);
            if (user == null)
                return false;

            user.Email = email;
            return db.SaveChanges() > 0;
        }

        public bool UpdatePassword(int id, string password)
        {
            var user = db.Users.Find(id);
            if (user == null)
                return false;

            user.Password = password;
            return db.SaveChanges() > 0;
        }

        public bool UpdateUserName(int id, string userName)
        {
            var user = db.Users.Find(id);
            if (user == null)
                return false;

            user.UserName = userName;
            return db.SaveChanges() > 0;
        }
    }
}
