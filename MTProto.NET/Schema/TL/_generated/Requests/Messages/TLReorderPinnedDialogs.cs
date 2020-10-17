using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x3b1adf37)]
    public class TLReorderPinnedDialogs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3b1adf37;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Force { get; set; }
        [MTParameter(Order = 2)]
        public int FolderId { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsInputDialogPeer> Order { get; set; }


    }
}
