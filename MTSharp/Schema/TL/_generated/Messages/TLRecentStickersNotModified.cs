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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xb17f890)]
    public class TLRecentStickersNotModified : TLAbsRecentStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xb17f890;
            }
        }



    }
}
