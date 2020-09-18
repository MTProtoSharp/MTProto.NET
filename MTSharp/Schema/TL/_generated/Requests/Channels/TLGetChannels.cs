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
    [MTObject(0xa7f6bbb)]
    public class TLGetChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa7f6bbb;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsInputChannel> Id { get; set; }


    }
}
