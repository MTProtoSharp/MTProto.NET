using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0xe5f672fa)]
    public class TLSetBotShippingResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe5f672fa;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long QueryId { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Error { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<MTProto.NET.Schema.TL.TLShippingOption> ShippingOptions { get; set; }


    }
}
