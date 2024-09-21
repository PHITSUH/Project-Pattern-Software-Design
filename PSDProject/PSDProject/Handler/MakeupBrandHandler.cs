using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class MakeupBrandHandler
    {

        public static void updateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrandRepository.updateMakeupBrand(id, name, rating);
        }
        
        public static MakeupBrand findMakeupBrand(int id)
        {
            return MakeupBrandRepository.findMakeupBrand(id);
        }

        public static void removeMakeupBrand(int id)
        {
            MakeupBrandRepository.removeMakeupBrand(id);
        }

        public static List<MakeupBrand> getAllMakeupBrands()
        {
            return MakeupBrandRepository.getAllMakeupBrands();
        }
        public static Boolean idExists(int id)
        {
            if (DBSingleton.getInstance().MakeupBrands.Find(id) == null)
            {
                return false;
            }
            return true;
        }

        public static void addMakeupBrand(string name, int rating)
        {
            int id = generateId();
            MakeupBrand mb = MakeupBrandFactory.createMakeupBrand(id, name, rating);
            MakeupBrandRepository.addMakeupBrand(mb);
        }

        public static int generateId()
        {
            if (MakeupBrandRepository.getAllMakeupBrands().LastOrDefault() == null)
            {
                return 1;
            }
            return MakeupBrandRepository.getAllMakeupBrands().LastOrDefault().MakeupBrandID + 1;
        }
    }
}