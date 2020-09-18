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
    [MTObject(0xbb3b9804)]
    public class TLResetWallPapers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbb3b9804;
            }
        }



    }
}
