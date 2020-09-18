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
    [MTObject(0x74ae4240)]
    public class TLUpdates : TLAbsUpdates
    {
        public override uint Constructor
        {
            get
            {
                return 0x74ae4240;
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
		public int Seq { get; set; }


    }
}
