using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class MakeupHandler
    {

        public static void updateMakeup(int id, string name, int price, int weight, int brandId, int TypeId)
        {
            MakeupRepository.updateMakeup(id, name, price, weight, brandId, TypeId);
        }

        public static Makeup findMakeup(int id)
        {
            return MakeupRepository.findMakeup(id);
        }

        public static void removeByTypeId(int id)
        {
            MakeupRepository.removeByTypeId(id);
        }
        
        public static void removeByBrandId(int id)
        {
            MakeupRepository.removeByBrandId(id);
        }
        
        public static void removeMakeup(int id)
        {
            MakeupRepository.removeMakeup(id);
        }

        public static List<Makeup> getAllMakeups()
        {
            return MakeupRepository.getAllMakeups();
        }

        public static int generateId()
        {
            if(MakeupRepository.getAllMakeups().LastOrDefault() == null) {
                return 1;
            }
            return MakeupRepository.getAllMakeups().LastOrDefault().MakeupID + 1;

        }

        public static void addMakeup(string name, int price, int weight, int typeId, int brandId)
        {
            int id = generateId();
            Makeup m = MakeupFactory.createMakeup(id, name, price, weight, typeId, brandId);
            MakeupRepository.addMakeup(m);
        }
    }
}