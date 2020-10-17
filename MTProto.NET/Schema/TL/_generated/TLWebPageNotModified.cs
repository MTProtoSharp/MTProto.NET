using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x7311ca11)]
    public class TLWebPageNotModified : TLAbsWebPage
    {
        public override uint Constructor
        {
            get
            {
                return 0x7311ca11;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? CachedPageViews { get; set; }


    }
}
