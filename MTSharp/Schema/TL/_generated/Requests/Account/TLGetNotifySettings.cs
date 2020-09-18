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
    [MTObject(0x12b3ad31)]
    public class TLGetNotifySettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x12b3ad31;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputNotifyPeer Peer { get; set; }


    }
}
