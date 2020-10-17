using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xef02ce6)]
    public class TLDocumentAttributeVideo : TLAbsDocumentAttribute
    {
        public override uint Constructor
        {
            get
            {
                return 0xef02ce6;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool RoundMessage { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool SupportsStreaming { get; set; }
        [MTParameter(Order = 3)]
        public int Duration { get; set; }
        [MTParameter(Order = 4)]
        public int W { get; set; }
        [MTParameter(Order = 5)]
        public int H { get; set; }


    }
}
