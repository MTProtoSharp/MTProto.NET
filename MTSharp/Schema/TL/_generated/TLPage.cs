using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xae891bec)]
    public class TLPage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xae891bec;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Part { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool Rtl { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool V2 { get; set; }
        [MTParameter(Order = 4)]
        public string Url { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsPageBlock> Blocks { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsPhoto> Photos { get; set; }
        [MTParameter(Order = 7)]
        public TLVector<TLAbsDocument> Documents { get; set; }


    }
}
