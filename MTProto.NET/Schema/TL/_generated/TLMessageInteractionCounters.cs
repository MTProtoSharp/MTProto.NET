using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xad4fc9bd)]
    public class TLMessageInteractionCounters : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xad4fc9bd;
            }
        }

        [MTParameter(Order = 0)]
        public int MsgId { get; set; }
        [MTParameter(Order = 1)]
        public int Views { get; set; }
        [MTParameter(Order = 2)]
        public int Forwards { get; set; }


    }
}
