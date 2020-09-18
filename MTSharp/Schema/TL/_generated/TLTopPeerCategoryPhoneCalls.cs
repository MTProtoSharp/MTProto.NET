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
    [MTObject(0x1e76a78c)]
    public class TLTopPeerCategoryPhoneCalls : TLAbsTopPeerCategory
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e76a78c;
            }
        }



    }
}
