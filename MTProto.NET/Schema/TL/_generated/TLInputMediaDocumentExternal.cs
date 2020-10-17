using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfb52dc99)]
    public class TLInputMediaDocumentExternal : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xfb52dc99;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Url { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
