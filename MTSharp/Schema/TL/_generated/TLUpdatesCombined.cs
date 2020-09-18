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
    [MTObject(0x725b04c3)]
    public class TLUpdatesCombined : TLAbsUpdates
    {
        public override uint Constructor
        {
            get
            {
                return 0x725b04c3;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsUpdate> Updates { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsUser> Users { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<TLAbsChat> Chats { get; set; }
		[MTParameter(Order = 3)]
		public int Date { get; set; }
		[MTParameter(Order = 4)]
		public int SeqStart { get; set; }
		[MTParameter(Order = 5)]
		public int Seq { get; set; }


    }
}
