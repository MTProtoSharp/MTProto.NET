using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xcd77d957)]
    public class TLChannelMessagesFilter : TLAbsChannelMessagesFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xcd77d957;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool ExcludeNewMessages { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTSharp.Schema.TL.TLMessageRange> Ranges { get; set; }


    }
}
