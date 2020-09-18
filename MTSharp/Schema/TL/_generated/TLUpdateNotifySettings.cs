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
    [MTObject(0xbec268ef)]
    public class TLUpdateNotifySettings : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xbec268ef;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsNotifyPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLPeerNotifySettings NotifySettings { get; set; }


    }
}
