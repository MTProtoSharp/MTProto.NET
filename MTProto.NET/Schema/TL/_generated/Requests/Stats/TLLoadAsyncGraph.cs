using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Stats
{
    [MTObject(0x621d5fa0)]
    public class TLLoadAsyncGraph : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x621d5fa0;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Token { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public long? X { get; set; }


    }
}
