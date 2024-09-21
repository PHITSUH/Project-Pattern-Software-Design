using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand createMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand mb = new MakeupBrand();
            mb.MakeupBrandID = id;
            mb.MakeupBrandName = name;
            mb.MakeupBrandRating = rating;
            return mb;
        }
    }
}