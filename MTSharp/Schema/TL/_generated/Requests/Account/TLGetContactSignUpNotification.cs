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
    [MTObject(0x9f07c728)]
    public class TLGetContactSignUpNotification : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9f07c728;
            }
        }



    }
}
