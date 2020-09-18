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

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x66afa166)]
    public class TLDeepLinkInfoEmpty : TLAbsDeepLinkInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0x66afa166;
            }
        }



    }
}
