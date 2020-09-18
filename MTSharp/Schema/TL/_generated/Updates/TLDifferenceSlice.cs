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

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0xa8fb1981)]
    public class TLDifferenceSlice : TLAbsDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0xa8fb1981;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsMessage> NewMessages { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsEncryptedMessage> NewEncryptedMessages { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<TLAbsUpdate> OtherUpdates { get; set; }
		[MTParameter(Order = 3)]
		public TLVector<TLAbsChat> Chats { get; set; }
		[MTParameter(Order = 4)]
		public TLVector<TLAbsUser> Users { get; set; }
		[MTParameter(Order = 5)]
		public MTSharp.Schema.TL.Updates.TLState IntermediateState { get; set; }


    }
}
