using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x11f1331c)]
    public class TLUpdateShortSentMessage : TLAbsUpdates
    {
        public override uint Constructor
        {
            get
            {
                return 0x11f1331c;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Out { get; set; }
        [MTParameter(Order = 2)]
        public int Id { get; set; }
        [MTParameter(Order = 3)]
        public int Pts { get; set; }
        [MTParameter(Order = 4)]
        public int PtsCount { get; set; }
        [MTParameter(Order = 5)]
        public int Date { get; set; }
        [MTParameter(Order = 6, FlagBitId = 9, FlagType = FlagType.Null)]
        public TLAbsMessageMedia Media { get; set; }
        [MTParameter(Order = 7, FlagBitId = 7, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
