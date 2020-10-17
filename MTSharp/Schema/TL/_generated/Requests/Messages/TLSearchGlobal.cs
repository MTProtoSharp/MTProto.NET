using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xbf7225a4)]
    public class TLSearchGlobal : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf7225a4;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 2)]
        public string Q { get; set; }
        [MTParameter(Order = 3)]
        public int OffsetRate { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsInputPeer OffsetPeer { get; set; }
        [MTParameter(Order = 5)]
        public int OffsetId { get; set; }
        [MTParameter(Order = 6)]
        public int Limit { get; set; }


    }
}
