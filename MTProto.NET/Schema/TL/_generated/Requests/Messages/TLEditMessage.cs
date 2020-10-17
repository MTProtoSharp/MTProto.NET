using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x48f71778)]
    public class TLEditMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x48f71778;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool NoWebpage { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputPeer Peer { get; set; }
        [MTParameter(Order = 3)]
        public int Id { get; set; }
        [MTParameter(Order = 4, FlagBitId = 11, FlagType = FlagType.Null)]
        public string Message { get; set; }
        [MTParameter(Order = 5, FlagBitId = 14, FlagType = FlagType.Null)]
        public TLAbsInputMedia Media { get; set; }
        [MTParameter(Order = 6, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }
        [MTParameter(Order = 7, FlagBitId = 3, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 8, FlagBitId = 15, FlagType = FlagType.Null)]
        public int? ScheduleDate { get; set; }


    }
}
