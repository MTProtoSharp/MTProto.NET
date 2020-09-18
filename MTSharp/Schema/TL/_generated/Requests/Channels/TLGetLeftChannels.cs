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
    [MTObject(0x8341ecc0)]
    public class TLGetLeftChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8341ecc0;
            }
        }

		[MTParameter(Order = 0)]
		public int Offset { get; set; }


    }
}
