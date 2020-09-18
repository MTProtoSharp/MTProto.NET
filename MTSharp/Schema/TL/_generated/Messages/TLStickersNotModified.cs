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
    [MTObject(0xf1749a22)]
    public class TLStickersNotModified : TLAbsStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xf1749a22;
            }
        }



    }
}
