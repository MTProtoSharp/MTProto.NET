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
    [MTObject(0xa3b54985)]
    public class TLChannelParticipantsKicked : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xa3b54985;
            }
        }

		[MTParameter(Order = 0)]
		public string Q { get; set; }


    }
}
