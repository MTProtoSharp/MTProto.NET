using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xebe46819)]
    public class TLUpdateServiceNotification : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xebe46819;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Popup { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public int? InboxDate { get; set; }
        [MTParameter(Order = 3)]
        public string Type { get; set; }
        [MTParameter(Order = 4)]
        public string Message { get; set; }
        [MTParameter(Order = 5)]
        public TLAbsMessageMedia Media { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
