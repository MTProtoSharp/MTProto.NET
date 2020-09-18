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

namespace MTSharp.Schema.TL.Channels
{
    [MTObject(0xf0173fe9)]
    public class TLChannelParticipantsNotModified : TLAbsChannelParticipants
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0173fe9;
            }
        }



    }
}
