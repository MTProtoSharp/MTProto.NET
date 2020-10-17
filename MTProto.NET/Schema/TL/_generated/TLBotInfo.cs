using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x98e81d3a)]
    public class TLBotInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x98e81d3a;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public string Description { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<MTProto.NET.Schema.TL.TLBotCommand> Commands { get; set; }


    }
}
