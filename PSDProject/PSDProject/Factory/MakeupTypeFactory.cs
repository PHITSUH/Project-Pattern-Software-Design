using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class MakeupTypeFactory
    {
        public static MakeupType createMakeupType(int id, string name)
        {
            MakeupType mt = new MakeupType();
            mt.MakeupTypeID = id;
            mt.MakeupTypeName = name;
            return mt;
        }
    }
}