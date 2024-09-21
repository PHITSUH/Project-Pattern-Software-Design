using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class MakeupTypeHandler
    {

        public static void updateMakeupType(int id, string name)
        {
            MakeupTypeRepository.updateMakeupType(id, name);
        }

        public static MakeupType findMakeupType(int id)
        {
            return MakeupTypeRepository.findMakeupType(id);
        }

        public static void removeMakeupType(int id)
        {
            MakeupTypeRepository.removeMakeupType(id);  
        }
        
        public static List<MakeupType> getAllMakeupTypes()
        {
            return MakeupTypeRepository.getAllMakeupTypes();
        }
        public static Boolean idExists(int id)
        {
            if (MakeupTypeRepository.findMakeupType(id) == null)
            {
                return false;
            }
            return true;
        }

        public static int generateId()
        {
            if(MakeupTypeRepository.getAllMakeupTypes().LastOrDefault() == null)
            {
                return 1;
            }

            return MakeupTypeRepository.getAllMakeupTypes().LastOrDefault().MakeupTypeID + 1;
        }

        public static void addMakeup(string name)
        {
            int id = generateId();
            MakeupType mt = MakeupTypeFactory.createMakeupType(id, name);
            MakeupTypeRepository.addMakeupType(mt);
        }
    }
}