using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x347773c5)]
    public class MTPong : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x347773c5;
            }
        }

        [MTParameter(Order = 0)]
        public long MsgId { get; set; }
        [MTParameter(Order = 1)]
        public long PingId { get; set; }


    }
}
