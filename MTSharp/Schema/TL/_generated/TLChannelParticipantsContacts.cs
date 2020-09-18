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
    [MTObject(0xbb6ae88d)]
    public class TLChannelParticipantsContacts : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xbb6ae88d;
            }
        }

		[MTParameter(Order = 0)]
		public string Q { get; set; }


    }
}
