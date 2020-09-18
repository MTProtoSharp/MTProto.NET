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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x1c199183)]
    public class TLWallPapersNotModified : TLAbsWallPapers
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c199183;
            }
        }



    }
}
