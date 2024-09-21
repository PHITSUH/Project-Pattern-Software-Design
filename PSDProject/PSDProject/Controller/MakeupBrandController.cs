using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class MakeupBrandController
    { 

        public static void updateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrandHandler.updateMakeupBrand(id, name, rating);
        }

        public static MakeupBrand findMakeupBrand(int id)
        {
            return MakeupBrandHandler.findMakeupBrand(id);
        }

        public static void removeMakeupBrand(int id)
        {
            MakeupBrandHandler.removeMakeupBrand(id);
        }

        public static List<MakeupBrand> getAllMakeupBrands()
        {
            return MakeupBrandHandler.getAllMakeupBrands();
        }
        
        public static void addMakeupBrand(string name, int rating)
        {
            MakeupBrandHandler.addMakeupBrand(name, rating);
        }
        public static string validateMakeupBrand(string name, int rating) 
        {
            if(name == "")
            {
                return "Name must be filled";
            }
            if(name.Length < 1 || name.Length > 99)
            {
                return "Name must be 1 to 99 characters long";
            }
            if(rating < 0 || rating > 100)
            {
                return "Rating must be between 0 to 100";
            }

            return null;
        }
    }
}