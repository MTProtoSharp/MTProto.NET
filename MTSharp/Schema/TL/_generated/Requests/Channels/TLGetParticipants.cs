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
    [MTObject(0x123e05e9)]
    public class TLGetParticipants : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x123e05e9;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputChannel Channel { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsChannelParticipantsFilter Filter { get; set; }
		[MTParameter(Order = 2)]
		public int Offset { get; set; }
		[MTParameter(Order = 3)]
		public int Limit { get; set; }
		[MTParameter(Order = 4)]
		public int Hash { get; set; }


    }
}
