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
    [MTObject(0xee2bb969)]
    public class TLUpdateDraftMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xee2bb969;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPeer Peer { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsDraftMessage Draft { get; set; }


    }
}
