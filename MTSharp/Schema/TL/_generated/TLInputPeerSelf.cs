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

namespace MTSharp.Schema.TL
{
    [MTObject(0x7da07ec9)]
    public class TLInputPeerSelf : TLAbsInputPeer
    {
        public override uint Constructor
        {
            get
            {
                return 0x7da07ec9;
            }
        }



    }
}
