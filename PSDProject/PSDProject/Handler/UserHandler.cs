using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class UserHandler
    {
        public static User findUser(string username)
        {
            return UserRepository.findUser(username);
        }

        public static List<User> getAllUsers()
        {
            return UserRepository.getAllUsers();
        }
        public static Boolean loginUser(String username, String password)
        {
            
            List<User> users = UserRepository.getAllUsers();
            foreach(User u in users)
            {
                if(u.Username == username && u.UserPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean usernameIsUnique(String username)
        {
            List<User> users = UserRepository.getAllUsers();
            foreach (User u in users)
            {
                if (u.Username == username)
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean adminAuthenticate(object state)
        {
            if (state == null)
            {
                return false;
            }
            int id = Convert.ToInt32(state);
            User u = UserRepository.findUserById(id);
            if (!u.UserRole.Equals("Admin"))
            {
                return false;
            }
            return true;
        }

        public static Boolean customerAuthenticate(object state)
        {
            if(state == null)
            {
                return false;
            }
            int id = Convert.ToInt32(state);
            User u = UserRepository.findUserById(id);
            if (!u.UserRole.Equals("Customer"))
            {
                return false;
            }
            return true;
        }

        public static Boolean roleIsAdmin(int Id)
        {
            User user = UserRepository.findUserById(Id);
            if(user.UserRole == "Admin")
            {
                return true;
            }
            return false;
        }

        public static void registerUser(String username, String email, String gender, String password, String date)
        {
            int id;
            User lastUser = UserRepository.getAllUsers().LastOrDefault();
            if (lastUser == null)
            {
                id = 1;
            }
            else
            {
                id = lastUser.UserID + 1;
            }
            User user = UserFactory.createUser(id, username, email, gender, password, DateTime.Parse(date), "Customer");
            UserRepository.insertUser(user);
        }

        public static void updateUser(int id, string username, string email, string gender, string date)
        {
            UserRepository.updateUser(id, username, email, gender, DateTime.Parse(date));
        }

        public static void updatePassword(int id, string password)
        {
            UserRepository.updatePassword(id, password);
        }

        public static User getUser(int id)
        {
            return UserRepository.findUserById(id);
        }
    }
}