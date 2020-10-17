using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xd58f130a)]
    public class TLSetBotCallbackAnswer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd58f130a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Alert { get; set; }
        [MTParameter(Order = 2)]
        public long QueryId { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Message { get; set; }
        [MTParameter(Order = 4, FlagBitId = 2, FlagType = FlagType.Null)]
        public string Url { get; set; }
        [MTParameter(Order = 5)]
        public int CacheTime { get; set; }


    }
}
