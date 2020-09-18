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
    [MTObject(0x89893b45)]
    public class TLUpdateChannelReadMessagesContents : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x89893b45;
            }
        }

		[MTParameter(Order = 0)]
		public int ChannelId { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<int> Messages { get; set; }


    }
}
