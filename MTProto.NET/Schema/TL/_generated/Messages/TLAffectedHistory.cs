using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Messages
{
    [MTObject(0xb45c69d1)]
    public class TLAffectedHistory : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb45c69d1;
            }
        }

        [MTParameter(Order = 0)]
        public int Pts { get; set; }
        [MTParameter(Order = 1)]
        public int PtsCount { get; set; }
        [MTParameter(Order = 2)]
        public int Offset { get; set; }


    }
}
