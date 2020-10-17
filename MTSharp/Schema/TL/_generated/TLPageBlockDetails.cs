using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x76768bed)]
    public class TLPageBlockDetails : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x76768bed;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Open { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsPageBlock> Blocks { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsRichText Title { get; set; }


    }
}
