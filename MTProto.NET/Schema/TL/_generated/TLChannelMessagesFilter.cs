using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
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

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool ExcludeNewMessages { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTProto.NET.Schema.TL.TLMessageRange> Ranges { get; set; }


    }
}
