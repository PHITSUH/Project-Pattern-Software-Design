using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class DBSingleton
    {
        public static DatabaseEntities db;
        public static DatabaseEntities getInstance()
        {
            if (db == null)
            {
                db = new DatabaseEntities();
            }

            return db;
        }
    }
}