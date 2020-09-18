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
    [MTObject(0x7438f7e8)]
    public class TLDialogFilter : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x7438f7e8;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Contacts { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool NonContacts { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.True)]
		public bool Groups { get; set; }
		[MTParameter(Order = 4, FlagBitId=3, FlagType= FlagType.True)]
		public bool Broadcasts { get; set; }
		[MTParameter(Order = 5, FlagBitId=4, FlagType= FlagType.True)]
		public bool Bots { get; set; }
		[MTParameter(Order = 6, FlagBitId=11, FlagType= FlagType.True)]
		public bool ExcludeMuted { get; set; }
		[MTParameter(Order = 7, FlagBitId=12, FlagType= FlagType.True)]
		public bool ExcludeRead { get; set; }
		[MTParameter(Order = 8, FlagBitId=13, FlagType= FlagType.True)]
		public bool ExcludeArchived { get; set; }
		[MTParameter(Order = 9)]
		public int Id { get; set; }
		[MTParameter(Order = 10)]
		public string Title { get; set; }
		[MTParameter(Order = 11, FlagBitId=25, FlagType= FlagType.Null)]
		public string Emoticon { get; set; }
		[MTParameter(Order = 12)]
		public TLVector<TLAbsInputPeer> PinnedPeers { get; set; }
		[MTParameter(Order = 13)]
		public TLVector<TLAbsInputPeer> IncludePeers { get; set; }
		[MTParameter(Order = 14)]
		public TLVector<TLAbsInputPeer> ExcludePeers { get; set; }


    }
}
