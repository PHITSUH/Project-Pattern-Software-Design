using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class MakeupController
    {

        public static void updateMakeup(int id, string name, int price, int weight, int brandId, int typeId)
        {
            MakeupHandler.updateMakeup(id, name, price, weight, brandId, typeId);
        }
        
        public static Makeup findMakeup(int id)
        {
            return MakeupHandler.findMakeup(id);
        }

        public static void removeByTypeId(int typeId)
        {
            MakeupHandler.removeByTypeId(typeId);
        }

        public static void removeByBrandId(int brandId)
        {
            MakeupHandler.removeByBrandId(brandId);
        }

        public static void removeMakeup(int id)
        {
            MakeupHandler.removeMakeup(id);
        }

        public static List<Makeup> getAllMakeups()
        {
            return MakeupHandler.getAllMakeups();
        }

        public static void addMakeup(string name, int price, int weight, int brandId, int TypeId)
        {
            MakeupHandler.addMakeup(name, price, weight, brandId, TypeId);
        }
        public static string validateMakeup(string name, string price, string weight, string brandId, string typeId)
        {
            if (name == "")
            {
                return "Name must be filled";
            }
            if(name.Length < 1 || name.Length > 99)
            {
                return "Name must be between 1 to 99 characters long";
            }
            if (price == "")
            {
                return "Price must be filled";
            }
            if (Convert.ToInt32(price) < 1)
            {
                return "Price must be more or equal than 1";
            }
            if (weight == "")
            {
                return "Weight must be filled";
            }
            if (Convert.ToInt32(weight) > 1500 || Convert.ToInt32(weight) < 1)
            {
                return "Weight must be between 1 and 1500";
            }
            if (brandId == "")
            {
                return "Makeup Brand ID must be filled";
            }
            if (!MakeupBrandHandler.idExists(Convert.ToInt32(brandId)))
            {
                return "Makeup Brand ID does not exist";
            }
            if (typeId == "")
            {
                return "Makeup Type ID must be filled";
            }
            if (!MakeupTypeHandler.idExists(Convert.ToInt32(typeId)))
            {
                return "Makeup Type ID does not exist";
            }

            return null;
        }
    }
}