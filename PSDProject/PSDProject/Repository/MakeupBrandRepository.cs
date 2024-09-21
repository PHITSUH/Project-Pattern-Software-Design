using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class MakeupBrandRepository
    {

        public static List<MakeupBrand> getAllMakeupBrands()
        {
            return DBSingleton.getInstance().MakeupBrands.ToList();
        }

        public static void removeMakeupBrand(int id)
        {
            MakeupBrand mb = DBSingleton.getInstance().MakeupBrands.Find(id);
            DBSingleton.getInstance().MakeupBrands.Remove(mb);
            DBSingleton.getInstance().SaveChanges();
        }

        public static void addMakeupBrand(MakeupBrand mb)
        {
            DBSingleton.getInstance().MakeupBrands.Add(mb);
            DBSingleton.getInstance().SaveChanges() ;
        }

        public static MakeupBrand findMakeupBrand(int id)
        {
            return DBSingleton.getInstance().MakeupBrands.Find(id);
        }

        public static void updateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand mb = findMakeupBrand(id);
            mb.MakeupBrandName = name;
            mb.MakeupBrandRating = rating;
            DBSingleton.getInstance().SaveChanges();
        }
        
    }
}