using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class MakeupTypeRepository
    {

        public static List<MakeupType> getAllMakeupTypes()
        {
            return DBSingleton.getInstance().MakeupTypes.ToList();
        }

        public static void removeMakeupType(int id)
        {
            MakeupType mt = DBSingleton.getInstance().MakeupTypes.Find(id);
            DBSingleton.getInstance().MakeupTypes.Remove(mt);
            DBSingleton.getInstance().SaveChanges();
        }

        public static MakeupType findMakeupType(int id)
        {
            return DBSingleton.getInstance().MakeupTypes.Find(id);
        }

        public static void updateMakeupType(int id, string name)
        {
            MakeupType mt = findMakeupType(id);
            mt.MakeupTypeName = name;
            DBSingleton.getInstance().SaveChanges();

        }

        public static void addMakeupType(MakeupType mt)
        {
            DBSingleton.getInstance().MakeupTypes.Add(mt);
            DBSingleton.getInstance().SaveChanges() ;
        }
        
    }
}