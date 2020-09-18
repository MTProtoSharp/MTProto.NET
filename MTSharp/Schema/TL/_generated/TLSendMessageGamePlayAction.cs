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
    [MTObject(0xdd6a8f48)]
    public class TLSendMessageGamePlayAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xdd6a8f48;
            }
        }



    }
}
