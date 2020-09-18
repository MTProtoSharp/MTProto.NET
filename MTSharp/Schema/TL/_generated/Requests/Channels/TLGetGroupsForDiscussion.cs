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

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xf5dad378)]
    public class TLGetGroupsForDiscussion : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf5dad378;
            }
        }



    }
}
