using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xc2b7d08b)]
    public class TLSearchStickerSets : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc2b7d08b;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool ExcludeFeatured { get; set; }
        [MTParameter(Order = 2)]
        public string Q { get; set; }
        [MTParameter(Order = 3)]
        public int Hash { get; set; }


    }
}
