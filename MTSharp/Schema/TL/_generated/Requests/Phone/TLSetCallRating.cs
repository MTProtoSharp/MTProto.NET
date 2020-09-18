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

namespace MTSharp.Schema.TL.Requests.Phone
{
    [MTObject(0x59ead627)]
    public class TLSetCallRating : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x59ead627;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool UserInitiative { get; set; }
		[MTParameter(Order = 2)]
		public MTSharp.Schema.TL.TLInputPhoneCall Peer { get; set; }
		[MTParameter(Order = 3)]
		public int Rating { get; set; }
		[MTParameter(Order = 4)]
		public string Comment { get; set; }


    }
}
