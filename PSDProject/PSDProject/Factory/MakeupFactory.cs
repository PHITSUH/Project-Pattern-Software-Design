using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class MakeupFactory
    {

        public static Makeup createMakeup(int id, string name, int price, int weight, int typeId, int brandId)
        {
            Makeup m = new Makeup();
            m.MakeupID = id;
            m.MakeupName = name;
            m.MakeupPrice = price;
            m.MakeupWeight = weight;
            m.MakeupTypeID = typeId;
            m.MakeupBrandID = brandId;
            return m;
        }
    }
}