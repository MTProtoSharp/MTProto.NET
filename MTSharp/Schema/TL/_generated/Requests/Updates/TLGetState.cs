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

namespace MTSharp.Schema.TL.Requests.Updates
{
    [MTObject(0xedd4882a)]
    public class TLGetState : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xedd4882a;
            }
        }



    }
}
