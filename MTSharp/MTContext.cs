using MTSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MTSharp
{
    public static class MTContext
    {

        private static readonly Dictionary<uint, Type> Types = new Dictionary<uint, Type>(); 

        static MTContext()
        {
            Types = (from t in Assembly.GetExecutingAssembly().GetTypes()
                     where t.IsClass && t.Namespace != null && t.Namespace.StartsWith(typeof(MTObject).Namespace)
                     where t.IsSubclassOf(typeof(MTObject))
                     where t.GetCustomAttribute(typeof(MTObjectAttribute)) != null
                     select t).ToDictionary(x => ((MTObjectAttribute)x.GetCustomAttribute(typeof(MTObjectAttribute))).Constructor, x => x);
        }

        public static Type GetType(uint constructor)
        {
            return Types[constructor];
        }
    }
}
