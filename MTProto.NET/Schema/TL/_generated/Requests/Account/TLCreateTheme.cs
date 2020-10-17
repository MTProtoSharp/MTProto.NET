using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x8432c21f)]
    public class TLCreateTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8432c21f;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Slug { get; set; }
        [MTParameter(Order = 2)]
        public string Title { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsInputDocument Document { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.Null)]
        public MTProto.NET.Schema.TL.TLInputThemeSettings Settings { get; set; }


    }
}
