using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class MakeupRepository
    {
        public static List<Makeup> getAllMakeups()
        {
            return DBSingleton.getInstance().Makeups.ToList();
        }

        public static void removeMakeup(int id)
        {
            Makeup makeup = DBSingleton.getInstance().Makeups.Find(id);
            DBSingleton.getInstance().Makeups.Remove(makeup);
            DBSingleton.getInstance().SaveChanges();
        }

        public static void removeByBrandId(int id)
        {
            List<Makeup> makeups = DBSingleton.getInstance().Makeups.ToList();
            foreach(Makeup m in makeups)
            {
                if (m.MakeupBrandID == id)
                {
                    DBSingleton.getInstance().Makeups.Remove(m);
                    DBSingleton.getInstance().SaveChanges() ;
                }
            }
        }
        public static void removeByTypeId(int id)
        {
            List<Makeup> makeups = DBSingleton.getInstance().Makeups.ToList();
            foreach (Makeup m in makeups)
            {
                if (m.MakeupTypeID == id)
                {
                    DBSingleton.getInstance().Makeups.Remove(m);
                    DBSingleton.getInstance().SaveChanges();
                }
            }
        }

        public static Makeup findMakeup(int id)
        {
            return DBSingleton.getInstance().Makeups.Find(id);
        }

        public static Makeup findMakeupByName(string name)
        {
            List<Makeup> makeups = getAllMakeups();
            foreach(Makeup m in makeups)
            {
                if (m.MakeupName.Equals(name))
                {
                    return m;
                }
            }
            return null;
        }

        public static void updateMakeup(int id, String name, int price, int weight, int brandId, int typeId)
        {
            Makeup makeup = DBSingleton.getInstance().Makeups.Find(id);
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupBrandID = brandId;
            makeup.MakeupTypeID = typeId;
            DBSingleton.getInstance().SaveChanges();
        }

        public static void addMakeup(Makeup m)
        {
            DBSingleton.getInstance().Makeups.Add(m);
            DBSingleton.getInstance().SaveChanges();
        }
    }
}