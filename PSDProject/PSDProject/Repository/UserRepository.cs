using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class UserRepository
    {

        public static List<User> getAllUsers()
        {
            return DBSingleton.getInstance().Users.ToList();
        }

        public static void insertUser(User user)
        {
            DBSingleton.getInstance().Users.Add(user);
            DBSingleton.getInstance().SaveChanges();
        }

        public static User findUser(String username)
        {
            List<User> users = DBSingleton.getInstance().Users.ToList();
            foreach(User u in users)
            {
                if(u.Username == username)
                {
                    return u;
                }
            }
            return null;
        }

        public static User findUserById(int id)
        {
            List<User> users = DBSingleton.getInstance().Users.ToList();
            foreach (User u in users)
            {
                if (u.UserID == id)
                {
                    return u;
                }
            }
            return null;
        }

        public static void updateUser(int id, string username, string email, string gender, DateTime date)
        {
            User user = findUserById(id);
            user.Username = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = date;
            DBSingleton.getInstance().SaveChanges();
        }

        public static void updatePassword(int id, string password) {
            User user = findUserById(id);
            user.UserPassword = password;
            DBSingleton.getInstance().SaveChanges();
        }
    }
}