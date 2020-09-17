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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xe470bcfd)]
    public class TLGetPeerDialogs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe470bcfd;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsInputDialogPeer> Peers { get; set; }


    }
}
