using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xfa0f3ca2)]
    public class TLUpdatePinnedDialogs : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xfa0f3ca2;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsDialogPeer> Order { get; set; }


    }
}
