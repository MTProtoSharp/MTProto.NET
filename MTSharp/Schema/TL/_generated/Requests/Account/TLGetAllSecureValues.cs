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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xb288bc7d)]
    public class TLGetAllSecureValues : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb288bc7d;
            }
        }



    }
}
