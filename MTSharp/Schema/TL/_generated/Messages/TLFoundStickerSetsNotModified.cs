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
    [MTObject(0xd54b65d)]
    public class TLFoundStickerSetsNotModified : TLAbsFoundStickerSets
    {
        public override uint Constructor
        {
            get
            {
                return 0xd54b65d;
            }
        }



    }
}
