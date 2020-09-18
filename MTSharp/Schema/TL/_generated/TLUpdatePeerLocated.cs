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
    [MTObject(0xb4afcfb0)]
    public class TLUpdatePeerLocated : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xb4afcfb0;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsPeerLocated> Peers { get; set; }


    }
}
