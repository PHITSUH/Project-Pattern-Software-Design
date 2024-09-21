using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace PSDProject.Controller
{
    public class UserController
    {

        public static void registerUser(string name, string email, string gender, string password, string date)
        {
            UserHandler.registerUser(name, email, gender, password, date);
        }

        public static void updatePassword(int id, string newPass)
        {
            UserHandler.updatePassword(id, newPass);
        }
        public static void updateUser(int id, string username, string email, string gender, string date)
        {
            UserHandler.updateUser(id, username, email, gender, date);  
        }

        public static User findUser(string username)
        {
            return UserHandler.findUser(username);
        }
        public static List<User> getAllUsers()
        {
            return UserHandler.getAllUsers();
        }
        public static Boolean roleIsAdmin(int id)
        {
            return UserHandler.roleIsAdmin(id);
        }
        public static User getUser(int id)
        {
            return UserHandler.getUser(id);
        }
        public static Boolean adminAuthenticate(object obj)
        {
            return UserHandler.adminAuthenticate(obj);
        }
        public static String loginUser(String username, String password)
        {
            if(username == "")
            {
                return "Please Insert Username";
            }
            if(password == "")
            {
                return "Please Insert Password";
            }
            if(!UserHandler.loginUser(username, password))
            {
                return "Invalid Credentials";
            }

            return null;
        }

        public static String updatePassword(int id, string oldPass, string newPass)
        {
            User user = UserRepository.findUserById(id);
            if (oldPass == "")
            {
                return "Old Password must be filled";
            }
            if (newPass == "")
            {
                return "New Password must be filled";
            }
            if (!oldPass.Equals(user.UserPassword))
            {
                return "Old Password is wrong";
            }
            if (!Regex.IsMatch(newPass, @"^[a-zA-Z0-9]*$"))
            {
                return "New Password is not alphanumeric";
            }

            return null;

        }

        public static String updateUser(String username, String email, String gender, String date)
        {

            if (username == "")
            {
                return "Please Input Username";
            }
            if (email == "")
            {
                return "Please Input Email";
            }
            if (gender == "")
            {
                return "Please Select a Gender";
            }
            if (date == "")
            {
                return "Please Input Date";
            }
            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must be between 5 to 15 characters long";
            }
            if (!UserHandler.usernameIsUnique(username))
            {
                return "Username must be unique";
            }
            if (!email.EndsWith(".com"))
            {
                return "Email must ends with .com";
            }
            return null;
        }

        public static String registerUser(String username, String email, String gender, String password, String confirm, String date)
        {
            if(username == "")
            {
                return "Please Input Username";
            }
            if(email == "")
            {
                return "Please Input Email";
            }
            if(gender == "")
            {
                return "Please Select a Gender";
            }
            if(password == "")
            {
                return "Please Input Password";
            }
            if(date == "")
            {
                return "Please Input Date";
            }
            if(username.Length < 5 || username.Length > 15)
            {
                return "Username must be between 5 to 15 characters long";
            }
            if (!UserHandler.usernameIsUnique(username))
            {
                return "Username must be unique";
            }
            if (!email.EndsWith(".com"))
            {
                return "Email must ends with .com";
            }
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]*$"))
            {
                return "Password must be alphanumeric";
            }
            if (!password.Equals(confirm))
            {
                return "Password and Confirm Password is not the same";
            }

            return null;
        }
    }
}