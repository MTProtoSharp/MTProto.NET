using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1b0c841a)]
    public class TLDraftMessageEmpty : TLAbsDraftMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b0c841a;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public int? Date { get; set; }


    }
}
