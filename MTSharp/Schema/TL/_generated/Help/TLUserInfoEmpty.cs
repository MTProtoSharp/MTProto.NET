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
    [MTObject(0xf3ae2eed)]
    public class TLUserInfoEmpty : TLAbsUserInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0xf3ae2eed;
            }
        }



    }
}
