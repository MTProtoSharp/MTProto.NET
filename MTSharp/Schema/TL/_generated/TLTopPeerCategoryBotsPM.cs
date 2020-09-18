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
    [MTObject(0xab661b5b)]
    public class TLTopPeerCategoryBotsPM : TLAbsTopPeerCategory
    {
        public override uint Constructor
        {
            get
            {
                return 0xab661b5b;
            }
        }



    }
}
