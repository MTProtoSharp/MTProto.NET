using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x54b56617)]
    public class TLWebPageAttributeTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x54b56617;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsDocument> Documents { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLThemeSettings Settings { get; set; }


    }
}
