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
    [MTObject(0xcd77d957)]
    public class TLChannelMessagesFilter : TLAbsChannelMessagesFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xcd77d957;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=1, FlagType= FlagType.True)]
		public bool ExcludeNewMessages { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<MTSharp.Schema.TL.TLMessageRange> Ranges { get; set; }


    }
}
