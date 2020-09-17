using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL.Requests.Phone
{
    [MTObject(0x55451fa9)]
    public class TLGetCallConfig : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x55451fa9;
            }
        }



    }
}
