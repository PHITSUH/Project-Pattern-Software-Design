using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class MakeupTypeController
    {

        public static void updateMakeupType(int id, string name)
        {
            MakeupTypeHandler.updateMakeupType(id, name);
        }
        public static MakeupType findMakeupType(int id)
        {
            return MakeupTypeHandler.findMakeupType(id);
        }

        public static void removeMakeupType(int id)
        {
            MakeupTypeHandler.removeMakeupType(id);
        }

        public static List<MakeupType> getAllMakeupTypes()
        {
            return MakeupTypeHandler.getAllMakeupTypes();
        }

        public static void addMakeup(string name)
        {
            MakeupTypeHandler.addMakeup(name);
        }
        public static string validateMakeupType(string name)
        {
            if (name == "")
            {
                return "Name must be filled";
            }
            if(name.Length < 1 || name.Length > 99)
            {
                return "Name must be between 1 to 99 characters long";
            }

            return null;
        }
    }
}