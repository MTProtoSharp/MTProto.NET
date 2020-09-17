using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Url { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
