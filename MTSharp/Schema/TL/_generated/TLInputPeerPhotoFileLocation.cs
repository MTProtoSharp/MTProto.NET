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
    [MTObject(0x27d69997)]
    public class TLInputPeerPhotoFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0x27d69997;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Big { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputPeer Peer { get; set; }
		[MTParameter(Order = 3)]
		public long VolumeId { get; set; }
		[MTParameter(Order = 4)]
		public int LocalId { get; set; }


    }
}
