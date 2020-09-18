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
    [MTObject(0x98a12b4b)]
    public class TLUpdateChannelMessageViews : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x98a12b4b;
            }
        }

		[MTParameter(Order = 0)]
		public int ChannelId { get; set; }
		[MTParameter(Order = 1)]
		public int Id { get; set; }
		[MTParameter(Order = 2)]
		public int Views { get; set; }


    }
}
