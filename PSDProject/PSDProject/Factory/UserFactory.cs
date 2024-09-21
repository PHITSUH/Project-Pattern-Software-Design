using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class UserFactory
    {
        public static User createUser(int id, String username, String email, String gender, String password, DateTime date, String role)
        {
            User user = new User();
            user.UserGender = gender;
            user.UserRole = role;
            user.UserPassword = password;
            user.UserDOB = date;
            user.Username = username;
            user.UserID = id;
            user.UserEmail = email;
            return user;
            
        }
    }
}