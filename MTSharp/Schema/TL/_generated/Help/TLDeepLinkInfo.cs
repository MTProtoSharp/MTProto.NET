using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x6a4ee832)]
    public class TLDeepLinkInfo : TLAbsDeepLinkInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0x6a4ee832;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool UpdateApp { get; set; }
        [MTParameter(Order = 2)]
        public string Message { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
